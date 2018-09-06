using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// Amazon SageMaker Model VpcConfig
    /// The VpcConfig property type specifies a VPC that your hosted models have access to. Control access to and from
    /// your training and model containers by configuring the VPC. For more information, see Protect Models by Using
    /// an Amazon Virtual Private Cloud.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// Subnets
        /// The ID of the subnets in the VPC to which you want to connect your training job or model.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subnets")]
        public Union<List<string>, IntrinsicFunction> Subnets { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// The VPC security group IDs, in the form sg-xxxxxxxx. Specify the security groups for the VPC that is
        /// specified in the Subnets field.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

    }
}
