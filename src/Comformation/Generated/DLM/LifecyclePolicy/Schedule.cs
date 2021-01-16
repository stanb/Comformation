using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy Schedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// ShareRules
        /// 		
        /// The rule for sharing snapshots with other AWS accounts.
        /// 	
        /// Required: No
        /// Type: List of ShareRule
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ShareRules")]
        public List<ShareRule> ShareRules { get; set; }

        /// <summary>
        /// TagsToAdd
        /// 		
        /// The tags to apply to policy-created resources. These user-defined tags are in addition 			to the
        /// AWS-added lifecycle tags.
        /// 	
        /// Required: No
        /// Type: List of Tag
        /// Maximum: 45
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagsToAdd")]
        public List<Tag> TagsToAdd { get; set; }

        /// <summary>
        /// CreateRule
        /// 		
        /// The creation rule.
        /// 	
        /// Required: No
        /// Type: CreateRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreateRule")]
        public CreateRule CreateRule { get; set; }

        /// <summary>
        /// VariableTags
        /// 		
        /// A collection of key/value pairs with values determined dynamically when the policy is 			executed.
        /// Keys may be any valid Amazon EC2 tag key. Values must be in one of the two 			following formats:
        /// $(instance-id) or $(timestamp). Variable 			tags are only valid for EBS Snapshot Management –
        /// Instance policies.
        /// 	
        /// Required: No
        /// Type: List of Tag
        /// Maximum: 45
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VariableTags")]
        public List<Tag> VariableTags { get; set; }

        /// <summary>
        /// FastRestoreRule
        /// 		
        /// The rule for enabling fast snapshot restore.
        /// 	
        /// Required: No
        /// Type: FastRestoreRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FastRestoreRule")]
        public FastRestoreRule FastRestoreRule { get; set; }

        /// <summary>
        /// RetainRule
        /// 		
        /// The retention rule.
        /// 	
        /// Required: No
        /// Type: RetainRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetainRule")]
        public RetainRule RetainRule { get; set; }

        /// <summary>
        /// CrossRegionCopyRules
        /// 		
        /// The rule for cross-Region snapshot copies.
        /// 	
        /// Required: No
        /// Type: List of CrossRegionCopyRule
        /// Maximum: 3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrossRegionCopyRules")]
        public List<CrossRegionCopyRule> CrossRegionCopyRules { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// The name of the schedule.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 120
        /// Pattern: [0-9A-Za-z _-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// CopyTags
        /// 		
        /// Copy all user-defined tags on a source volume to snapshots of the volume created by 			this policy.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CopyTags")]
        public Union<bool, IntrinsicFunction> CopyTags { get; set; }

    }
}
