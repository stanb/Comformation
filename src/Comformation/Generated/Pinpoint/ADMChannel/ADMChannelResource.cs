using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.ADMChannel
{
    /// <summary>
    /// AWS::Pinpoint::ADMChannel
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
            /// The unique identifier for the Amazon Pinpoint application that the ADM channel applies to.
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
