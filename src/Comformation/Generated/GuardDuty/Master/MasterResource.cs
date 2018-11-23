using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Master
{
    /// <summary>
    /// AWS::GuardDuty::Master
    /// You can use the AWS::GuardDuty::Master resource in a GuardDuty member account to accept an invitation to be
    /// managed by a GuardDuty master account. The GuardDuty master account must have already invited the current
    /// account (by calling the InviteMembers API operation or by creating an AWS::GuardDuty::Member resource) before
    /// the current account can use the AWS::GuardDuty::Master resource to accept the master account&#39;s invitation.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html
    /// </summary>
    public class MasterResource : ResourceBase
    {
        public class MasterProperties
        {
            /// <summary>
            /// DetectorId
            /// The detector ID of the AWS account that is accepting an invitation to become a GuardDuty member
            /// account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// MasterId
            /// The account ID of the master GuardDuty account whose invitation you&#39;re accepting.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MasterId { get; set; }

            /// <summary>
            /// InvitationId
            /// The ID of the invitation that is sent to the AWS account by the GuardDuty master account. There are
            /// several ways to retrieve the invitationId:
            /// By calling the ListInvitation API operation with the GuardDuty member account&#39;s credentials. (You
            /// can also run the following CLI command: aws guardduty list-invitations. ) In the returned results,
            /// locate the invitation details (including the invitationID) from the GuardDuty master account ID that
            /// you would like to accept. The email account associated with the GuardDuty member account should have
            /// received an invitation email from the master account when they invited the current account. This
            /// email contains an acceptance link which has the invitationId. If you access the member account’s
            /// Personal Health Dashboard, you can also see the same invitation email from the master account (with
            /// the invitationId included as part of the invitation acceptance link). If the value for InvitationId
            /// is not specified, it can be retrieved by calling ListInvitations and receiving the invitation from
            /// the given master account ID.
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
