using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingGroup
{
    /// <summary>
    /// AWS::MediaPackage::PackagingGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packaginggroup.html
    /// </summary>
    public class PackagingGroupResource : ResourceBase
    {
        public class PackagingGroupProperties
        {
            /// <summary>
            /// Id
            /// Unique identifier that you assign to the packaging group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Id { get; set; }

            /// <summary>
            /// Authorization
            /// Parameters for CDN authorization.
            /// Required: No
            /// Type: Authorization
            /// Update requires: No interruption
            /// </summary>
            public Authorization Authorization { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to the packaging group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// EgressAccessLogs
            /// The configuration parameters for egress access logging.
            /// Required: No
            /// Type: LogConfiguration
            /// Update requires: No interruption
            /// </summary>
            public LogConfiguration EgressAccessLogs { get; set; }

        }

        public string Type { get; } = "AWS::MediaPackage::PackagingGroup";

        public PackagingGroupProperties Properties { get; } = new PackagingGroupProperties();

    }

    public static class PackagingGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
    }
}
