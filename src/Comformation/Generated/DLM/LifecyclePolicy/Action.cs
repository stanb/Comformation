using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// CrossRegionCopy
        /// 		
        /// The rule for copying shared snapshots across Regions.
        /// 	
        /// Required: Yes
        /// Type: List of CrossRegionCopyAction
        /// Maximum: 3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrossRegionCopy")]
        public List<CrossRegionCopyAction> CrossRegionCopy { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// A descriptive name for the action.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 120
        /// Pattern: [0-9A-Za-z _-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
