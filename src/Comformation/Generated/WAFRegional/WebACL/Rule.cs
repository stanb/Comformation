using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.WebACL
{
    /// <summary>
    /// AWS::WAFRegional::WebACL Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// Action
        /// The action that AWS WAF takes when a web request matches all conditions in the rule, such as allow,
        /// block, or count the request.
        /// Required: Yes
        /// Type: Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Action Action { get; set; }

        /// <summary>
        /// Priority
        /// The order in which AWS WAF evaluates the rules in a web ACL. AWS WAF evaluates rules with a lower
        /// value before rules with a higher value. The value must be a unique integer. If you have multiple
        /// rules in a web ACL, the priority numbers do not need to be consecutive.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// RuleId
        /// The ID of an AWS WAF Regional rule to associate with a web ACL.
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
