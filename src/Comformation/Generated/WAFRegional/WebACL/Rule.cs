using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.WebACL
{
    /// <summary>
    /// AWS WAF Regional WebACL Rules
    /// Rules is a property of the AWS::WAFRegional::WebACL resource that specifies the rule to associate with an AWS
    /// WAF Regional web access control list (ACL) and the rule's settings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rules.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// Action
        /// The action that Amazon CloudFront (CloudFront) or AWS WAF takes when a web request matches all
        /// conditions in the rule, such as allow, block, or count the request.
        /// Required: Yes
        /// Type: AWS WAF Regional WebACL Action
        /// </summary>
        [JsonProperty("Action")]
        public Union<Action, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// Priority
        /// The order in which AWS WAF evaluates the rules in a web ACL. AWS WAF evaluates rules with a lower
        /// value before rules with a higher value. The value must be a unique integer. If you have multiple
        /// rules in a web ACL, the priority numbers do not need to be consecutive.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// RuleId
        /// The ID of an AWS WAF Regional rule to associate with a web ACL.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RuleId")]
        public Union<string, IntrinsicFunction> RuleId { get; set; }

    }
}
