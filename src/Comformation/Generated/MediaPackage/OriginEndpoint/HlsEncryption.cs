using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint HlsEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsencryption.html
    /// </summary>
    public class HlsEncryption
    {

        /// <summary>
        /// EncryptionMethod
        /// HLS encryption type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionMethod")]
        public Union<string, IntrinsicFunction> EncryptionMethod { get; set; }

        /// <summary>
        /// ConstantInitializationVector
        /// A 128-bit, 16-byte hex value represented by a 32-character string, used with the key for encrypting
        /// blocks.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConstantInitializationVector")]
        public Union<string, IntrinsicFunction> ConstantInitializationVector { get; set; }

        /// <summary>
        /// KeyRotationIntervalSeconds
        /// Number of seconds before AWS Elemental MediaPackage rotates to a new key. By default, rotation is
        /// set to 60 seconds. Set to 0 to disable key rotation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyRotationIntervalSeconds")]
        public Union<int, IntrinsicFunction> KeyRotationIntervalSeconds { get; set; }

        /// <summary>
        /// RepeatExtXKey
        /// Repeat the EXT-X-KEY directive for every media segment. This might result in an increase in client
        /// requests to the DRM server.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepeatExtXKey")]
        public Union<bool, IntrinsicFunction> RepeatExtXKey { get; set; }

        /// <summary>
        /// SpekeKeyProvider
        /// Parameters for the SPEKE key provider.
        /// Required: Yes
        /// Type: SpekeKeyProvider
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpekeKeyProvider")]
        public SpekeKeyProvider SpekeKeyProvider { get; set; }

    }
}
