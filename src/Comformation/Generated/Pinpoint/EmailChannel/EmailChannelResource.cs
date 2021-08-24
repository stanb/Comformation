using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.EmailChannel
{
    /// <summary>
    /// AWS::Pinpoint::EmailChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailchannel.html
    /// </summary>
    public class EmailChannelResource : ResourceBase
    {
        public class EmailChannelProperties
        {
            /// <summary>
            /// ConfigurationSet
            /// The Amazon SES configuration set that you want to apply to messages that you send through the
            /// channel.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ConfigurationSet { get; set; }

            /// <summary>
            /// FromAddress
            /// The verified email address that you want to send email from when you send email through the channel.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FromAddress { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether to enable the email channel for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier for the Amazon Pinpoint application that you&#39;re specifying the email channel
            /// for.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// Identity
            /// The Amazon Resource Name (ARN) of the identity, verified with Amazon Simple Email Service (Amazon
            /// SES), that you want to use when you send email through the channel.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Identity { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of the AWS Identity and Access Management (IAM) role that you want Amazon Pinpoint to use
            /// when it submits email-related event data for the channel.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::EmailChannel";

        public EmailChannelProperties Properties { get; } = new EmailChannelProperties();

    }
}
