using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model VpcConfig
    /// Specifies a VPC that your training jobs and hosted models have access to. Control access to and from your
    /// training and model containers by configuring the VPC. For more information, see Protect Endpoints by Using an
    /// Amazon Virtual Private Cloud and Protect Training Jobs by Using an Amazon Virtual Private Cloud.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// Subnets
        /// The ID of the subnets in the VPC to which you want to connect your training job or model.
        /// Note Amazon EC2 P3 accelerated computing instances are not available in the c/d/e availability zones
        /// of region us-east-1. If you want to create endpoints with P3 instances in VPC mode in region
        /// us-east-1, create subnets in a/b/f availability zones instead.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 16
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

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

    }
}
