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
        /// Avoid using this parameter when creating new policies. Instead, use Target 			to specify a target
        /// Region or a target Outpost for snapshot copies.
        /// 		
        /// For policies created before the Target parameter 			was introduced, this parameter indicates the
        /// target Region for snapshot copies.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 16
        /// Pattern: ([a-z]+-){2,3}\d
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetRegion")]
        public Union<string, IntrinsicFunction> TargetRegion { get; set; }

        /// <summary>
        /// Target
        /// 		
        /// The target Region or the Amazon Resource Name (ARN) of the target Outpost for the 			snapshot
        /// copies.
        /// 		
        /// Use this parameter instead of TargetRegion. Do not 			specify both.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 2048
        /// Pattern: ^[\w:\-\/\*]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        /// DeprecateRule
        /// 		
        /// The AMI deprecation rule for cross-Region AMI copies created by the rule.
        /// 	
        /// Required: No
        /// Type: CrossRegionCopyDeprecateRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeprecateRule")]
        public CrossRegionCopyDeprecateRule DeprecateRule { get; set; }

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
        /// The Amazon Resource Name (ARN) of the AWS KMS key to use for EBS encryption. If this 			parameter is
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

        /// <summary>
        /// RetainRule
        /// 		
        /// The retention rule that indicates how long snapshot copies are to be retained in the 			destination
        /// Region.
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
        /// Indicates whether to copy all user-defined tags from the source snapshot to the cross-Region
        /// 			snapshot copy.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CopyTags")]
        public Union<bool, IntrinsicFunction> CopyTags { get; set; }

    }
}
