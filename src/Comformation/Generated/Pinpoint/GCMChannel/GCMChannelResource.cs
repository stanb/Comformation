using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.GCMChannel
{
    /// <summary>
    /// AWS::Pinpoint::GCMChannel
    /// A channel is a type of platform that you can deliver messages to. You can use the GCM channel to send push
    /// notification messages to the Firebase Cloud Messaging (FCM) service, which replaced the Google Cloud Messaging
    /// (GCM) service. Before you use Amazon Pinpoint to send notifications to FCM, you have to enable the GCM channel
    /// for an Amazon Pinpoint application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-gcmchannel.html
    /// </summary>
    public class GCMChannelResource : ResourceBase
    {
        public class GCMChannelProperties
        {
            /// <summary>
            /// ApiKey
            /// The API key, also called the server key, that you received from Google to communicate with Google
            /// services.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApiKey { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether to enable the GCM channel for the Amazon Pinpoint application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier for the Amazon Pinpoint app that the GCM channel applies to.
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
