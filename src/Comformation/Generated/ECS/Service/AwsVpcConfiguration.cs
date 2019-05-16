using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service AwsVpcConfiguration
    /// The AwsVpcConfiguration property specifies an object representing the networking details for a task or
    /// service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html
    /// </summary>
    public class AwsVpcConfiguration
    {

        /// <summary>
        /// AssignPublicIp
        /// Whether the task&#39;s elastic network interface receives a public IP address. The default value is
        /// DISABLED.
        /// Required: No
        /// Type: String
        /// Allowed Values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssignPublicIp")]
        public Union<string, IntrinsicFunction> AssignPublicIp { get; set; }

        /// <summary>
        /// SecurityGroups
        /// The security groups associated with the task or service. If you do not specify a security group, the
        /// default security group for the VPC is used. There is a limit of 5 security groups that can be
        /// specified per AwsVpcConfiguration.
        /// Note All specified security groups must be from the same VPC.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// Subnets
        /// The subnets associated with the task or service. There is a limit of 16 subnets that can be
        /// specified per AwsVpcConfiguration.
        /// Note All specified subnets must be from the same VPC.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

    }
}
