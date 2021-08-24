using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.AccountAuditConfiguration
{
    /// <summary>
    /// AWS::IoT::AccountAuditConfiguration AuditNotificationTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtarget.html
    /// </summary>
    public class AuditNotificationTarget
    {

        /// <summary>
        /// TargetArn
        /// The ARN of the target (SNS topic) to which audit notifications are sent.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetArn")]
        public Union<string, IntrinsicFunction> TargetArn { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that grants permission to send notifications to the target.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Enabled
        /// True if notifications to the target are enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
