using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.AccountAuditConfiguration
{
    /// <summary>
    /// AWS::IoT::AccountAuditConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-accountauditconfiguration.html
    /// </summary>
    public class AccountAuditConfigurationResource : ResourceBase
    {
        public class AccountAuditConfigurationProperties
        {
            /// <summary>
            /// AccountId
            /// The ID of the account. You can use the expression !Sub &quot;${AWS::AccountId}&quot; to use your account ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AccountId { get; set; }

            /// <summary>
            /// AuditCheckConfigurations
            /// Specifies which audit checks are enabled and disabled for this account.
            /// Some data collection might start immediately when certain checks are enabled. When a check is
            /// disabled, any data collected so far in relation to the check is deleted. To disable a check, set the
            /// value of the Enabled: key to false.
            /// If an enabled check is removed from the template, it will also be disabled.
            /// You can&#39;t disable a check if it&#39;s used by any scheduled audit. You must delete the check from the
            /// scheduled audit or delete the scheduled audit itself to disable the check.
            /// For more information on avialbe auidt checks see AWS::IoT::AccountAuditConfiguration
            /// AuditCheckConfigurations
            /// Required: Yes
            /// Type: AuditCheckConfigurations
            /// Update requires: No interruption
            /// </summary>
            public AuditCheckConfigurations AuditCheckConfigurations { get; set; }

            /// <summary>
            /// AuditNotificationTargetConfigurations
            /// Information about the targets to which audit notifications are sent.
            /// Required: No
            /// Type: AuditNotificationTargetConfigurations
            /// Update requires: No interruption
            /// </summary>
            public AuditNotificationTargetConfigurations AuditNotificationTargetConfigurations { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the role that grants permission to AWS IoT to access information
            /// about your devices, policies, certificates, and other items as required when performing an audit.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::IoT::AccountAuditConfiguration";

        public AccountAuditConfigurationProperties Properties { get; } = new AccountAuditConfigurationProperties();

    }
}
