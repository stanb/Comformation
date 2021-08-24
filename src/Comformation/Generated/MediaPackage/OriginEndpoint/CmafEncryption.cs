using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint CmafEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafencryption.html
    /// </summary>
    public class CmafEncryption
    {

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
        /// SpekeKeyProvider
        /// Parameters for the SPEKE key provider.
        /// Required: Yes
        /// Type: SpekeKeyProvider
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpekeKeyProvider")]
        public SpekeKeyProvider SpekeKeyProvider { get; set; }

        /// <summary>
        /// ConstantInitializationVector
        /// An optional 128-bit, 16-byte hex value represented by a 32-character string, used in conjunction
        /// with the key for encrypting blocks. If you don&#39;t specify a value, then MediaPackage creates the
        /// constant initialization vector (IV).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConstantInitializationVector")]
        public Union<string, IntrinsicFunction> ConstantInitializationVector { get; set; }

    }
}
