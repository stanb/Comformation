using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule EndpointInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-endpointinput.html
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
        /// Update requires: No interruption
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
        /// Update requires: No interruption
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
        /// Update requires: No interruption
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
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3InputMode")]
        public Union<string, IntrinsicFunction> S3InputMode { get; set; }

    }
}
