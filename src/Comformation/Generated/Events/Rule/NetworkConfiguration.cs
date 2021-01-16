using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule NetworkConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        /// AwsVpcConfiguration
        /// Use this structure to specify the VPC subnets and security groups for the task, and whether a public
        /// IP address is to be used. This structure is relevant only for ECS tasks that use the awsvpc network
        /// mode.
        /// Required: No
        /// Type: AwsVpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsVpcConfiguration")]
        public AwsVpcConfiguration AwsVpcConfiguration { get; set; }

    }
}
