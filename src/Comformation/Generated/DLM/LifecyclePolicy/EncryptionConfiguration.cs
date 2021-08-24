using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy EncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// Encrypted
        /// 		
        /// To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled, enable
        /// 			encryption using this parameter. Copies of encrypted snapshots are encrypted, even if this
        /// 			parameter is false or when encryption by default is not enabled.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// CmkArn
        /// 		
        /// The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If 			this parameter is
        /// not specified, the default KMS key for the account is used.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 2048
        /// Pattern: arn:aws(-[a-z]{1,3}){0,2}:kms:([a-z]+-){2,3}\d:\d+:key/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CmkArn")]
        public Union<string, IntrinsicFunction> CmkArn { get; set; }

    }
}
