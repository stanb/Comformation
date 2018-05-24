using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Detector
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html
    /// </summary>
    public class DetectorResource : ResourceBase
    {
        public class DetectorProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html#cfn-guardduty-detector-enable
            /// </summary>
			public Union<bool, IntrinsicFunction> Enable { get; set; }

        }
    
        public string Type { get; } = "AWS::GuardDuty::Detector";
        
        public DetectorProperties Properties { get; } = new DetectorProperties();
    }
}
