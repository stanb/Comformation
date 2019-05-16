using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy RetainRule
    /// Specifies the number of snapshots to keep for each EBS volume.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retainrule.html
    /// </summary>
    public class RetainRule
    {

        /// <summary>
        /// Count
        /// The number of snapshots to keep for each volume, up to a maximum of 1000.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<int, IntrinsicFunction> Count { get; set; }

    }
}
