using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Master
{
    /// <summary>
    /// AWS::GuardDuty::Master
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html
    /// </summary>
    public class MasterResource : ResourceBase
    {
        public class MasterProperties
        {
            /// <summary>
            /// DetectorId
            /// The unique ID of the detector of the GuardDuty member account.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// MasterId
            /// The AWS account ID of the account designated as the GuardDuty master account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MasterId { get; set; }

            /// <summary>
            /// InvitationId
            /// The ID of the invitation that is sent to the account designated as a member account. You can find
            /// the invitation ID by using the ListInvitation action of the GuardDuty API.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InvitationId { get; set; }

        }

        public string Type { get; } = "AWS::GuardDuty::Master";

        public MasterProperties Properties { get; } = new MasterProperties();

    }
}
