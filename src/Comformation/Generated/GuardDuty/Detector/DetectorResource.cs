using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Detector
{
    /// <summary>
    /// AWS::GuardDuty::Detector
    /// The AWS::GuardDuty::Detector resource specifies a new Amazon GuardDuty detector. A detector is an object that
    /// represents the Amazon GuardDuty service. A detector is required for Amazon GuardDuty to become operational.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html
    /// </summary>
    public class DetectorResource : ResourceBase
    {
        public class DetectorProperties
        {
            /// <summary>
            /// FindingPublishingFrequency
            /// A enumeration value that specifies how frequently finding updates are published.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> FindingPublishingFrequency { get; set; }

            /// <summary>
            /// Enable
            /// Specifies whether or not to enable the detector.
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
