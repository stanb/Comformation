using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.Channel
{
    /// <summary>
    /// AWS::MediaPackage::Channel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-channel.html
    /// </summary>
    public class ChannelResource : ResourceBase
    {
        public class ChannelProperties
        {
            /// <summary>
            /// Id
            /// Unique identifier that you assign to the channel.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Id { get; set; }

            /// <summary>
            /// Description
            /// Any descriptive information that you want to add to the channel for future identification purposes.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to the channel.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::MediaPackage::Channel";

        public ChannelProperties Properties { get; } = new ChannelProperties();

    }

    public static class ChannelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<HlsIngest> HlsIngest = new ResourceAttribute<HlsIngest>("HlsIngest");
    }
}
