using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis AnalysisSecurityGroupRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysissecuritygrouprule.html
    /// </summary>
    public class AnalysisSecurityGroupRule
    {

        /// <summary>
        /// Cidr
        /// The IPv4 address range, in CIDR notation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cidr")]
        public Union<string, IntrinsicFunction> Cidr { get; set; }

        /// <summary>
        /// Direction
        /// The direction. The following are possible values:
        /// egress ingress
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Direction")]
        public Union<string, IntrinsicFunction> Direction { get; set; }

        /// <summary>
        /// SecurityGroupId
        /// The security group ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public Union<string, IntrinsicFunction> SecurityGroupId { get; set; }

        /// <summary>
        /// PortRange
        /// The port range.
        /// Required: No
        /// Type: PortRange
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PortRange")]
        public PortRange PortRange { get; set; }

        /// <summary>
        /// PrefixListId
        /// The prefix list ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrefixListId")]
        public Union<string, IntrinsicFunction> PrefixListId { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
