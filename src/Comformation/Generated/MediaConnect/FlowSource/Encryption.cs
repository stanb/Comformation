using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.FlowSource
{
    /// <summary>
    /// AWS::MediaConnect::FlowSource Encryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html
    /// </summary>
    public class Encryption
    {

        /// <summary>
        /// Algorithm
        /// The type of algorithm that is used for the encryption (such as aes128, aes192, or aes256).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Algorithm")]
        public Union<string, IntrinsicFunction> Algorithm { get; set; }

        /// <summary>
        /// ConstantInitializationVector
        /// A 128-bit, 16-byte hex value represented by a 32-character string, to be used with the key for
        /// encrypting content. This parameter is not valid for static key encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConstantInitializationVector")]
        public Union<string, IntrinsicFunction> ConstantInitializationVector { get; set; }

        /// <summary>
        /// DeviceId
        /// The value of one of the devices that you configured with your digital rights management (DRM)
        /// platform key provider. This parameter is required for SPEKE encryption and is not valid for static
        /// key encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceId")]
        public Union<string, IntrinsicFunction> DeviceId { get; set; }

        /// <summary>
        /// KeyType
        /// The type of key that is used for the encryption. If you don&#39;t specify a keyType value, the service
        /// uses the default setting (static-key).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyType")]
        public Union<string, IntrinsicFunction> KeyType { get; set; }

        /// <summary>
        /// Region
        /// The AWS Region that the API Gateway proxy endpoint was created in. This parameter is required for
        /// SPEKE encryption and is not valid for static key encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// ResourceId
        /// An identifier for the content. The service sends this value to the key server to identify the
        /// current endpoint. The resource ID is also known as the content ID. This parameter is required for
        /// SPEKE encryption and is not valid for static key encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceId")]
        public Union<string, IntrinsicFunction> ResourceId { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the role that you created during setup (when you set up
        /// MediaConnect as a trusted entity).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// SecretArn
        /// The ARN of the secret that you created in AWS Secrets Manager to store the encryption key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

        /// <summary>
        /// Url
        /// The URL from the API Gateway proxy that you set up to talk to your key server. This parameter is
        /// required for SPEKE encryption and is not valid for static key encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
