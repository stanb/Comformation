using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinitionVersion S3MachineLearningModelResourceData
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata.html
    /// </summary>
    public class S3MachineLearningModelResourceData
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
        /// S3Uri
        /// The URI of the source model in an Amazon S3 bucket. The model package must be in tar. gz 				 or .
        /// zip format.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3Uri")]
        public Union<string, IntrinsicFunction> S3Uri { get; set; }

    }
}
