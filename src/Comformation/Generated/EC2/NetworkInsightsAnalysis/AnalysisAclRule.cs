using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis AnalysisAclRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisaclrule.html
    /// </summary>
    public class AnalysisAclRule
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
        /// Egress
        /// Indicates whether the rule is an outbound rule.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Egress")]
        public Union<bool, IntrinsicFunction> Egress { get; set; }

        /// <summary>
        /// PortRange
        /// The range of ports.
        /// Required: No
        /// Type: PortRange
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PortRange")]
        public PortRange PortRange { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// RuleAction
        /// Indicates whether to allow or deny traffic that matches the rule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleAction")]
        public Union<string, IntrinsicFunction> RuleAction { get; set; }

        /// <summary>
        /// RuleNumber
        /// The rule number.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleNumber")]
        public Union<int, IntrinsicFunction> RuleNumber { get; set; }

    }
}
