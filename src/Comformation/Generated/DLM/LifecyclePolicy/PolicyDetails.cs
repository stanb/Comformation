using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy PolicyDetails
    /// Specifies the configuration of a lifecycle policy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html
    /// </summary>
    public class PolicyDetails
    {

        /// <summary>
        /// ResourceTypes
        /// The resource type. The supported value is VOLUME.
        /// Required: No
        /// Type: List of String
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public List<Union<string, IntrinsicFunction>> ResourceTypes { get; set; }

        /// <summary>
        /// Schedules
        /// The schedule of policy-defined actions.
        /// Required: No
        /// Type: List of Schedule
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedules")]
        public List<Schedule> Schedules { get; set; }

        /// <summary>
        /// TargetTags
        /// The single tag that identifies targeted resources for this policy.
        /// Required: No
        /// Type: List of Tag
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTags")]
        public List<Tag> TargetTags { get; set; }

    }
}
