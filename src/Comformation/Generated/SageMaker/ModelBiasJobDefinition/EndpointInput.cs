using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelBiasJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelBiasJobDefinition EndpointInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html
    /// </summary>
    public class EndpointInput
    {

        /// <summary>
        /// EndpointName
        /// An endpoint in customer&#39;s account which has enabled DataCaptureConfig enabled.
        /// Required: Yes
        /// Type: String
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EndpointName")]
        public Union<string, IntrinsicFunction> EndpointName { get; set; }

        /// <summary>
        /// LocalPath
        /// Path to the filesystem where the endpoint data is available to the container.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: . *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LocalPath")]
        public Union<string, IntrinsicFunction> LocalPath { get; set; }

        /// <summary>
        /// S3DataDistributionType
        /// Whether input data distributed in Amazon S3 is fully replicated or sharded by an S3 key. Defaults to
        /// FullyReplicated
        /// Required: No
        /// Type: String
        /// Allowed values: FullyReplicated | ShardedByS3Key
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3DataDistributionType")]
        public Union<string, IntrinsicFunction> S3DataDistributionType { get; set; }

        /// <summary>
        /// S3InputMode
        /// Whether the Pipe or File is used as the input mode for transfering data for the monitoring job. Pipe
        /// mode is recommended for large datasets. File mode is useful for small files that fit in memory.
        /// Defaults to File.
        /// Required: No
        /// Type: String
        /// Allowed values: File | Pipe
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3InputMode")]
        public Union<string, IntrinsicFunction> S3InputMode { get; set; }

        /// <summary>
        /// StartTimeOffset
        /// If specified, monitoring jobs substract this time from the start time. For information about using
        /// offsets for scheduling monitoring jobs, see Schedule Model Quality Monitoring Jobs.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 15
        /// Pattern: ^. ?P. *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public Union<string, IntrinsicFunction> StartTimeOffset { get; set; }

        /// <summary>
        /// EndTimeOffset
        /// If specified, monitoring jobs substract this time from the end time. For information about using
        /// offsets for scheduling monitoring jobs, see Schedule Model Quality Monitoring Jobs.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 15
        /// Pattern: ^. ?P. *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public Union<string, IntrinsicFunction> EndTimeOffset { get; set; }

        /// <summary>
        /// FeaturesAttribute
        /// The attributes of the input data that are the input features.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FeaturesAttribute")]
        public Union<string, IntrinsicFunction> FeaturesAttribute { get; set; }

        /// <summary>
        /// InferenceAttribute
        /// The attribute of the input data that represents the ground truth label.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InferenceAttribute")]
        public Union<string, IntrinsicFunction> InferenceAttribute { get; set; }

        /// <summary>
        /// ProbabilityAttribute
        /// In a classification problem, the attribute that represents the class probability.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ProbabilityAttribute")]
        public Union<string, IntrinsicFunction> ProbabilityAttribute { get; set; }

        /// <summary>
        /// ProbabilityThresholdAttribute
        /// The threshold for the class probability to be evaluated as a positive result.
        /// Required: No
        /// Type: Double
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ProbabilityThresholdAttribute")]
        public Union<double, IntrinsicFunction> ProbabilityThresholdAttribute { get; set; }

    }
}
