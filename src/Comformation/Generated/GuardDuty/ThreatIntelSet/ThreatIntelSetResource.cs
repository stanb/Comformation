using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.ThreatIntelSet
{
    /// <summary>
    /// AWS::GuardDuty::ThreatIntelSet
    /// The AWS::GuardDuty::ThreatIntelSet resource creates a ThreatIntelSet. A ThreatIntelSet consists of known
    /// malicious IP addresses. GuardDuty generates findings based on ThreatIntelSets.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-threatintelset.html
    /// </summary>
    public class ThreatIntelSetResource : ResourceBase
    {
        public class ThreatIntelSetProperties
        {
            /// <summary>
            /// Format
            /// The format of the file that contains the ThreatIntelSet. Valid values are TXT, STIX, OTX_CSV,
            /// ALIEN_VAULT, PROOF_POINT, and FIRE_EYE.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Format { get; set; }

            /// <summary>
            /// Activate
            /// A Boolean value that indicates whether GuardDuty should start using the uploaded ThreatIntelSet.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Activate { get; set; }

            /// <summary>
            /// DetectorId
            /// The detector ID that specifies the GuardDuty service for which an ThreatIntelSet is to be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// Name
            /// A friendly ThreatIntelSet name that is displayed in all findings generated by activity that involves
            /// IP addresses included in this ThreatIntelSet.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Location
            /// The URI of the file that contains the ThreatIntelSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Location { get; set; }

        }
    
        public string Type { get; } = "AWS::GuardDuty::ThreatIntelSet";
        
        public ThreatIntelSetProperties Properties { get; } = new ThreatIntelSetProperties();
    }
}
