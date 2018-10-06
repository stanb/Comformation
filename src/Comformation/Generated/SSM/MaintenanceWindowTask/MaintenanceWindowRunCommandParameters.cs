using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS Systems Manager MaintenanceWindowTask MaintenanceWindowRunCommandParameters
    /// The MaintenanceWindowRunCommandParameters property type specifies the parameters for a RUN_COMMAND task type
    /// for a Maintenance Window task in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html
    /// </summary>
    public class MaintenanceWindowRunCommandParameters
    {

        /// <summary>
        /// TimeoutSeconds
        /// If this time is reached and the command hasn&#39;t already started executing, it doesn&#39;t execute.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public Union<int, IntrinsicFunction> TimeoutSeconds { get; set; }

        /// <summary>
        /// Comment
        /// Information about the command or commands to execute.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// OutputS3KeyPrefix
        /// The Amazon S3 bucket subfolder.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3KeyPrefix")]
        public Union<string, IntrinsicFunction> OutputS3KeyPrefix { get; set; }

        /// <summary>
        /// Parameters
        /// The parameters for the RUN_COMMAND task execution.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// DocumentHashType
        /// The SHA-256 or SHA-1 hash type. SHA-1 hashes are deprecated.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentHashType")]
        public Union<string, IntrinsicFunction> DocumentHashType { get; set; }

        /// <summary>
        /// ServiceRoleArn
        /// The IAM service role that&#39;s used during task execution.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceRoleArn")]
        public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

        /// <summary>
        /// NotificationConfig
        /// Configurations for sending notifications about command status changes on a per-instance basis.
        /// Required: No
        /// Type: Systems Manager MaintenanceWindowTask NotificationConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationConfig")]
        public NotificationConfig NotificationConfig { get; set; }

        /// <summary>
        /// OutputS3BucketName
        /// The name of the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3BucketName")]
        public Union<string, IntrinsicFunction> OutputS3BucketName { get; set; }

        /// <summary>
        /// DocumentHash
        /// The SHA-256 or SHA-1 hash created by the system when the document was created. SHA-1 hashes are
        /// deprecated.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentHash")]
        public Union<string, IntrinsicFunction> DocumentHash { get; set; }

    }
}
