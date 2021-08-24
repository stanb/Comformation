using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.AccountAuditConfiguration
{
    /// <summary>
    /// AWS::IoT::AccountAuditConfiguration AuditNotificationTargetConfigurations
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditnotificationtargetconfigurations.html
    /// </summary>
    public class AuditNotificationTargetConfigurations
    {

        /// <summary>
        /// Sns
        /// The Sns notification target.
        /// Required: No
        /// Type: AuditNotificationTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sns")]
        public AuditNotificationTarget Sns { get; set; }

    }
}
