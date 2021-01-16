using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy ShareRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-sharerule.html
    /// </summary>
    public class ShareRule
    {

        /// <summary>
        /// TargetAccounts
        /// 		
        /// The IDs of the AWS accounts with which to share the snapshots.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetAccounts")]
        public List<Union<string, IntrinsicFunction>> TargetAccounts { get; set; }

        /// <summary>
        /// UnshareIntervalUnit
        /// 		
        /// The unit of time for the automatic unsharing interval.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DAYS | MONTHS | WEEKS | YEARS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnshareIntervalUnit")]
        public Union<string, IntrinsicFunction> UnshareIntervalUnit { get; set; }

        /// <summary>
        /// UnshareInterval
        /// 		
        /// The period after which snapshots that are shared with other AWS accounts are automatically unshared.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnshareInterval")]
        public Union<int, IntrinsicFunction> UnshareInterval { get; set; }

    }
}
