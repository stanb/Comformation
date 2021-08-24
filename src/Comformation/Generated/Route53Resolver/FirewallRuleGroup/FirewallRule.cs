using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.FirewallRuleGroup
{
    /// <summary>
    /// AWS::Route53Resolver::FirewallRuleGroup FirewallRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html
    /// </summary>
    public class FirewallRule
    {

        /// <summary>
        /// FirewallDomainListId
        /// The ID of the domain list that&#39;s used in the rule.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FirewallDomainListId")]
        public Union<string, IntrinsicFunction> FirewallDomainListId { get; set; }

        /// <summary>
        /// Priority
        /// The priority of the rule in the rule group. This value must be unique within the rule group. DNS
        /// Firewall processes the rules in a rule group by order of priority, starting from the lowest setting.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// Action
        /// The action that DNS Firewall should take on a DNS query when it matches one of the domains in the
        /// rule&#39;s domain list:
        /// ALLOW - Permit the request to go through. ALERT - Permit the request to go through but send an alert
        /// to the logs. BLOCK - Disallow the request. If this is specified,then BlockResponse must also be
        /// specified. if BlockResponse is OVERRIDE, then all of the following OVERRIDE attributes must be
        /// specified: BlockOverrideDnsType BlockOverrideDomain BlockOverrideTtl
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALERT | ALLOW | BLOCK
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// BlockResponse
        /// The way that you want DNS Firewall to block the request. Used for the rule action setting BLOCK.
        /// NODATA - Respond indicating that the query was successful, but no response is available for it.
        /// NXDOMAIN - Respond indicating that the domain name that&#39;s in the query doesn&#39;t exist. OVERRIDE -
        /// Provide a custom override in the response. This option requires custom handling details in the
        /// rule&#39;s BlockOverride* settings.
        /// Required: No
        /// Type: String
        /// Allowed values: NODATA | NXDOMAIN | OVERRIDE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockResponse")]
        public Union<string, IntrinsicFunction> BlockResponse { get; set; }

        /// <summary>
        /// BlockOverrideDomain
        /// The custom DNS record to send back in response to the query. Used for the rule action BLOCK with a
        /// BlockResponse setting of OVERRIDE.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockOverrideDomain")]
        public Union<string, IntrinsicFunction> BlockOverrideDomain { get; set; }

        /// <summary>
        /// BlockOverrideDnsType
        /// The DNS record&#39;s type. This determines the format of the record value that you provided in
        /// BlockOverrideDomain. Used for the rule action BLOCK with a BlockResponse setting of OVERRIDE.
        /// Required: No
        /// Type: String
        /// Allowed values: CNAME
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockOverrideDnsType")]
        public Union<string, IntrinsicFunction> BlockOverrideDnsType { get; set; }

        /// <summary>
        /// BlockOverrideTtl
        /// The recommended amount of time, in seconds, for the DNS resolver or web browser to cache the
        /// provided override record. Used for the rule action BLOCK with a BlockResponse setting of OVERRIDE.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockOverrideTtl")]
        public Union<int, IntrinsicFunction> BlockOverrideTtl { get; set; }

    }
}
