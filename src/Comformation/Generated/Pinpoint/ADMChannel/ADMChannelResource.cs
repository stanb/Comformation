using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.ADMChannel
{
    /// <summary>
    /// AWS::Pinpoint::ADMChannel
    /// A channel is a type of platform that you can deliver messages to. You can use the ADM channel to send push
    /// notifications through the Amazon Device Messaging (ADM) service to apps that run on Amazon devices, such as
    /// Kindle Fire tablets. Before you use Amazon Pinpoint to send messages to Amazon devices, you have to enable the
    /// ADM channel for an Amazon Pinpoint application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-admchannel.html
    /// </summary>
    public class ADMChannelResource : ResourceBase
    {
        public class ADMChannelProperties
        {
            /// <summary>
            /// ClientSecret
            /// The Client Secret that you received from Amazon to send messages by using ADM.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ClientSecret { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether to enable the ADM channel for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ClientId
            /// The Client ID that you received from Amazon to send messages by using ADM.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ClientId { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier of the Amazon Pinpoint application that the ADM channel applies to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::ADMChannel";

        public ADMChannelProperties Properties { get; } = new ADMChannelProperties();

    }
}
