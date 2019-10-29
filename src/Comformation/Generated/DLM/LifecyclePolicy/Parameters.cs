using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy Parameters
    /// Optional parameters that can be added to the policy. The set of valid parameters depends on the combination of
    /// policyType and resourceType values.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-parameters.html
    /// </summary>
    public class Parameters
    {

        /// <summary>
        /// ExcludeBootVolume
        /// When executing an EBS Snapshot Management – Instance policy, execute all CreateSnapshots calls with
        /// the excludeBootVolume set to the supplied field. Defaults to false. Only valid for EBS Snapshot
        /// Management – Instance policies.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeBootVolume")]
        public Union<bool, IntrinsicFunction> ExcludeBootVolume { get; set; }

    }
}
