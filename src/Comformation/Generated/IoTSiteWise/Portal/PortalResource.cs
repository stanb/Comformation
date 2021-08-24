using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Portal
{
    /// <summary>
    /// AWS::IoTSiteWise::Portal
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-portal.html
    /// </summary>
    public class PortalResource : ResourceBase
    {
        public class PortalProperties
        {
            /// <summary>
            /// PortalAuthMode
            /// The service to use to authenticate users to the portal. Choose from the following options:
            /// SSO – The portal uses AWS Single Sign-On to authenticate users and manage user permissions. Before
            /// you can create a portal that uses AWS SSO, you must enable AWS SSO. For more information, see
            /// Enabling AWS SSO in the AWS IoT SiteWise User Guide. This option is only available in AWS Regions
            /// other than the China Regions. IAM – The portal uses AWS Identity and Access Management (IAM) to
            /// authenticate users and manage user permissions. This option is only available in China (Beijing).
            /// You can&#39;t change this value after you create a portal.
            /// Default: SSO
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PortalAuthMode { get; set; }

            /// <summary>
            /// PortalContactEmail
            /// The AWS administrator&#39;s contact email address.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PortalContactEmail { get; set; }

            /// <summary>
            /// PortalDescription
            /// A description for the portal.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PortalDescription { get; set; }

            /// <summary>
            /// PortalName
            /// A friendly name for the portal.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PortalName { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of a service role that allows the portal&#39;s users to access your AWS IoT SiteWise resources
            /// on your behalf. For more information, see Using service roles for AWS IoT SiteWise Monitor in the
            /// AWS IoT SiteWise User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// NotificationSenderEmail
            /// The email address that sends alarm notifications.
            /// Important If you use the AWS IoT Events managed Lambda function to manage your emails, you must
            /// verify the sender email address in Amazon SES.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NotificationSenderEmail { get; set; }

            /// <summary>
            /// Alarms
            /// Contains the configuration information of an alarm created in an AWS IoT SiteWise Monitor portal.
            /// You can use the alarm to monitor an asset property and get notified when the asset property value is
            /// outside a specified range. For more information, see Monitoring with alarms in the AWS IoT SiteWise
            /// Application Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Alarms { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs that contain metadata for the portal. For more information, see Tagging
            /// your AWS IoT SiteWise resources in the AWS IoT SiteWise User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTSiteWise::Portal";

        public PortalProperties Properties { get; } = new PortalProperties();

    }

    public static class PortalAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PortalArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("PortalArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PortalClientId = new ResourceAttribute<Union<string, IntrinsicFunction>>("PortalClientId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PortalId = new ResourceAttribute<Union<string, IntrinsicFunction>>("PortalId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PortalStartUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("PortalStartUrl");
    }
}
