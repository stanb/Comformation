using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.VoiceChannel
{
    /// <summary>
    /// AWS::Pinpoint::VoiceChannel
    /// Enables the voice channel for an application or updates the status and settings of the voice channel for an
    /// application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-voicechannel.html
    /// </summary>
    public class VoiceChannelResource : ResourceBase
    {
        public class VoiceChannelProperties
        {
            /// <summary>
            /// Enabled
            /// Specifies whether to enable the voice channel for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique ID of the Amazon Pinpoint app that you&#39;re setting up the voice channel for.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::VoiceChannel";

        public VoiceChannelProperties Properties { get; } = new VoiceChannelProperties();

    }
}
