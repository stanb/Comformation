using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelExplainabilityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelExplainabilityJobDefinition VpcConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// SecurityGroupIds
        /// The VPC security group IDs, in the form sg-xxxxxxxx. Specify the security groups for the VPC that is
        /// specified in the Subnets field.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// Subnets
        /// The ID of the subnets in the VPC to which you want to connect your training job or model. For
        /// information about the availability of specific instance types, see Supported Instance Types and
        /// Availability Zones.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 16
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

    }
}
