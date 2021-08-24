using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinitionVersion SageMakerMachineLearningModelResourceData
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata.html
    /// </summary>
    public class SageMakerMachineLearningModelResourceData
    {

        /// <summary>
        /// OwnerSetting
        /// The owner setting for the downloaded machine learning resource. For more information, see 	 Access
        /// Machine Learning Resources from Lambda 	 Functions in the AWS IoT Greengrass Version 1 Developer
        /// Guide.
        /// Required: No
        /// Type: ResourceDownloadOwnerSetting
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OwnerSetting")]
        public ResourceDownloadOwnerSetting OwnerSetting { get; set; }

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
        /// The Amazon Resource Name (ARN) of the Amazon SageMaker training job that represents the source
        /// model.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SageMakerJobArn")]
        public Union<string, IntrinsicFunction> SageMakerJobArn { get; set; }

    }
}
