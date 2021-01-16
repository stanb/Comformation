using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule AwsVpcConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-awsvpcconfiguration.html
    /// </summary>
    public class AwsVpcConfiguration
    {

        /// <summary>
        /// AssignPublicIp
        /// Specifies whether the task&#39;s elastic network interface receives a public IP address. You can specify
        /// ENABLED only when LaunchType in EcsParameters is set to FARGATE.
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssignPublicIp")]
        public Union<string, IntrinsicFunction> AssignPublicIp { get; set; }

        /// <summary>
        /// SecurityGroups
        /// Specifies the security groups associated with the task. These security groups must all be in the
        /// same VPC. You can specify as many as five security groups. If you do not specify a security group,
        /// the default security group for the VPC is used.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// Subnets
        /// Specifies the subnets associated with the task. These subnets must all be in the same VPC. You can
        /// specify as many as 16 subnets.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

    }
}
