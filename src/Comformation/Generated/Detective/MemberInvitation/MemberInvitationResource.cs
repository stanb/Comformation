using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Detective.MemberInvitation
{
    /// <summary>
    /// AWS::Detective::MemberInvitation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html
    /// </summary>
    public class MemberInvitationResource : ResourceBase
    {
        public class MemberInvitationProperties
        {
            /// <summary>
            /// GraphArn
            /// The ARN of the behavior graph to invite the account to contribute data to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GraphArn { get; set; }

            /// <summary>
            /// MemberId
            /// The AWS account identifier of the invited account
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MemberId { get; set; }

            /// <summary>
            /// MemberEmailAddress
            /// The root user email address of the invited account. If the email address provided is not the root
            /// user email address for the provided account, the invitation creation fails.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MemberEmailAddress { get; set; }

            /// <summary>
            /// Message
            /// Customized text to include in the invitation email message.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Message { get; set; }

        }

        public string Type { get; } = "AWS::Detective::MemberInvitation";

        public MemberInvitationProperties Properties { get; } = new MemberInvitationProperties();

    }
}
