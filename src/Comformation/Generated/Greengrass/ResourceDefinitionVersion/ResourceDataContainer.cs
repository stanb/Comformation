using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinitionVersion ResourceDataContainer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html
    /// </summary>
    public class ResourceDataContainer
    {

        /// <summary>
        /// SecretsManagerSecretResourceData
        /// Settings for a secret resource.
        /// Required: No
        /// Type: SecretsManagerSecretResourceData
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecretsManagerSecretResourceData")]
        public SecretsManagerSecretResourceData SecretsManagerSecretResourceData { get; set; }

        /// <summary>
        /// SageMakerMachineLearningModelResourceData
        /// Settings for a machine learning resource saved as an SageMaker training job.
        /// Required: No
        /// Type: SageMakerMachineLearningModelResourceData
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SageMakerMachineLearningModelResourceData")]
        public SageMakerMachineLearningModelResourceData SageMakerMachineLearningModelResourceData { get; set; }

        /// <summary>
        /// LocalVolumeResourceData
        /// Settings for a local volume resource.
        /// Required: No
        /// Type: LocalVolumeResourceData
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LocalVolumeResourceData")]
        public LocalVolumeResourceData LocalVolumeResourceData { get; set; }

        /// <summary>
        /// LocalDeviceResourceData
        /// Settings for a local device resource.
        /// Required: No
        /// Type: LocalDeviceResourceData
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LocalDeviceResourceData")]
        public LocalDeviceResourceData LocalDeviceResourceData { get; set; }

        /// <summary>
        /// S3MachineLearningModelResourceData
        /// Settings for a machine learning resource stored in Amazon S3.
        /// Required: No
        /// Type: S3MachineLearningModelResourceData
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3MachineLearningModelResourceData")]
        public S3MachineLearningModelResourceData S3MachineLearningModelResourceData { get; set; }

    }
}
