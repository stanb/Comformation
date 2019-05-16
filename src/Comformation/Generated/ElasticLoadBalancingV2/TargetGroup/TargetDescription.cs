using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::TargetGroup TargetDescription
    /// Specifies a target to add to a target group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetdescription.html
    /// </summary>
    public class TargetDescription
    {

        /// <summary>
        /// AvailabilityZone
        /// An Availability Zone or all. This determines whether the target receives traffic from the load
        /// balancer nodes in the specified Availability Zone or from all enabled Availability Zones for the
        /// load balancer.
        /// This parameter is not supported if the target type of the target group is instance.
        /// If the target type is ip and the IP address is in a subnet of the VPC for the target group, the
        /// Availability Zone is automatically detected and this parameter is optional. If the IP address is
        /// outside the VPC, this parameter is required.
        /// With an Application Load Balancer, if the target type is ip and the IP address is outside the VPC
        /// for the target group, the only supported value is all.
        /// If the target type is lambda, this parameter is optional and the only supported value is all.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// Id
        /// The ID of the target. If the target type of the target group is instance, specify an instance ID. If
        /// the target type is ip, specify an IP address. If the target type is lambda, specify the ARN of the
        /// Lambda function.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

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
