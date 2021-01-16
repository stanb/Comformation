using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.WebACL
{
    /// <summary>
    /// AWS::WAFRegional::WebACL Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// Type
        /// For actions that are associated with a rule, the action that AWS WAF takes when a web request
        /// matches all conditions in a rule.
        /// For the default action of a web access control list (ACL), the action that AWS WAF takes when a web
        /// request doesn&#39;t match all conditions in any rule.
        /// Valid settings include the following:
        /// ALLOW: AWS WAF allows requests BLOCK: AWS WAF blocks requests COUNT: AWS WAF increments a counter of
        /// the requests that match all of the conditions in the rule. AWS WAF then continues to inspect the web
        /// request based on the remaining rules in the web ACL. You can&#39;t specify COUNT for the default action
        /// for a WebACL.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
