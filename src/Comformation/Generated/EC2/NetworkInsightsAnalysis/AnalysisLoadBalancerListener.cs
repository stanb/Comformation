using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis AnalysisLoadBalancerListener
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-analysisloadbalancerlistener.html
    /// </summary>
    public class AnalysisLoadBalancerListener
    {

        /// <summary>
        /// InstancePort
        /// [Classic Load Balancers] The back-end port for the listener.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstancePort")]
        public Union<int, IntrinsicFunction> InstancePort { get; set; }

        /// <summary>
        /// LoadBalancerPort
        /// The port on which the load balancer is listening.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public Union<int, IntrinsicFunction> LoadBalancerPort { get; set; }

    }
}
