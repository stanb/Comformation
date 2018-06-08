using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.Rule
{
    /// <summary>
    /// AWS WAF Rule Predicates
    /// Predicates is a property of the AWS::WAF::Rule resource that specifies the ByteMatchSet, IPSet,
    /// SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects to include in an AWS WAF rule. If you add more
    /// than one predicate to a rule, an incoming request must match all of the specifications in the predicates to be
    /// allowed or blocked.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-rule-predicates.html
    /// </summary>
    public class Predicate
    {

        /// <summary>
        /// DataId
        /// The unique identifier of a predicate, such as the ID of a ByteMatchSet or IPSet.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DataId")]
        public Union<string, IntrinsicFunction> DataId { get; set; }

        /// <summary>
        /// Negated
        /// Whether to use the settings or the negated settings that you specified in the ByteMatchSet, IPSet,
        /// SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects.
        /// Specify false if you want AWS WAF to allow, block, or count requests based on the settings in the
        /// specified ByteMatchSet, IPSet, SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects. For
        /// example, if an IPSet object includes the IP address 192. 0. 2. 44, AWS WAF allows, blocks, or counts
        /// requests originating from that IP address.
        /// Specify true if you want AWS WAF to allow, block, or count requests based on the negated settings in
        /// the ByteMatchSet, IPSet, SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects. For
        /// example, if an IPSet object includes the IP address 192. 0. 2. 44, AWS WAF allows, blocks, or counts
        /// requests originating from all IP addresses except 192. 0. 2. 44.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Negated")]
        public Union<bool, IntrinsicFunction> Negated { get; set; }

        /// <summary>
        /// Type
        /// The type of predicate in a rule, such as an IPSet (IPMatch). For valid values, see the Type contents
        /// of the Predicate data type in the AWS WAF API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
