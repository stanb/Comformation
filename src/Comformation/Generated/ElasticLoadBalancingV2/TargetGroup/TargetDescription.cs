using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// Elastic Load Balancing TargetGroup TargetDescription
    /// TargetDescription is a property of the AWS::ElasticLoadBalancingV2::TargetGroup resource that specifies a
    /// target to add to an Elastic Load Balancing target group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetdescription.html
    /// </summary>
    public class TargetDescription
    {

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone where the IP address is to be registered. For more information, see
        /// TargetDescription in the Elastic Load Balancing API Reference version 2015-12-01.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// Id
        /// The ID of the target, such as an EC2 instance ID. If the target type of the target group is
        /// instance, specify an instance ID. If the target type is ip, specify an IP address.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Port
        /// The port number on which the target is listening for traffic.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

    }
}
