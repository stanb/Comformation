using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy PolicyDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html
    /// </summary>
    public class PolicyDetails
    {

        /// <summary>
        /// ResourceTypes
        /// 		
        /// The target resource type for snapshot and AMI lifecycle policies. Use VOLUME to 			create snapshots
        /// of individual volumes or use INSTANCE to create multi-volume 			snapshots from the volumes for an
        /// instance.
        /// 		
        /// This parameter is required for snapshot and AMI policies only. If you are creating an event-based
        /// policy, omit this parameter.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public List<Union<string, IntrinsicFunction>> ResourceTypes { get; set; }

        /// <summary>
        /// Schedules
        /// 		
        /// The schedules of policy-defined actions for snapshot and AMI lifecycle policies. A policy 			can
        /// have up to four schedules—one mandatory schedule and up to three optional schedules.
        /// 		
        /// This parameter is required for snapshot and AMI policies only. If you are creating an event-based
        /// policy, omit this parameter.
        /// 	
        /// Required: No
        /// Type: List of Schedule
        /// Maximum: 4
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedules")]
        public List<Schedule> Schedules { get; set; }

        /// <summary>
        /// PolicyType
        /// 		
        /// The valid target resource types and actions a policy can manage. Specify EBS_SNAPSHOT_MANAGEMENT
        /// 			to create a lifecycle policy that manages the lifecycle of Amazon EBS snapshots. Specify
        /// IMAGE_MANAGEMENT 			to create a lifecycle policy that manages the lifecycle of EBS-backed AMIs.
        /// Specify EVENT_BASED_POLICY 			to create an event-based policy that performs specific actions when a
        /// defined event occurs in your AWS account.
        /// 		
        /// The default is EBS_SNAPSHOT_MANAGEMENT.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: EBS_SNAPSHOT_MANAGEMENT | EVENT_BASED_POLICY | IMAGE_MANAGEMENT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyType")]
        public Union<string, IntrinsicFunction> PolicyType { get; set; }

        /// <summary>
        /// EventSource
        /// 		
        /// The event that triggers the event-based policy.
        /// 		
        /// This parameter is required for event-based policies only. If you are creating a snapshot or AMI
        /// policy, omit this parameter.
        /// 	
        /// Required: No
        /// Type: EventSource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventSource")]
        public EventSource EventSource { get; set; }

        /// <summary>
        /// Parameters
        /// 		
        /// A set of optional parameters for snapshot and AMI lifecycle policies.
        /// 		
        /// This parameter is required for snapshot and AMI policies only. If you are creating an event-based
        /// policy, omit this parameter.
        /// 	
        /// Required: No
        /// Type: Parameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Actions
        /// 		
        /// The actions to be performed when the event-based policy is triggered. You can specify 		only one
        /// action per policy.
        /// 		
        /// This parameter is required for event-based policies only. If you are creating a snapshot or AMI
        /// policy, omit this parameter.
        /// 	
        /// Required: No
        /// Type: List of Action
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// TargetTags
        /// 		
        /// The single tag that identifies targeted resources for this policy.
        /// 		
        /// This parameter is required for snapshot and AMI policies only. If you are creating an event-based
        /// policy, omit this parameter.
        /// 	
        /// Required: No
        /// Type: List of Tag
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTags")]
        public List<Tag> TargetTags { get; set; }

    }
}
