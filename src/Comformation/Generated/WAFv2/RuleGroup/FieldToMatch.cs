using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup FieldToMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-fieldtomatch.html
    /// </summary>
    public class FieldToMatch
    {

        /// <summary>
        /// SingleHeader
        /// Inspect a single header. Provide the name of the header to inspect, for example, User-Agent or
        /// Referer. This setting isn&#39;t case sensitive.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SingleHeader")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SingleHeader { get; set; }

        /// <summary>
        /// SingleQueryArgument
        /// Inspect a single query argument. Provide the name of the query argument to inspect, such as UserName
        /// or SalesRegion. The name can be up to 30 characters long and isn&#39;t case sensitive.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SingleQueryArgument")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SingleQueryArgument { get; set; }

        /// <summary>
        /// AllQueryArguments
        /// Inspect all query arguments.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllQueryArguments")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AllQueryArguments { get; set; }

        /// <summary>
        /// UriPath
        /// Inspect the request URI path. This is the part of a web request that identifies a resource, for
        /// example, /images/daily-ad. jpg.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UriPath")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> UriPath { get; set; }

        /// <summary>
        /// QueryString
        /// Inspect the query string. This is the part of a URL that appears after a ? character, if any.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryString")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> QueryString { get; set; }

        /// <summary>
        /// Body
        /// Inspect the request body, which immediately follows the request headers. This is the part of a
        /// request that contains any additional data that you want to send to your web server as the HTTP
        /// request body, such as data from a form.
        /// Note that only the first 8 KB (8192 bytes) of the request body are forwarded to AWS WAF for
        /// inspection by the underlying host service. If you don&#39;t need to inspect more than 8 KB, you can
        /// guarantee that you don&#39;t allow additional bytes in by combining a statement that inspects the body
        /// of the web request, such as the ByteMatchStatement or RegexPatternSetReferenceStatement, with a
        /// SizeConstraintStatement that enforces an 8 KB size limit on the body of the request. AWS WAF doesn&#39;t
        /// support inspecting the entire contents of web requests whose bodies exceed the 8 KB limit.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Body")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Body { get; set; }

        /// <summary>
        /// Method
        /// Inspect the HTTP method. The method indicates the type of operation that the request is asking the
        /// origin to perform.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Method")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Method { get; set; }

        /// <summary>
        /// JsonBody
        /// Inspect the request body as JSON. The request body immediately follows the request headers. This is
        /// the part of a request that contains any additional data that you want to send to your web server as
        /// the HTTP request body, such as data from a form.
        /// Note that only the first 8 KB (8192 bytes) of the request body are forwarded to AWS WAF for
        /// inspection by the underlying host service. If you don&#39;t need to inspect more than 8 KB, you can
        /// guarantee that you don&#39;t allow additional bytes in by combining a statement that inspects the body
        /// of the web request, such as the ByteMatchStatement or RegexPatternSetReferenceStatement, with a
        /// SizeConstraintStatement that enforces an 8 KB size limit on the body of the request. AWS WAF doesn&#39;t
        /// support inspecting the entire contents of web requests whose bodies exceed the 8 KB limit.
        /// Required: No
        /// Type: JsonBody
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonBody")]
        public JsonBody JsonBody { get; set; }

    }
}
