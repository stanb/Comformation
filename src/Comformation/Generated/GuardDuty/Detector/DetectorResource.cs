using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Detector
{
    /// <summary>
    /// AWS::GuardDuty::Detector
    /// The AWS::GuardDuty::Detector resource creates a single Amazon GuardDuty detector. A detector is an object that
    /// represents the GuardDuty service. You must create a detector for GuardDuty to become operational.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html
    /// </summary>
    public class DetectorResource : ResourceBase
    {
        public class DetectorProperties
        {
            /// <summary>
            /// FindingPublishingFrequency
            /// Specifies the frequency of notifications sent about the subsequent finding occurrences. Valid values
            /// include only the following: FIFTEEN_MINUTES, ONE_HOUR, SIX_HOURS.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> FindingPublishingFrequency { get; set; }

            /// <summary>
            /// Enable
            /// A Boolean value that specifies whether the detector is to be enabled.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enable { get; set; }

        }
    
        public string Type { get; } = "AWS::GuardDuty::Detector";
        
        public DetectorProperties Properties { get; } = new DetectorProperties();

    }
}
