using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.Rule
{
    /// <summary>
    /// AWS::WAFRegional::Rule Predicate
    /// Specifies the ByteMatchSet, IPSet, SqlInjectionMatchSet, XssMatchSet, RegexMatchSet, GeoMatchSet, and
    /// SizeConstraintSet objects that you want to add to a Rule and, for each object, indicates whether you want to
    /// negate the settings, for example, requests that do NOT originate from the IP address 192. 0. 2. 44.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html
    /// </summary>
    public class Predicate
    {

        /// <summary>
        /// Type
        /// 		
        /// The type of predicate in a Rule, such as ByteMatch or IPSet.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ByteMatch | GeoMatch | IPMatch | RegexMatch | SizeConstraint | SqlInjectionMatch |
        /// XssMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// DataId
        /// 		
        /// A unique identifier for a predicate in a Rule, such as ByteMatchSetId or IPSetId. 			The ID is
        /// returned by the corresponding Create or List command.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataId")]
        public Union<string, IntrinsicFunction> DataId { get; set; }

        /// <summary>
        /// Negated
        /// Set Negated to False if you want AWS WAF to allow, block, or count requests based on the settings in
        /// the specified ByteMatchSet, IPSet, SqlInjectionMatchSet, XssMatchSet, RegexMatchSet, GeoMatchSet, or
        /// SizeConstraintSet. For example, if an IPSet includes the IP address 192. 0. 2. 44, AWS WAF will
        /// allow or block requests based on that IP address.
        /// Set Negated to True if you want AWS WAF to allow or block a request based on the negation of the
        /// settings in the ByteMatchSet, IPSet, SqlInjectionMatchSet, XssMatchSet, RegexMatchSet, GeoMatchSet,
        /// or SizeConstraintSet. For example, if an IPSet includes the IP address 192. 0. 2. 44, AWS WAF will
        /// allow, block, or count requests based on all IP addresses except 192. 0. 2. 44.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Negated")]
        public Union<bool, IntrinsicFunction> Negated { get; set; }

    }
}
