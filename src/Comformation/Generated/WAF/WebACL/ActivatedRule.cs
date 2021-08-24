using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.WebACL
{
    /// <summary>
    /// AWS::WAF::WebACL ActivatedRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html
    /// </summary>
    public class ActivatedRule
    {

        /// <summary>
        /// Action
        /// Specifies the action that Amazon CloudFront or AWS WAF takes when a web request matches the
        /// conditions in the Rule. 			Valid values for Action include the following:
        /// 			
        /// 				 				 				 			 ALLOW: CloudFront responds with the requested object. BLOCK: CloudFront responds
        /// with an HTTP 403 (Forbidden) status code. COUNT: AWS WAF increments a counter of requests that match
        /// the conditions in the rule and then continues to 					inspect the web request based on the remaining
        /// rules in the web ACL.
        /// 	
        /// ActivatedRule|OverrideAction applies only when updating or adding a RuleGroup to a WebACL. In this
        /// case, you do not use ActivatedRule|Action. For all other update requests, ActivatedRule|Action is
        /// used instead of ActivatedRule|OverrideAction.
        /// 	
        /// Required: No
        /// Type: WafAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public WafAction Action { get; set; }

        /// <summary>
        /// Priority
        /// 		
        /// Specifies the order in which the Rules in a WebACL are evaluated. Rules with a lower value for
        /// 			Priority are evaluated before Rules with a higher value. The value must be a unique integer. If
        /// you add multiple 			Rules to a WebACL, the values don&#39;t need to be consecutive.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// RuleId
        /// 		
        /// The RuleId for a Rule. You use RuleId to get more information about a Rule, 			update a Rule, insert
        /// a Rule into a WebACL or delete a 			one from a WebACL, or delete a Rule from AWS WAF.
        /// 		
        /// 		 RuleId is returned by CreateRule and by ListRules.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleId")]
        public Union<string, IntrinsicFunction> RuleId { get; set; }

    }
}
