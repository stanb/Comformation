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
            /// the best experience for their devices and network conditions. Resolution can be up to 1080p and
            /// bitrate can be up to 8. 5 Mbps. Audio is transcoded only for renditions 360p and below; above that,
            /// audio is passed through. BASIC: delivers the original input to viewers. The viewer’s video-quality
            /// choice is limited to the original input. Resolution can be up to 480p and bitrate can be up to 1. 5
            /// Mbps.
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

            /// <summary>
            /// RecordingConfigurationArn
            /// The ARN of a RecordingConfiguration resource. An empty string indicates that recording is disabled
            /// for the channel. A RecordingConfiguration ARN indicates that recording is enabled using the
            /// specified recording configuration. See the RecordingConfiguration resource for more information and
            /// an example.
            /// Default: &quot;&quot; (empty string, recording is disabled)
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 128
            /// Pattern: ^$|^arn:aws:ivs:[a-z0-9-]+:[0-9]+:recording-configuration/[a-zA-Z0-9-]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RecordingConfigurationArn { get; set; }

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
