using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup JsonBody
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonbody.html
    /// </summary>
    public class JsonBody
    {

        /// <summary>
        /// MatchPattern
        /// The patterns to look for in the JSON body. AWS WAF inspects the results of these pattern matches
        /// against the rule inspection criteria.
        /// Required: Yes
        /// Type: JsonMatchPattern
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchPattern")]
        public JsonMatchPattern MatchPattern { get; set; }

        /// <summary>
        /// MatchScope
        /// The parts of the JSON to match against using the MatchPattern. If you specify All, AWS WAF matches
        /// against keys and values.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALL | KEY | VALUE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchScope")]
        public Union<string, IntrinsicFunction> MatchScope { get; set; }

        /// <summary>
        /// InvalidFallbackBehavior
        /// What AWS WAF should do if it fails to completely parse the JSON body. The options are the following:
        /// 	 	 	 		 EVALUATE_AS_STRING - Inspect the body as 			plain text. AWS WAF applies the text
        /// transformations and 			inspection criteria that you defined for the JSON inspection to 			the body
        /// text string. 	 		 MATCH - Treat the web request as matching 			the rule statement. AWS WAF applies
        /// the rule action to the 			request. 	 		 NO_MATCH - Treat the web request as not 			matching the rule
        /// statement. 	
        /// If you don&#39;t provide this setting, AWS WAF parses and evaluates the content only up to the first
        /// parsing failure that it encounters.
        /// AWS WAF does its best to parse the entire JSON body, but might be forced 	to stop for reasons such
        /// as invalid characters, duplicate keys, 	truncation, and any content whose root node isn&#39;t an object
        /// or an array.
        /// AWS WAF parses the JSON in the following examples as two valid key, 	value pairs:
        /// 	 	 	 		 Missing comma: 			{&quot;key1&quot;:&quot;value1&quot;&quot;key2&quot;:&quot;value2&quot;} 	 		 Missing colon:
        /// 			{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;&quot;value2&quot;} 	 		 Extra colons: 			{&quot;key1&quot;::&quot;value1&quot;,&quot;key2&quot;&quot;value2&quot;} 	
        /// Required: No
        /// Type: String
        /// Allowed values: EVALUATE_AS_STRING | MATCH | NO_MATCH
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InvalidFallbackBehavior")]
        public Union<string, IntrinsicFunction> InvalidFallbackBehavior { get; set; }

    }
}
