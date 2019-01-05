using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// Elastic Load Balancing ListenerRule Conditions
    /// Conditions is a property of the AWS::ElasticLoadBalancingV2::ListenerRule resource that specifies the
    /// conditions when an Elastic Load Balancing listener rule takes effect.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-conditions.html
    /// </summary>
    public class RuleCondition
    {

        /// <summary>
        /// Field
        /// The name of the condition that you want to define, such as path-pattern (which forwards requests
        /// based on the URL of the request).
        /// Valid values: host-header | path-pattern
        /// Length constraints: Maximum length of 64
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Field")]
        public Union<string, IntrinsicFunction> Field { get; set; }

        /// <summary>
        /// Values
        /// The value for the field that you specified in the Field property.
        /// If you specified host-header for Field, you can specify a single host name (for example, my.
        /// example. com). A host name is case insensitive, can be up to 128 characters in length, and can
        /// contain any of the following characters. You can include up to three wildcard characters.
        /// A-Z, a-z, 0-9 - . * (matches 0 or more characters) ? (matches exactly 1 character)
        /// If you specified path-pattern for Field, you can specify a single path pattern (for example,
        /// /img/*). A path pattern is case-sensitive, can be up to 128 characters in length, and can contain
        /// any of the following characters. You can include up to three wildcard characters.
        /// A-Z, a-z, 0-9 _ - . $ / ~ &quot; &#39; @ : + &amp;amp; (using &amp;amp;amp;) * (matches 0 or more characters) ?
        /// (matches exactly 1 character)
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
