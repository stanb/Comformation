using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.FlowOutput
{
    /// <summary>
    /// AWS::MediaConnect::FlowOutput Encryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-encryption.html
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
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

    }
}
