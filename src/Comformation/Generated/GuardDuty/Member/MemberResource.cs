using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Member
{
    /// <summary>
    /// AWS::GuardDuty::Member
    /// You can use the AWS::GuardDuty::Member resource to add an AWS account as a GuardDuty member account to the
    /// current GuardDuty master account. If the value of the Status property is not provided or is set to Created, a
    /// member account is only created. If the value of the Status property is set to Invited, a member account is
    /// created and invited. AWS::GuardDuty::Member resource has to be created with the Status property set to Invited
    /// before the AWS::GuardDuty::Master resource can be created in a GuardDuty member account.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html
    /// </summary>
    public class MemberResource : ResourceBase
    {
        public class MemberProperties
        {
            /// <summary>
            /// Status
            /// You can use this property to update the status of the relationship between the member account and
            /// its master account. Valid values are Created | Invited | Disabled | Enabled | Removed | Resigned. If
            /// the value for this property is not provided or set to Created, a member account is only created. If
            /// the value of this property is set to Invited, a member account is created and invited.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// MemberId
            /// The account ID of the member GuardDuty account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MemberId { get; set; }

            /// <summary>
            /// Email
            /// The email address of the GuardDuty member account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Email { get; set; }

            /// <summary>
            /// Message
            /// The invitation message that you want to send to the account that you invite to GuardDuty as a
            /// member.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Message { get; set; }

            /// <summary>
            /// DisableEmailNotification
            /// Specifies whether an email notification is sent to the accounts that you want to invite to GuardDuty
            /// as members. When set to &#39;True&#39;, email notification is not sent to the invitees.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DisableEmailNotification { get; set; }

            /// <summary>
            /// DetectorId
            /// The unique ID of the detector in a GuardDuty master account.
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
