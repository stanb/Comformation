using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule RuleCondition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html
    /// </summary>
    public class RuleCondition
    {

        /// <summary>
        /// Field
        /// The field in the HTTP request. The following are the possible values:
        /// http-header http-request-method host-header path-pattern query-string source-ip
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Field")]
        public Union<string, IntrinsicFunction> Field { get; set; }

        /// <summary>
        /// HttpHeaderConfig
        /// Information for an HTTP header condition. Specify only when Field is http-header.
        /// Required: Conditional
        /// Type: HttpHeaderConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpHeaderConfig")]
        public HttpHeaderConfig HttpHeaderConfig { get; set; }

        /// <summary>
        /// QueryStringConfig
        /// Information for a query string condition. Specify only when Field is query-string.
        /// Required: Conditional
        /// Type: QueryStringConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryStringConfig")]
        public QueryStringConfig QueryStringConfig { get; set; }

        /// <summary>
        /// Values
        /// The condition value. Specify only when Field is host-header or path-pattern. Alternatively, to
        /// specify multiple host names or multiple path patterns, use HostHeaderConfig or PathPatternConfig.
        /// If Field is host-header and you&#39;re not using HostHeaderConfig, you can specify a single host name
        /// (for example, my. example. com). A host name is case insensitive, can be up to 128 characters in
        /// length, and can contain any of the following characters.
        /// A-Z, a-z, 0-9 - . * (matches 0 or more characters) ? (matches exactly 1 character)
        /// If Field is path-pattern and you&#39;re not using PathPatternConfig, you can specify a single path
        /// pattern (for example, /img/*). A path pattern is case-sensitive, can be up to 128 characters in
        /// length, and can contain any of the following characters.
        /// A-Z, a-z, 0-9 _ - . $ / ~ &quot; &#39; @ : + &amp;amp; (using &amp;amp;amp;) * (matches 0 or more characters) ?
        /// (matches exactly 1 character)
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// HostHeaderConfig
        /// Information for a host header condition. Specify only when Field is host-header.
        /// Required: No
        /// Type: HostHeaderConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostHeaderConfig")]
        public HostHeaderConfig HostHeaderConfig { get; set; }

        /// <summary>
        /// HttpRequestMethodConfig
        /// Information for an HTTP method condition. Specify only when Field is http-request-method.
        /// Required: Conditional
        /// Type: HttpRequestMethodConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpRequestMethodConfig")]
        public HttpRequestMethodConfig HttpRequestMethodConfig { get; set; }

        /// <summary>
        /// PathPatternConfig
        /// Information for a path pattern condition. Specify only when Field is path-pattern.
        /// Required: No
        /// Type: PathPatternConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PathPatternConfig")]
        public PathPatternConfig PathPatternConfig { get; set; }

        /// <summary>
        /// SourceIpConfig
        /// Information for a source IP condition. Specify only when Field is source-ip.
        /// Required: Conditional
        /// Type: SourceIpConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceIpConfig")]
        public SourceIpConfig SourceIpConfig { get; set; }

    }
}
