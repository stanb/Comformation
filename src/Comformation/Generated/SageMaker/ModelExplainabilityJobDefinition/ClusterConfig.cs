using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelExplainabilityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelExplainabilityJobDefinition ClusterConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-clusterconfig.html
    /// </summary>
    public class ClusterConfig
    {

        /// <summary>
        /// InstanceCount
        /// The number of ML compute instances to use in the model monitoring job. For distributed processing
        /// jobs, specify a value greater than 1. The default value is 1.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceCount")]
        public Union<int, IntrinsicFunction> InstanceCount { get; set; }

        /// <summary>
        /// InstanceType
        /// The ML compute instance type for the processing job.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// VolumeKmsKeyId
        /// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt data on the
        /// storage volume attached to the ML compute instance(s) that run the model monitoring job.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeKmsKeyId")]
        public Union<string, IntrinsicFunction> VolumeKmsKeyId { get; set; }

        /// <summary>
        /// VolumeSizeInGB
        /// The size of the ML storage volume, in gigabytes, that you want to provision. You must specify
        /// sufficient ML storage for your scenario.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public Union<int, IntrinsicFunction> VolumeSizeInGB { get; set; }

    }
}
