using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskSet
{
    /// <summary>
    /// AWS::ECS::TaskSet AwsVpcConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-awsvpcconfiguration.html
    /// </summary>
    public class AwsVpcConfiguration
    {

        /// <summary>
        /// AssignPublicIp
        /// 		
        /// Whether the task&#39;s elastic network interface receives a public IP address. The default 			value is
        /// DISABLED.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AssignPublicIp")]
        public Union<string, IntrinsicFunction> AssignPublicIp { get; set; }

        /// <summary>
        /// SecurityGroups
        /// 		
        /// The IDs of the security groups associated with the task or service. If you do not 			specify a
        /// security group, the default security group for the VPC is used. There is a 			limit of 5 security
        /// groups that can be specified per 			AwsVpcConfiguration.
        /// 		 		
        /// Note All specified security groups must be from the same VPC.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// Subnets
        /// 		
        /// The IDs of the subnets associated with the task or service. There is a limit of 16 			subnets that
        /// can be specified per AwsVpcConfiguration.
        /// 		 		
        /// Note All specified subnets must be from the same VPC.
        /// 	
        /// Required: Yes
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

    }
}
