using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.APNSVoipChannel
{
    /// <summary>
    /// AWS::Pinpoint::APNSVoipChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html
    /// </summary>
    public class APNSVoipChannelResource : ResourceBase
    {
        public class APNSVoipChannelProperties
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
            /// Specifies whether to enable the APNs VoIP channel for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// DefaultAuthenticationMethod
            /// The default authentication method that you want Amazon Pinpoint to use when authenticating with
            /// APNs, key or certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultAuthenticationMethod { get; set; }

            /// <summary>
            /// TokenKey
            /// The key identifier that&#39;s assigned to your APNs signing key, if you want Amazon Pinpoint to
            /// communicate with APNs by using APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TokenKey { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier for the application that the APNs VoIP channel applies to.
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
            /// with APNs by using an APNs certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Certificate { get; set; }

            /// <summary>
            /// TokenKeyId
            /// The key identifier that&#39;s assigned to your APNs signing key, if you want Amazon Pinpoint to
            /// communicate with APNs by using APNs tokens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TokenKeyId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::APNSVoipChannel";

        public APNSVoipChannelProperties Properties { get; } = new APNSVoipChannelProperties();

    }
}
