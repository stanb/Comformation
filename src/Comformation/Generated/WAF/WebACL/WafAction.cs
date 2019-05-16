using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.WebACL
{
    /// <summary>
    /// AWS::WAF::WebACL WafAction
    /// For the action that is associated with a rule in a WebACL, specifies the action that you want AWS WAF to
    /// perform when a 			web request matches all of the conditions in a rule. For the default action in a WebACL,
    /// specifies the action that you want 			AWS WAF to take when a web request doesn&#39;t match all of the conditions
    /// in any of the rules in a WebACL.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-action.html
    /// </summary>
    public class WafAction
    {

        /// <summary>
        /// Type
        /// 		
        /// Specifies how you want AWS WAF to respond to requests that match the settings in a Rule. Valid
        /// settings include the following:
        /// 		
        /// 			 			 			 		 ALLOW: AWS WAF allows requests BLOCK: AWS WAF blocks requests COUNT: AWS WAF
        /// increments a counter of the requests that match all of the conditions in the rule. 				AWS WAF then
        /// continues to inspect the web request based on the remaining rules in the web ACL. You can&#39;t specify
        /// COUNT 				for the default action for a WebACL.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ALLOW | BLOCK | COUNT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
