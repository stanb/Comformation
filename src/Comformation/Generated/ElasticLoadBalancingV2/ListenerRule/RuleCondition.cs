using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule RuleCondition
    /// Specifies a condition for a listener rule.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-conditions.html
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
        /// Values
        /// The condition value. You can use Values if the rule contains only host-header and path-pattern
        /// conditions. Otherwise, you can use HostHeaderConfig for host-header conditions and PathPatternConfig
        /// for path-pattern conditions.
        /// If Field is host-header, you can specify a single host name (for example, my. example. com). A host
        /// name is case insensitive, can be up to 128 characters in length, and can contain any of the
        /// following characters.
        /// A-Z, a-z, 0-9 - . * (matches 0 or more characters) ? (matches exactly 1 character)
        /// If Field is path-pattern, you can specify a single path pattern (for example, /img/*). A path
        /// pattern is case-sensitive, can be up to 128 characters in length, and can contain any of the
        /// following characters.
        /// A-Z, a-z, 0-9 _ - . $ / ~ &quot; &#39; @ : + &amp;amp; (using &amp;amp;amp;) * (matches 0 or more characters) ?
        /// (matches exactly 1 character)
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
