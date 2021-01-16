using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.PrefixList
{
    /// <summary>
    /// AWS::EC2::PrefixList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-prefixlist.html
    /// </summary>
    public class PrefixListResource : ResourceBase
    {
        public class PrefixListProperties
        {
            /// <summary>
            /// PrefixListName
            /// A name for the prefix list.
            /// Constraints: Up to 255 characters in length. The name cannot start with com. amazonaws.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PrefixListName { get; set; }

            /// <summary>
            /// AddressFamily
            /// The IP address type.
            /// Valid Values: IPv4 | IPv6
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AddressFamily { get; set; }

            /// <summary>
            /// MaxEntries
            /// The maximum number of entries for the prefix list.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Updates are not supported.
            /// </summary>
            public Union<int, IntrinsicFunction> MaxEntries { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the prefix list.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Entries
            /// One or more entries for the prefix list.
            /// Required: No
            /// Type: List of Entry
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public List<Entry> Entries { get; set; }

        }

        public string Type { get; } = "AWS::EC2::PrefixList";

        public PrefixListProperties Properties { get; } = new PrefixListProperties();

    }

    public static class PrefixListAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PrefixListId = new ResourceAttribute<Union<string, IntrinsicFunction>>("PrefixListId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OwnerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("OwnerId");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> Version = new ResourceAttribute<Union<int, IntrinsicFunction>>("Version");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
