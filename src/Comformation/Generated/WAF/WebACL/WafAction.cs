using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.WebACL
{
    /// <summary>
    /// AWS WAF WebACL Action
    /// Action is a property of the AWS::WAF::WebACL resource and the AWS WAF WebACL Rules property that specifies the
    /// action AWS WAF takes when a web request matches or doesn't match all rule conditions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-action.html
    /// </summary>
    public class WafAction
    {

        /// <summary>
        /// Type
        /// For actions that are associated with a rule, the action that AWS WAF takes when a web request
        /// matches all conditions in a rule.
        /// For the default action of a web access control list (ACL), the action that AWS WAF takes when a web
        /// request doesn't match all conditions in any rule.
        /// For valid value, see the Type contents of the WafAction data type in the AWS WAF API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
