using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS Systems Manager MaintenanceWindowTask NotificationConfig
    /// The NotificationConfig property type specifies configurations for sending notifications for a Maintenance
    /// Window task in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html
    /// </summary>
    public class NotificationConfig
    {

        /// <summary>
        /// NotificationArn
        /// An Amazon Resource Name (ARN) for an Amazon SNS topic. Run Command pushes notifications about
        /// command status changes to this topic.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationArn")]
        public Union<string, IntrinsicFunction> NotificationArn { get; set; }

        /// <summary>
        /// NotificationType
        /// The notification type.
        /// Command: Receive notification when the status of a command changes. Invocation: For commands sent to
        /// multiple instances, receive notification on a per-instance basis when the status of a command
        /// changes.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationType")]
        public Union<string, IntrinsicFunction> NotificationType { get; set; }

        /// <summary>
        /// NotificationEvents
        /// The different events that you can receive notifications for. These events include the following: All
        /// (events), InProgress, Success, TimedOut, Cancelled, Failed. To learn more about these events, see
        /// Understanding Command Statuses in the AWS Systems Manager User Guide.
        /// Required: No
        /// Type: List of strings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationEvents")]
        public Union<List<string>, IntrinsicFunction> NotificationEvents { get; set; }

    }
}
