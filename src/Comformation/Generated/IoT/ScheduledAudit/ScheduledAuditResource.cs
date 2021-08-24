using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.ScheduledAudit
{
    /// <summary>
    /// AWS::IoT::ScheduledAudit
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html
    /// </summary>
    public class ScheduledAuditResource : ResourceBase
    {
        public class ScheduledAuditProperties
        {
            /// <summary>
            /// ScheduledAuditName
            /// The name of the scheduled audit.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ScheduledAuditName { get; set; }

            /// <summary>
            /// Frequency
            /// How often the scheduled audit occurs.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Frequency { get; set; }

            /// <summary>
            /// DayOfMonth
            /// The day of the month on which the scheduled audit is run (if the frequency is &quot;MONTHLY&quot;). If days
            /// 29-31 are specified, and the month does not have that many days, the audit takes place on the &quot;LAST&quot;
            /// day of the month.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DayOfMonth { get; set; }

            /// <summary>
            /// DayOfWeek
            /// The day of the week on which the scheduled audit is run (if the frequency is &quot;WEEKLY&quot; or
            /// &quot;BIWEEKLY&quot;).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DayOfWeek { get; set; }

            /// <summary>
            /// TargetCheckNames
            /// Which checks are performed during the scheduled audit. Checks must be enabled for your account. (Use
            /// DescribeAccountAuditConfiguration to see the list of all checks, including those that are enabled or
            /// use UpdateAccountAuditConfiguration to select which checks are enabled. )
            /// The following checks are currently aviable:
            /// AUTHENTICATED_COGNITO_ROLE_OVERLY_PERMISSIVE_CHECK CA_CERTIFICATE_EXPIRING_CHECK
            /// CA_CERTIFICATE_KEY_QUALITY_CHECK CONFLICTING_CLIENT_IDS_CHECK DEVICE_CERTIFICATE_EXPIRING_CHECK
            /// DEVICE_CERTIFICATE_KEY_QUALITY_CHECK DEVICE_CERTIFICATE_SHARED_CHECK
            /// IOT_POLICY_OVERLY_PERMISSIVE_CHECK IOT_ROLE_ALIAS_ALLOWS_ACCESS_TO_UNUSED_SERVICES_CHECK
            /// IOT_ROLE_ALIAS_OVERLY_PERMISSIVE_CHECK LOGGING_DISABLED_CHECK
            /// REVOKED_CA_CERTIFICATE_STILL_ACTIVE_CHECK REVOKED_DEVICE_CERTIFICATE_STILL_ACTIVE_CHECK
            /// UNAUTHENTICATED_COGNITO_ROLE_OVERLY_PERMISSIVE_CHECK
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> TargetCheckNames { get; set; }

            /// <summary>
            /// Tags
            /// Metadata that can be used to manage the scheduled audit.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoT::ScheduledAudit";

        public ScheduledAuditProperties Properties { get; } = new ScheduledAuditProperties();

    }

    public static class ScheduledAuditAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ScheduledAuditArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ScheduledAuditArn");
    }
}
