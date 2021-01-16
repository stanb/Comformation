using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis AnalysisLoadBalancerTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancertarget.html
    /// </summary>
    public class AnalysisLoadBalancerTarget
    {

        /// <summary>
        /// Address
        /// The IP address.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 15
        /// Pattern: ^([0-9]{1,3}. ){3}[0-9]{1,3}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Address")]
        public Union<string, IntrinsicFunction> Address { get; set; }

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// Instance
        /// Information about the instance.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Instance")]
        public AnalysisComponent Instance { get; set; }

        /// <summary>
        /// Port
        /// The port on which the target is listening.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

    }
}
