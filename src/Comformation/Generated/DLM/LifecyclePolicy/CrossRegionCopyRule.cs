using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy CrossRegionCopyRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html
    /// </summary>
    public class CrossRegionCopyRule
    {

        /// <summary>
        /// TargetRegion
        /// 		
        /// The target Region.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 16
        /// Pattern: ([a-z]+-){2,3}\d
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetRegion")]
        public Union<string, IntrinsicFunction> TargetRegion { get; set; }

        /// <summary>
        /// Encrypted
        /// 		
        /// To encrypt a copy of an unencrypted snapshot if encryption by default is not enabled, 			enable
        /// encryption using this parameter. Copies of encrypted snapshots are encrypted, 			even if this
        /// parameter is false or if encryption by default is not enabled.
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
        /// The Amazon Resource Name (ARN) of the AWS KMS customer master key (CMK) to use for EBS
        /// 			encryption. If this parameter is not specified, your AWS managed CMK for EBS is 			used.
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

        /// <summary>
        /// RetainRule
        /// 		
        /// The retention rule.
        /// 	
        /// Required: No
        /// Type: CrossRegionCopyRetainRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetainRule")]
        public CrossRegionCopyRetainRule RetainRule { get; set; }

        /// <summary>
        /// CopyTags
        /// 		
        /// Copy all user-defined tags from the source snapshot to the copied snapshot.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CopyTags")]
        public Union<bool, IntrinsicFunction> CopyTags { get; set; }

    }
}
