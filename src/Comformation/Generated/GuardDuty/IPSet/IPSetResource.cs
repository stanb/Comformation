using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.IPSet
{
    /// <summary>
    /// AWS::GuardDuty::IPSet
    /// The AWS::GuardDuty::IPSet resource creates an Amazon GuardDuty IP set. An IP set is a list of trusted IP
    /// addresses that have been whitelisted for secure communication with your AWS environment.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-ipset.html
    /// </summary>
    public class IPSetResource : ResourceBase
    {
        public class IPSetProperties
        {
            /// <summary>
            /// Format
            /// The format of the file that contains the IP set. Valid values are TXT, STIX, and OTX_CSV.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Format { get; set; }

            /// <summary>
            /// Activate
            /// A Boolean value that indicates whether GuardDuty is to start using the uploaded IP set.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Activate { get; set; }

            /// <summary>
            /// DetectorId
            /// The detector ID that specifies the GuardDuty service for which an IP set is to be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// Name
            /// The friendly name to identify the IP set. This name is displayed in all findings that are triggered
            /// by activity that involves IP addresses included in this IP set.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Location
            /// The URI of the file that contains the IP set.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Location { get; set; }

        }
    
        public string Type { get; } = "AWS::GuardDuty::IPSet";
        
        public IPSetProperties Properties { get; } = new IPSetProperties();

    }
}
