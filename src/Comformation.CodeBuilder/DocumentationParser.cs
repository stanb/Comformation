using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comformation.CodeBuilder
{
    public class DocumentationParser
    {
        private static readonly HttpClient _client = new HttpClient();
        private readonly HtmlDocument _doc;
        private readonly Uri _uri;

        public static async Task<DocumentationParser> Parse(string url)
        {
            var uri = new Uri(url);
            using (var stream = await _client.GetStreamAsync(uri))
            {
                var doc = new HtmlDocument();
                doc.Load(stream);
                return new DocumentationParser(uri, doc);
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

            var title = titleNode.InnerText;
            var descNode = titleNode.NextSibling.NextSibling;
            var desc = WordWrap(Strip(descNode.InnerText), 110);
            var lines = desc.Prepend(title).Append(_uri.OriginalString).ToArray();
            return lines;
        }

        public string[] GetPropertyDocumentation(string hashtag)
        {
            var node = _doc.GetElementbyId(hashtag);
            if (node == null)
                return null;

            var dtNode = node.ParentNode;
            var ddNode = dtNode.NextSibling.NextSibling;
            var title = node.NextSibling.ChildNodes.First().InnerText;

            var lines = new List<string>();
            lines.Add(title);

            foreach (var prop in ddNode.ChildNodes)
            {
                var text = WordWrap(Strip(prop.InnerText), 100);
                lines.AddRange(text);
            }

            lines.Add($"{_uri.OriginalString}#{hashtag}");

            return lines.ToArray();
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


        //private static string Fix(string key)
        //{
        //    key = key
        //        .Replace("aws-resource-elasticbeanstalk", "aws-resource-beanstalk")
        //        .Replace("aws-resource-cloudwatch-dashboard", "aws-properties-cw-dashboard")
        //        .Replace("aws-resource-elasticmapreduce-cluster", "aws-resource-emr-cluster")
        //        .Replace("aws-resource-dms-replicationsubnetgroup", "aws-resource-dms-replicationsubnet-group")
        //        .Replace("aws-resource-route53-recordsetgroup", "aws-properties-route53-recordsetgroup");

        //    return key;
        //}

        //private static string FixHashtag(string key)
        //{
        //    if (key.Equals("topicarn"))
        //        return "cfn-sns-topicarn";
        //    key = key
        //        .Replace("aws-sqs-queue", "cfn-sqs-queue")
        //        .Replace("cfn-cloudwatch-dashboard-dashboard", "cfn-cloudwatch-dashboard-")
        //        .Replace("cfn-elasticmapreduce-cluster", "cfn-emr-cluster")
        //        .Replace("cfn-sns-topic-topicname", "cfn-sns-topic-name")
        //        .Replace("cfn-cloudwatch-alarms-dimension", "cfn-cloudwatch-alarms-dimensions")
        //        .Replace("cfn-redshift-cluster-HsmConfigurationIdentifier", "cfn-redshift-cluster-hsmconfigidentifier")
        //        .Replace("cfn-opsworks-app-sslconfiguration", "cfn-opsworks-app-sslconfig")
        //        .Replace("cfn-elasticloadbalancing-loadbalancer-tags", "cfn-ec2-elb-tags")
        //        .Replace("cfn-opsworks-layer-custominstanceprofilearn", "cfn-opsworks-layer-custinstanceprofilearn")
        //        .Replace("cfn-opsworks-layer-customsecuritygroupids", "cfn-opsworks-layer-custsecuritygroupnids")
        //        .Replace("cfn-opsworks-layer-volumeconfigurations", "cfn-opsworks-layer-volconfig")
        //        .Replace("cfn-apigateway-resource-restapiid", "cfn-apigateway-resource-resapiid")
        //        //.Replace("", "")
        //        //.Replace("", "")
        //        //.Replace("", "")
        //        //.Replace("", "")
        //        //.Replace("", "")
        //        //.Replace("", "")
        //        ;
        //    return key;
        //}
    }
}
