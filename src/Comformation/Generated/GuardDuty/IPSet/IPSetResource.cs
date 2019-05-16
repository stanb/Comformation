using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.IPSet
{
    /// <summary>
    /// AWS::GuardDuty::IPSet
    /// The AWS::GuardDuty::IPSet resource specifies a new IPSet. An IPSet is a list of trusted IP addresses from
    /// which secure communication is allowed with AWS infrastructure and applications.
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
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Format { get; set; }

            /// <summary>
            /// Activate
            /// Indicated whether or not GuardDuty uses the IPSet.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Activate { get; set; }

            /// <summary>
            /// DetectorId
            /// The unique ID of the detector for the GuardDuty service to associate the IPSet with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// Name
            /// The name for the IPSet. This name is displayed in all findings that are triggered by activity
            /// associated with the IP addresses included in this IPSet.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Location
            /// The URI of the file that contains the IPSet.
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
