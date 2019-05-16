using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project VpcConfig
    /// VpcConfig is a property of the AWS::CodeBuild::Project resource that enable AWS CodeBuild to access resources
    /// in an Amazon VPC. For more information, see Use AWS CodeBuild with Amazon Virtual Private Cloud in the AWS
    /// CodeBuild User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// Subnets
        /// A list of one or more subnet IDs in your Amazon VPC. The maximum count is 16.
        /// Required: No
        /// Type: List of String
        /// Maximum: 16
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

        /// <summary>
        /// VpcId
        /// The ID of the Amazon VPC.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// A list of one or more security groups IDs in your Amazon VPC. The maximum count is 5.
        /// Required: No
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

    }
}
