using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.APNSSandboxChannel
{
    /// <summary>
    /// AWS::Pinpoint::APNSSandboxChannel
    /// A channel is a type of platform that you can deliver messages to. You can use the APNs sandbox channel to send
    /// push notification messages to the sandbox environment of the Apple Push Notification service (APNs). Before
    /// you use Amazon Pinpoint to send notifications to the APNs sandbox environment, you have to enable the APNs
    /// sandbox channel for an Amazon Pinpoint app.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnssandboxchannel.html
    /// </summary>
    public class APNSSandboxChannelResource : ResourceBase
    {
        public class APNSSandboxChannelProperties
        {
            /// <summary>
            /// BundleId
            /// The bundle identifier that&#39;s assigned to your iOS app. This identifier is used for APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> BundleId { get; set; }

            /// <summary>
            /// PrivateKey
            /// The private key for the APNs client certificate that you want Amazon Pinpoint to use to communicate
            /// with APNs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PrivateKey { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether to enable the APNs Sandbox channel for the Amazon Pinpoint application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// DefaultAuthenticationMethod
            /// The default authentication method that you want Amazon Pinpoint to use when authenticating with
            /// APNs. Valid options are key or certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultAuthenticationMethod { get; set; }

            /// <summary>
            /// TokenKey
            /// The authentication key to use for APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TokenKey { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier of the Amazon Pinpoint application that the APNs sandbox channel applies to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// TeamId
            /// The identifier that&#39;s assigned to your Apple Developer Account team. This identifier is used for
            /// APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TeamId { get; set; }

            /// <summary>
            /// Certificate
            /// The APNs client certificate that you received from Apple. Specify this value if you want Amazon
            /// Pinpoint to communicate with APNs by using an APNs certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Certificate { get; set; }

            /// <summary>
            /// TokenKeyId
            /// The key identifier that&#39;s assigned to your APNs signing key. Specify this value if you want Amazon
            /// Pinpoint to communicate with APNs by using APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TokenKeyId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::APNSSandboxChannel";

        public APNSSandboxChannelProperties Properties { get; } = new APNSSandboxChannelProperties();

    }
}
