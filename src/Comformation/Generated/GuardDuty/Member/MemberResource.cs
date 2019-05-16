using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Member
{
    /// <summary>
    /// AWS::GuardDuty::Member
    /// You can use the AWS::GuardDuty::Member resource to add an AWS account as a GuardDuty member account to the
    /// current GuardDuty master account. If the value of the Status property is not provided or is set to Created, a
    /// member account is created but not invited. If the value of the Status property is set to Invited, a member
    /// account is created and invited. A AWS::GuardDuty::Member resource must be created with the Status property set
    /// to Invited before the AWS::GuardDuty::Master resource can be created in a GuardDuty member account.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html
    /// </summary>
    public class MemberResource : ResourceBase
    {
        public class MemberProperties
        {
            /// <summary>
            /// Status
            /// You can use the Status property to update the status of the relationship between the member account
            /// and its master account. Valid values are Created and Invited when using a AWS::GuardDuty::Member
            /// resource. If the value for this property is not provided or set to Created, a member account is
            /// created but not invited. If the value of this property is set to Invited, a member account is
            /// created and invited.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// MemberId
            /// The AWS account ID of the account to designate as a member.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MemberId { get; set; }

            /// <summary>
            /// Email
            /// The email address associated with the member account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Email { get; set; }

            /// <summary>
            /// Message
            /// The message to include with the invitation sent to the member accounts.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Message { get; set; }

            /// <summary>
            /// DisableEmailNotification
            /// Specifies whether or not to disable email notification for the member account that you invite.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DisableEmailNotification { get; set; }

            /// <summary>
            /// DetectorId
            /// The ID of the detector associated with the GuardDuty service to add the member to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorId { get; set; }

        }

        public string Type { get; } = "AWS::GuardDuty::Member";

        public MemberProperties Properties { get; } = new MemberProperties();

    }
}
