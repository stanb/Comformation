using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.SMSChannel
{
    /// <summary>
    /// AWS::Pinpoint::SMSChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smschannel.html
    /// </summary>
    public class SMSChannelResource : ResourceBase
    {
        public class SMSChannelProperties
        {
            /// <summary>
            /// ShortCode
            /// The registered short code that you want to use when you send messages through the SMS channel.
            /// Note For information about obtaining a dedicated short code for sending SMS messages, see Requesting
            /// Dedicated Short Codes for SMS Messaging in the Amazon Pinpoint User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ShortCode { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether to enable the SMS channel for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier for the application that the SMS channel applies to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// SenderId
            /// The identity that you want to display on recipients&#39; devices when they receive messages from the SMS
            /// channel.
            /// Note SenderIDs are only supported in certain countries and regions. For more information, see
            /// Supported Countries and Regions in the Amazon Pinpoint User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SenderId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::SMSChannel";

        public SMSChannelProperties Properties { get; } = new SMSChannelProperties();

    }
}
