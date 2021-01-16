using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule S3Output
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-s3output.html
    /// </summary>
    public class S3Output
    {

        /// <summary>
        /// LocalPath
        /// The local path to the S3 storage location where SageMaker saves the results of a monitoring job.
        /// LocalPath is an absolute path for the output data.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LocalPath")]
        public Union<string, IntrinsicFunction> LocalPath { get; set; }

        /// <summary>
        /// S3UploadMode
        /// Whether to upload the results of the monitoring job continuously or after the job completes.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3UploadMode")]
        public Union<string, IntrinsicFunction> S3UploadMode { get; set; }

        /// <summary>
        /// S3Uri
        /// A URI that identifies the S3 storage location where SageMaker saves the results of a monitoring job.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Uri")]
        public Union<string, IntrinsicFunction> S3Uri { get; set; }

    }
}
