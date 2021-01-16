using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IVS.Channel
{
    /// <summary>
    /// AWS::IVS::Channel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-channel.html
    /// </summary>
    public class ChannelResource : ResourceBase
    {
        public class ChannelProperties
        {
            /// <summary>
            /// Name
            /// Channel name.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9-_]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Authorized
            /// Whether the channel is authorized.
            /// Default: false
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Authorized { get; set; }

            /// <summary>
            /// LatencyMode
            /// Channel latency mode. Valid values:
            /// NORMAL: Use NORMAL to broadcast and deliver live video up to Full HD. LOW: Use LOW for near
            /// real-time interactions with viewers.
            /// Note In the Amazon IVS console, LOW and NORMAL correspond to Ultra-low and Standard, respectively.
            /// Default: LOW
            /// Required: No
            /// Type: String
            /// Allowed values: LOW | NORMAL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LatencyMode { get; set; }

            /// <summary>
            /// Type
            /// The channel type, which determines the allowable resolution and bitrate. If you exceed the allowable
            /// resolution or bitrate, the stream probably will disconnect immediately. Valid values:
            /// STANDARD: Multiple qualities are generated from the original input, to automatically give viewers
            /// the best experience for their devices and network conditions. Vertical resolution can be up to 1080
            /// and bitrate can be up to 8. 5 Mbps. BASIC: delivers the original input to viewers. The viewer’s
            /// video-quality choice is limited to the original input. Vertical resolution can be up to 480 and
            /// bitrate can be up to 1. 5 Mbps.
            /// Default: STANDARD
            /// Required: No
            /// Type: String
            /// Allowed values: BASIC | STANDARD
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IVS::Channel";

        public ChannelProperties Properties { get; } = new ChannelProperties();

    }

    public static class ChannelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PlaybackUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("PlaybackUrl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IngestEndpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("IngestEndpoint");
    }
}
