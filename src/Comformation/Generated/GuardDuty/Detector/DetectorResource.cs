using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Detector
{
    /// <summary>
    /// AWS::GuardDuty::Detector
    /// The AWS::GuardDuty::Detector resource creates a single Amazon GuardDuty detector. A detector is an object that
    /// represents the GuardDuty service. You must create a detector for GuardDuty to become operational.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html
    /// </summary>
    public class DetectorResource : ResourceBase
    {
        public class DetectorProperties
        {
            /// <summary>
            /// Enable
            /// A Boolean value that specifies whether the detector is to be enabled.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-enable
            /// </summary>
			public Union<bool, IntrinsicFunction> Enable { get; set; }

        }
    
        public string Type { get; } = "AWS::GuardDuty::Detector";
        
        public DetectorProperties Properties { get; } = new DetectorProperties();
    }
}
