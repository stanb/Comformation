using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy Parameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-parameters.html
    /// </summary>
    public class Parameters
    {

        /// <summary>
        /// ExcludeBootVolume
        /// 		
        /// [EBS Snapshot Management – Instance policies only] Indicates whether to exclude the 			root volume
        /// from snapshots created using CreateSnapshots. 			The default is false.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeBootVolume")]
        public Union<bool, IntrinsicFunction> ExcludeBootVolume { get; set; }

        /// <summary>
        /// NoReboot
        /// 		
        /// Applies to AMI lifecycle policies only. Indicates whether targeted instances are rebooted when the
        /// lifecycle 			policy runs. true indicates that targeted instances are not rebooted when the policy
        /// 			runs. false indicates that target instances are rebooted when the policy runs. The 			default is
        /// true (instances are not rebooted).
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoReboot")]
        public Union<bool, IntrinsicFunction> NoReboot { get; set; }

    }
}
