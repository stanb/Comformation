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
        /// The resource type.
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
        /// PolicyType
        /// This field determines the valid target resource types and actions a policy can manage. This field
        /// defaults to EBS_SNAPSHOT_MANAGEMENT if not present.
        /// Required: No
        /// Type: String
        /// Allowed Values: EBS_SNAPSHOT_MANAGEMENT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyType")]
        public Union<string, IntrinsicFunction> PolicyType { get; set; }

        /// <summary>
        /// Parameters
        /// A set of optional parameters that can be provided by the policy.
        /// Required: No
        /// Type: Parameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Parameters Parameters { get; set; }

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
