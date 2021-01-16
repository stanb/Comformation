using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy EventParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-eventparameters.html
    /// </summary>
    public class EventParameters
    {

        /// <summary>
        /// EventType
        /// 		
        /// The type of event. Currently, only snapshot sharing events are supported.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: shareSnapshot
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventType")]
        public Union<string, IntrinsicFunction> EventType { get; set; }

        /// <summary>
        /// SnapshotOwner
        /// 		
        /// The IDs of the AWS accounts that can trigger policy by sharing snapshots with your account. The
        /// 			policy only runs if one of the specified AWS accounts shares a snapshot with your account.
        /// 	
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnapshotOwner")]
        public List<Union<string, IntrinsicFunction>> SnapshotOwner { get; set; }

        /// <summary>
        /// DescriptionRegex
        /// 		
        /// The snapshot description that can trigger the policy. The description pattern is specified using
        /// 			a regular expression. The policy runs only if a snapshot with a description that matches the
        /// 			specified pattern is shared with your account.
        /// 		
        /// For example, specifying ^. *Created for policy: policy-1234567890abcdef0. *$ 			configures the
        /// policy to run only if snapshots created by policy policy-1234567890abcdef0 			are shared with your
        /// account.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1000
        /// Pattern: [\p{all}]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DescriptionRegex")]
        public Union<string, IntrinsicFunction> DescriptionRegex { get; set; }

    }
}
