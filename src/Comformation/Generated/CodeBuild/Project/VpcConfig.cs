using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project VpcConfig
    /// The VpcConfig property type specifies settings that enable AWS CodeBuild to access resources in an Amazon VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// Subnets
        /// The IDs of the subnets in the Amazon VPC. The maximum count is 16.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

        /// <summary>
        /// VpcId
        /// The ID of the Amazon VPC.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// The IDs of the security groups in the Amazon VPC. The maximum count is 5.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

    }
}
