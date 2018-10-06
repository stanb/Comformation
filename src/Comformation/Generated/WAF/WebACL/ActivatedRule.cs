using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.WebACL
{
    /// <summary>
    /// AWS WAF WebACL ActivatedRule
    /// ActivatedRule is a property of the AWS::WAF::WebACL resource that specifies a rule to associate with an AWS
    /// WAF web access control list (ACL), and the rule&#39;s settings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html
    /// </summary>
    public class ActivatedRule
    {

        /// <summary>
        /// Action
        /// The action that Amazon CloudFront (CloudFront) or AWS WAF takes when a web request matches all
        /// conditions in the rule, such as allow, block, or count the request.
        /// Required: No
        /// Type: AWS WAF WebACL Action
        /// </summary>
        [JsonProperty("Action")]
        public WafAction Action { get; set; }

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
        /// The ID of an AWS WAF rule to associate with a web ACL.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RuleId")]
        public Union<string, IntrinsicFunction> RuleId { get; set; }

    }
}
