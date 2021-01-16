using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration HlsEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsencryption.html
    /// </summary>
    public class HlsEncryption
    {

        /// <summary>
        /// ConstantInitializationVector
        /// A 128-bit, 16-byte hex value represented by a 32-character string, used with the key for encrypting
        /// blocks. If you don&#39;t specify a constant initialization vector (IV), MediaPackage periodically
        /// rotates the IV.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConstantInitializationVector")]
        public Union<string, IntrinsicFunction> ConstantInitializationVector { get; set; }

        /// <summary>
        /// EncryptionMethod
        /// HLS encryption type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionMethod")]
        public Union<string, IntrinsicFunction> EncryptionMethod { get; set; }

    }
}
