using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// Amazon Data Lifecycle Manager LifecyclePolicy RetainRule
    /// The RetainRule property type specifies a snapshot retention rule for an Amazon Data Lifecycle Manager
    /// lifecycle policy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retainrule.html
    /// </summary>
    public class RetainRule
    {

        /// <summary>
        /// Count
        /// The number of snapshots to keep for each volume, up to a maximum of 1000.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<int, IntrinsicFunction> Count { get; set; }

    }
}
