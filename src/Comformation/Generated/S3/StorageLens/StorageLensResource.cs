using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-storagelens.html
    /// </summary>
    public class StorageLensResource : ResourceBase
    {
        public class StorageLensProperties
        {
            /// <summary>
            /// StorageLensConfiguration
            /// This resource contains the details Amazon S3 Storage Lens configuration.
            /// Required: Yes
            /// Type: StorageLensConfiguration
            /// Update requires: No interruption
            /// </summary>
            public StorageLensConfiguration StorageLensConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// A set of tags (key–value pairs) to associate with the Storage Lens configuration.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::S3::StorageLens";

        public StorageLensProperties Properties { get; } = new StorageLensProperties();

    }

    public static class StorageLensAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StorageLensConfiguration_StorageLensArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("StorageLensConfiguration", "StorageLensArn");
    }
}
