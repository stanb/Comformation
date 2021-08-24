using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.MLTransform
{
    /// <summary>
    /// AWS::Glue::MLTransform MLUserDataEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformencryption-mluserdataencryption.html
    /// </summary>
    public class MLUserDataEncryption
    {

        /// <summary>
        /// MLUserDataEncryptionMode
        /// 	
        /// The encryption mode applied to user data. Valid values are:
        /// 	
        /// 	 		 	 DISABLED: encryption is disabled. SSEKMS: use of server-side encryption with AWS Key
        /// Management Service (SSE-KMS) for user data stored in Amazon S3.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MLUserDataEncryptionMode")]
        public Union<string, IntrinsicFunction> MLUserDataEncryptionMode { get; set; }

        /// <summary>
        /// KmsKeyId
        /// 	
        /// The ID for the customer-provided KMS key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

    }
}
