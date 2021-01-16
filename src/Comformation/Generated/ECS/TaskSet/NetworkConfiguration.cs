using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskSet
{
    /// <summary>
    /// AWS::ECS::TaskSet NetworkConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        /// AwsVpcConfiguration
        /// 		
        /// The VPC subnets and security groups associated with a task.
        /// 		
        /// Note All specified subnets and security groups must be from the same VPC.
        /// 	
        /// Required: No
        /// Type: AwsVpcConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AwsVpcConfiguration")]
        public AwsVpcConfiguration AwsVpcConfiguration { get; set; }

    }
}
