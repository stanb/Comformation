using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Detector
{
    /// <summary>
    /// AWS::GuardDuty::Detector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-detector.html
    /// </summary>
    public class DetectorResource : ResourceBase
    {
        public class DetectorProperties
        {
            /// <summary>
            /// FindingPublishingFrequency
            /// Specifies how frequently updated findings are exported.
            /// Required: No
            /// Type: String
            /// Allowed values: FIFTEEN_MINUTES | ONE_HOUR | SIX_HOURS
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FindingPublishingFrequency { get; set; }

            /// <summary>
            /// DataSources
            /// Describes which data sources will be enabled for the detector.
            /// Required: No
            /// Type: CFNDataSourceConfigurations
            /// Update requires: No interruption
            /// </summary>
            public CFNDataSourceConfigurations DataSources { get; set; }

            /// <summary>
            /// Enable
            /// Specifies whether the detector is to be enabled on creation.
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
