using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// Amazon Data Lifecycle Manager LifecyclePolicy PolicyDetails
    /// The PolicyDetails property type specifies details for an Amazon Data Lifecycle Manager lifecycle policy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html
    /// </summary>
    public class PolicyDetails
    {

        /// <summary>
        /// ResourceTypes
        /// The type of AWS resource. The supported value is VOLUME.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public List<Union<string, IntrinsicFunction>> ResourceTypes { get; set; }

        /// <summary>
        /// Schedules
        /// The schedule of policy-defined actions.
        /// Required: No
        /// Type: List of Schedule property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedules")]
        public List<Schedule> Schedules { get; set; }

        /// <summary>
        /// TargetTags
        /// The single tag that identifies targeted resources for a policy.
        /// Required: No
        /// Type: List of Resource Tag property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTags")]
        public List<Tag> TargetTags { get; set; }

    }
}
