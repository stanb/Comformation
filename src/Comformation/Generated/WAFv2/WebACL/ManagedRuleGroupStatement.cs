using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL ManagedRuleGroupStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html
    /// </summary>
    public class ManagedRuleGroupStatement
    {

        /// <summary>
        /// Name
        /// The name of the managed rule group. You use this, along with the vendor name, to identify the rule
        /// group.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[\w\-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// VendorName
        /// The name of the managed rule group vendor. You use this, along with the rule group name, to identify
        /// the rule group.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VendorName")]
        public Union<string, IntrinsicFunction> VendorName { get; set; }

        /// <summary>
        /// Version
        /// The version of the managed rule group to use. Leave this empty to use the vendor&#39;s recommended
        /// version.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^[\w#:\. \-/]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// ExcludedRules
        /// The rules whose actions are set to COUNT by the web ACL, regardless of the action that is configured
        /// in the rule. This effectively excludes the rule from acting on web requests.
        /// Required: No
        /// Type: List of ExcludedRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludedRules")]
        public List<ExcludedRule> ExcludedRules { get; set; }

        /// <summary>
        /// ScopeDownStatement
        /// Statement nested inside a managed rule group statement to narrow the scope of the requests that AWS
        /// WAF evaluates using the rule group. Requests that match the scope-down statement are evaluated using
        /// the rule group. Requests that don&#39;t match the scope-down statement are not a match for the managed
        /// rule group statement, without any further evaluation.
        /// Required: No
        /// Type: Statement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScopeDownStatement")]
        public Statement ScopeDownStatement { get; set; }

    }
}
