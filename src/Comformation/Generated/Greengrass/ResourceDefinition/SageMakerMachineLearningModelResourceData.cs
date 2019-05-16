using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinition
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinition SageMakerMachineLearningModelResourceData
    /// Settings for an 		Secrets Manager machine learning resource. 		 For more information, see Perform Machine
    /// Learning Inference in the AWS IoT Greengrass Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata.html
    /// </summary>
    public class SageMakerMachineLearningModelResourceData
    {

        /// <summary>
        /// DestinationPath
        /// The absolute local path of the resource inside the Lambda environment.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DestinationPath")]
        public Union<string, IntrinsicFunction> DestinationPath { get; set; }

        /// <summary>
        /// SageMakerJobArn
        /// The Amazon Resource Name (ARN) of the Secrets Manager training job that represents the source model.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SageMakerJobArn")]
        public Union<string, IntrinsicFunction> SageMakerJobArn { get; set; }

    }
}
