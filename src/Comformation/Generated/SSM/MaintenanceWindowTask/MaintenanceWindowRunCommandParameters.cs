using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask MaintenanceWindowRunCommandParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowruncommandparameters.html
    /// </summary>
    public class MaintenanceWindowRunCommandParameters
    {

        /// <summary>
        /// TimeoutSeconds
        /// If this time is reached and the command hasn&#39;t already started running, it doesn&#39;t run.
        /// Required: No
        /// Type: Integer
        /// Minimum: 30
        /// Maximum: 2592000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public Union<int, IntrinsicFunction> TimeoutSeconds { get; set; }

        /// <summary>
        /// Comment
        /// Information about the command or commands to run.
        /// Required: No
        /// Type: String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// OutputS3KeyPrefix
        /// The S3 bucket subfolder.
        /// Required: No
        /// Type: String
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3KeyPrefix")]
        public Union<string, IntrinsicFunction> OutputS3KeyPrefix { get; set; }

        /// <summary>
        /// Parameters
        /// The parameters for the RUN_COMMAND task execution.
        /// The supported parameters are the same as those for the SendCommand API call. For more information,
        /// see SendCommand in the AWS Systems Manager API Reference.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// DocumentHashType
        /// The SHA-256 or SHA-1 hash type. SHA-1 hashes are deprecated.
        /// Required: No
        /// Type: String
        /// Allowed values: Sha1 | Sha256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentHashType")]
        public Union<string, IntrinsicFunction> DocumentHashType { get; set; }

        /// <summary>
        /// ServiceRoleArn
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) service role to use
        /// to publish Amazon Simple Notification Service (Amazon SNS) notifications for maintenance window Run
        /// Command tasks.
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
        /// Type: NotificationConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationConfig")]
        public NotificationConfig NotificationConfig { get; set; }

        /// <summary>
        /// OutputS3BucketName
        /// The name of the Amazon Simple Storage Service (Amazon S3) bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3BucketName")]
        public Union<string, IntrinsicFunction> OutputS3BucketName { get; set; }

        /// <summary>
        /// DocumentHash
        /// The SHA-256 or SHA-1 hash created by the system when the document was created. SHA-1 hashes have
        /// been deprecated.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentHash")]
        public Union<string, IntrinsicFunction> DocumentHash { get; set; }

    }
}
