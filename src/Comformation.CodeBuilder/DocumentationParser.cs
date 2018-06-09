using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comformation.CodeBuilder
{
    public class DocumentationParser
    {
        private static readonly HttpClient _client = new HttpClient(new HttpClientHandler() { AllowAutoRedirect = false });
        private readonly HtmlDocument _doc;
        private readonly Uri _uri;

        private static Lazy<Dictionary<string, string>> _fixedUrls = new Lazy<Dictionary<string, string>>(LoadFixedUrls);

        private static Dictionary<string, string> LoadFixedUrls()
        {
            var fixedUrls = new Dictionary<string, string>();
            var lines = File.ReadAllLines("fixed_urls.csv");
            foreach (var line in lines)
            {
                var parts = line.Split(",");
                if (parts.Length == 3 && !string.IsNullOrWhiteSpace(parts[2]))
                    fixedUrls.Add(parts[1].Trim(), parts[2].Trim());
            }
            return fixedUrls;
        }

        public static async Task<DocumentationParser> Parse(string url)
        {
            if(!_fixedUrls.Value.TryGetValue(url, out string fixedUrl))
            {
                fixedUrl = url.Replace("http://", "https://");
            }

            var uri = new Uri(fixedUrl);

            try
            {
                using (var stream = await _client.GetStreamAsync(uri))
                {
                    var doc = new HtmlDocument();
                    doc.Load(stream);
                    return new DocumentationParser(uri, doc);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private DocumentationParser(Uri uri, HtmlDocument doc)
        {
            _uri = uri;
            _doc = doc;
        }

        public string[] GetResourceDocumentation()
        {
            var id = _uri.Segments.Last().Split(".")[0];
            var titleNode = _doc.GetElementbyId(id);
            if (titleNode == null)
                return null;

            var title = WordWrap(Strip(titleNode.InnerText), 110);
            var descNode = titleNode.NextSibling.NextSibling;
            var desc = WordWrap(Strip(descNode.InnerText), 110);
            var lines = title.Concat(desc)
                .Append(_uri.OriginalString)
                .Select(line => WebUtility.HtmlEncode(line))
                .ToArray();
            return lines;
        }

        public string[] GetPropertyDocumentation(string propName)
        {
            var propTitleNode = _doc.DocumentNode.SelectNodes($"//div[@class='variablelist']/dl/dt/span/code")
                .FirstOrDefault(node => node.InnerText == propName);
            if (propTitleNode == null)
                return new[] { propName };

            var ddNode = propTitleNode.ParentNode.ParentNode.NextSibling.NextSibling;
            var lines = new List<string>();
            lines.Add(propName);
            foreach (var prop in ddNode.ChildNodes)
            {
                var text = WordWrap(Strip(prop.InnerText), 100);
                lines.AddRange(text);
            }
            return lines
                .Select(line => WebUtility.HtmlEncode(line))
                .ToArray();
        }

        private static Regex _regex = new Regex(" {2,}", RegexOptions.Multiline | RegexOptions.Compiled);

        private static string Strip(string text)
        {
            text = text.Replace("\n", " ").Replace(".", ". ");
            text = _regex.Replace(text, " ");
            return text;
        }

        private IEnumerable<string> WordWrap(string text, int width)
        {
            var words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            foreach (var word in words)
            {
                if (sb.Length == 0)
                {
                    sb = new StringBuilder();
                    sb.Append(word);
                }
                else if (sb.Length + 1 + word.Length <= width)
                {
                    sb.Append(" ");
                    sb.Append(word);
                }
                else
                {
                    yield return sb.ToString();
                    sb.Clear();
                    sb.Append(word);
                }
            }

            if (sb.Length > 0)
                yield return sb.ToString();
            yield break;
        }
    }
}
