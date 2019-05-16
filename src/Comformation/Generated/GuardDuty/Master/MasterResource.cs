using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Master
{
    /// <summary>
    /// AWS::GuardDuty::Master
    /// You can use the AWS::GuardDuty::Master resource in a GuardDuty member account to accept an invitation from a
    /// GuardDuty master account. The invitation to the member account must be sent prior to using the
    /// AWS::GuardDuty::Master resource to accept the master account&#39;s invitation. You can invite a member account by
    /// using the InviteMembers operation of the Amazon GuardDuty API, or by creating an AWS::GuardDuty::Member
    /// resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html
    /// </summary>
    public class MasterResource : ResourceBase
    {
        public class MasterProperties
        {
            /// <summary>
            /// DetectorId
            /// The unique ID of the detector associated with the GuardDuty master account.
            /// Required: Yes
            /// Type: String
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
