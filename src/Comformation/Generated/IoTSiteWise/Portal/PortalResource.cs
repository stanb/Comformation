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
        public static readonly ResourceAttribute<PortalStatus> PortalStatus = new ResourceAttribute<PortalStatus>("PortalStatus");
    }
}
