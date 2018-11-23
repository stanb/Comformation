using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// Amazon Data Lifecycle Manager LifecyclePolicy Schedule
    /// The Schedule property type specifies a backup schedule for an Amazon Data Lifecycle Manager lifecycle policy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// TagsToAdd
        /// The tags to apply to policy-created resources. These user-defined tags are in addition to the
        /// AWS-added lifecycle tags.
        /// Required: No
        /// Type: List of Resource Tag property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagsToAdd")]
        public List<Tag> TagsToAdd { get; set; }

        /// <summary>
        /// CreateRule
        /// The create rule for a policy.
        /// Required: No
        /// Type: CreateRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreateRule")]
        public CreateRule CreateRule { get; set; }

        /// <summary>
        /// RetainRule
        /// The retention rule for a policy.
        /// Required: No
        /// Type: RetainRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetainRule")]
        public RetainRule RetainRule { get; set; }

        /// <summary>
        /// Name
        /// The name of the schedule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// CopyTags
        /// Copy all user-defined tags on a source volume to snapshots of the volume created by a policy.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CopyTags")]
        public Union<bool, IntrinsicFunction> CopyTags { get; set; }

    }
}
