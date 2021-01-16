using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.IPSet
{
    /// <summary>
    /// AWS::GuardDuty::IPSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html
    /// </summary>
    public class IPSetResource : ResourceBase
    {
        public class IPSetProperties
        {
            /// <summary>
            /// Format
            /// The format of the file that contains the IPSet.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ALIEN_VAULT | FIRE_EYE | OTX_CSV | PROOF_POINT | STIX | TXT
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Format { get; set; }

            /// <summary>
            /// Activate
            /// Indicates whether or not GuardDuty uses the IPSet.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Activate { get; set; }

            /// <summary>
            /// DetectorId
            /// The unique ID of the detector of the GuardDuty account that you want to create an IPSet for.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// Name
            /// The user-friendly name to identify the IPSet.
            /// Allowed characters are alphanumerics, spaces, hyphens (-), and underscores (_).
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Location
            /// The URI of the file that contains the IPSet.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Location { get; set; }

        }

        public string Type { get; } = "AWS::GuardDuty::IPSet";

        public IPSetProperties Properties { get; } = new IPSetProperties();

    }
}
