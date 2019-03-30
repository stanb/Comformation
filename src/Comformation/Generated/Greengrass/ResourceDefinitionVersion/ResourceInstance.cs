using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS IoT Greengrass ResourceDefinitionVersion ResourceInstance
    /// A local resource, 		machine learning resource, or secret resource. 	For more information, see Access Local
    /// Resources with Lambda Functions, 	Perform Machine Learning Inference, and 	Deploy Secrets to the AWS IoT
    /// Greengrass Core in the AWS IoT Greengrass Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourceinstance.html
    /// </summary>
    public class ResourceInstance
    {

        /// <summary>
        /// ResourceDataContainer
        /// A container for resource data. The container takes only one of the following supported resource data
        /// types: 				 LocalDeviceResourceData, LocalVolumeResourceData, 				
        /// SageMakerMachineLearningModelResourceData, S3MachineLearningModelResourceData, or
        /// SecretsManagerSecretResourceData.
        /// Required: Yes
        /// Type: ResourceDataContainer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ResourceDataContainer")]
        public ResourceDataContainer ResourceDataContainer { get; set; }

        /// <summary>
        /// Id
        /// A descriptive or arbitrary ID for the resource. This value must be unique within the resource
        /// definition version. Maximum length is 128 characters with pattern [a-zA-Z0-9:_-]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Name
        /// The descriptive resource name, which is displayed on the AWS IoT Greengrass console. Maximum length
        /// 128 characters with pattern [a-zA-Z0-9:_-]+. This must be unique within a Greengrass group.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
