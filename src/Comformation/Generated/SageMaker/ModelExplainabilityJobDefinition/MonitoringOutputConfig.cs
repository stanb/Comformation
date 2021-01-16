using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelExplainabilityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelExplainabilityJobDefinition MonitoringOutputConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-monitoringoutputconfig.html
    /// </summary>
    public class MonitoringOutputConfig
    {

        /// <summary>
        /// KmsKeyId
        /// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the model
        /// artifacts at rest using Amazon S3 server-side encryption.
        /// Required: No
        /// Type: String
        /// Maximum: 2048
        /// Pattern: . *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// MonitoringOutputs
        /// Monitoring outputs for monitoring jobs. This is where the output of the periodic monitoring jobs is
        /// uploaded.
        /// Required: Yes
        /// Type: List of MonitoringOutput
        /// Maximum: 1
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MonitoringOutputs")]
        public List<MonitoringOutput> MonitoringOutputs { get; set; }

    }
}
