using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IVS.PlaybackKeyPair
{
    /// <summary>
    /// AWS::IVS::PlaybackKeyPair
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-playbackkeypair.html
    /// </summary>
    public class PlaybackKeyPairResource : ResourceBase
    {
        public class PlaybackKeyPairProperties
        {
            /// <summary>
            /// Name
            /// An arbitrary string (a nickname) assigned to a playback key pair that helps the customer identify
            /// that resource. The value does not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9-_]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// PublicKeyMaterial
            /// The public portion of a customer-generated key pair.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PublicKeyMaterial { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IVS::PlaybackKeyPair";

        public PlaybackKeyPairProperties Properties { get; } = new PlaybackKeyPairProperties();

    }

    public static class PlaybackKeyPairAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Fingerprint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Fingerprint");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
