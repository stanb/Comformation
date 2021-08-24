using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.AccountAuditConfiguration
{
    /// <summary>
    /// AWS::IoT::AccountAuditConfiguration AuditCheckConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfiguration.html
    /// </summary>
    public class AuditCheckConfiguration
    {

        /// <summary>
        /// Enabled
        /// True if this audit check is enabled for this account.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
