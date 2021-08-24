using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy CrossRegionCopyAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyaction.html
    /// </summary>
    public class CrossRegionCopyAction
    {

        /// <summary>
        /// Target
        /// 		
        /// The target Region.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 2048
        /// Pattern: ^[\w:\-\/\*]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        /// EncryptionConfiguration
        /// 		
        /// The encryption settings for the copied snapshot.
        /// 	
        /// Required: Yes
        /// Type: EncryptionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionConfiguration")]
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// RetainRule
        /// 		
        /// Specifies the retention rule for cross-Region snapshot copies.
        /// 	
        /// Required: No
        /// Type: CrossRegionCopyRetainRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetainRule")]
        public CrossRegionCopyRetainRule RetainRule { get; set; }

    }
}
