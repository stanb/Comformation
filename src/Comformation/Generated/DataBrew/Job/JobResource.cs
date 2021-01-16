using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html
    /// </summary>
    public class JobResource : ResourceBase
    {
        public class JobProperties
        {
            /// <summary>
            /// DatasetName
            /// A dataset that the job is to process.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DatasetName { get; set; }

            /// <summary>
            /// EncryptionKeyArn
            /// The Amazon Resource Name (ARN) of an encryption key that is used to protect the job output. For more
            /// information, see Encrypting data written by DataBrew jobs
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EncryptionKeyArn { get; set; }

            /// <summary>
            /// EncryptionMode
            /// The encryption mode for the job, which can be one of the following:
            /// SSE-KMS - Server-side encryption with AWS KMS-managed keys. SSE-S3 - Server-side encryption with
            /// keys managed by Amazon S3.
            /// Required: No
            /// Type: String
            /// Allowed values: SSE-KMS | SSE-S3
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EncryptionMode { get; set; }

            /// <summary>
            /// Name
            /// The unique name of the job.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 240
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Type
            /// The job type of the job, which must be one of the following:
            /// PROFILE - A job to analyze a dataset, to determine its size, data types, data distribution, and
            /// more. RECIPE - A job to apply one or more transformations to a dataset.
            /// Required: Yes
            /// Type: String
            /// Allowed values: PROFILE | RECIPE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// LogSubscription
            /// The current status of Amazon CloudWatch logging for the job.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLE | ENABLE
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LogSubscription { get; set; }

            /// <summary>
            /// MaxCapacity
            /// The maximum number of nodes that can be consumed when the job processes data.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

            /// <summary>
            /// MaxRetries
            /// The maximum number of times to retry the job after a job run fails.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxRetries { get; set; }

            /// <summary>
            /// Outputs
            /// One or more artifacts that represent output from running the job.
            /// Required: No
            /// Type: List of Output
            /// Update requires: No interruption
            /// </summary>
            public List<Output> Outputs { get; set; }

            /// <summary>
            /// OutputLocation
            /// The location in Amazon S3 where the job writes its output.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> OutputLocation { get; set; }

            /// <summary>
            /// ProjectName
            /// The name of the project that the job is associated with.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectName { get; set; }

            /// <summary>
            /// Recipe
            /// A series of data transformation steps that the job runs.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Recipe { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the role that will be assumed for this job.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// Metadata tags that have been applied to the job.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Timeout
            /// The job&#39;s timeout in minutes. A job that attempts to run longer than this timeout period ends with a
            /// status of TIMEOUT.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Timeout { get; set; }

        }

        public string Type { get; } = "AWS::DataBrew::Job";

        public JobProperties Properties { get; } = new JobProperties();

    }
}
