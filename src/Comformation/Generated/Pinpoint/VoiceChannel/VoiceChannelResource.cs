using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.VoiceChannel
{
    /// <summary>
    /// AWS::Pinpoint::VoiceChannel
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
            /// The unique identifier for the Amazon Pinpoint application that the voice channel applies to.
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
