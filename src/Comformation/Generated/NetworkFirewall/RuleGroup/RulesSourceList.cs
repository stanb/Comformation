using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup RulesSourceList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html
    /// </summary>
    public class RulesSourceList
    {

        /// <summary>
        /// Targets
        /// The domains that you want to inspect for in your traffic flows. To provide multiple domains,
        /// separate them with commas. Valid domain specifications are the following:
        /// Explicit names. For example, abc. example. com matches only the domain abc. example. com. Names that
        /// use a domain wildcard, which you indicate with an initial &#39;. &#39;. For example,. example. com matches
        /// example. com and matches all subdomains of example. com, such as abc. example. com and www. example.
        /// com. 	
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Targets")]
        public List<Union<string, IntrinsicFunction>> Targets { get; set; }

        /// <summary>
        /// TargetTypes
        /// The types of targets to inspect for. Valid values are TLS_SNI and HTTP_HOST.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTypes")]
        public List<Union<string, IntrinsicFunction>> TargetTypes { get; set; }

        /// <summary>
        /// GeneratedRulesType
        /// Whether you want to allow or deny access to the domains in your target list.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALLOWLIST | DENYLIST
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GeneratedRulesType")]
        public Union<string, IntrinsicFunction> GeneratedRulesType { get; set; }

    }
}
