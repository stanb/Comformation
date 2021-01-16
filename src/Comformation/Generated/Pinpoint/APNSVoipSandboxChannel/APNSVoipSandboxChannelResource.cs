using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.APNSVoipSandboxChannel
{
    /// <summary>
    /// AWS::Pinpoint::APNSVoipSandboxChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html
    /// </summary>
    public class APNSVoipSandboxChannelResource : ResourceBase
    {
        public class APNSVoipSandboxChannelProperties
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
            /// with the APNs sandbox environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PrivateKey { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether the APNs VoIP sandbox channel is enabled for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// DefaultAuthenticationMethod
            /// The default authentication method that you want Amazon Pinpoint to use when authenticating with the
            /// APNs sandbox environment for this channel, key or certificate.
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
            /// The unique identifier for the application that the APNs VoIP sandbox channel applies to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// TeamId
            /// The identifier that&#39;s assigned to your Apple developer account team. This identifier is used for
            /// APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TeamId { get; set; }

            /// <summary>
            /// Certificate
            /// The APNs client certificate that you received from Apple, if you want Amazon Pinpoint to communicate
            /// with the APNs sandbox environment by using an APNs certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Certificate { get; set; }

            /// <summary>
            /// TokenKeyId
            /// The key identifier that&#39;s assigned to your APNs signing key, if you want Amazon Pinpoint to
            /// communicate with the APNs sandbox environment by using APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TokenKeyId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::APNSVoipSandboxChannel";

        public APNSVoipSandboxChannelProperties Properties { get; } = new APNSVoipSandboxChannelProperties();

    }
}
