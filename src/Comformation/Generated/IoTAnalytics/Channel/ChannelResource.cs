using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Channel
{
    /// <summary>
    /// AWS::IoTAnalytics::Channel
    /// The AWS::IoTAnalytics::Channel resource collects data from an MQTT topic and archives the raw, unprocessed
    /// messages before publishing the data to a pipeline. For more information, see How to Use AWS IoT Analytics in
    /// the AWS IoT Analytics User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-channel.html
    /// </summary>
    public class ChannelResource : ResourceBase
    {
        public class ChannelProperties
        {
            /// <summary>
            /// ChannelName
            /// The name of the channel.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_]+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ChannelName { get; set; }

            /// <summary>
            /// ChannelStorage
            /// Where channel data is stored.
            /// Required: No
            /// Type: ChannelStorage
            /// Update requires: No interruption
            /// </summary>
			public ChannelStorage ChannelStorage { get; set; }

            /// <summary>
            /// RetentionPeriod
            /// How long, in days, message data is kept for the channel.
            /// Required: No
            /// Type: RetentionPeriod
            /// Update requires: No interruption
            /// </summary>
			public RetentionPeriod RetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the channel.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTAnalytics::Channel";

        public ChannelProperties Properties { get; } = new ChannelProperties();

    }
}
