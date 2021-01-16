using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.GCMChannel
{
    /// <summary>
    /// AWS::Pinpoint::GCMChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-gcmchannel.html
    /// </summary>
    public class GCMChannelResource : ResourceBase
    {
        public class GCMChannelProperties
        {
            /// <summary>
            /// ApiKey
            /// The Web API Key, also referred to as an API_KEY or server key, that you received from Google to
            /// communicate with Google services.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApiKey { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether to enable the GCM channel for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier for the application that the GCM channel applies to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::GCMChannel";

        public GCMChannelProperties Properties { get; } = new GCMChannelProperties();

    }
}
