using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolUserToGroupAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolUserToGroupAttachment
    /// The AWS::Cognito::UserPoolUserToGroupAttachment resource attaches a user to an Amazon Cognito user pool user
    /// group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html
    /// </summary>
    public class UserPoolUserToGroupAttachmentResource : ResourceBase
    {
        public class UserPoolUserToGroupAttachmentProperties
        {
            /// <summary>
            /// GroupName
            /// The group name.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID for the user pool.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 55
            /// Pattern: [\w-]+_[0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// Username
            /// The username for the user.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Username { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolUserToGroupAttachment";

        public UserPoolUserToGroupAttachmentProperties Properties { get; } = new UserPoolUserToGroupAttachmentProperties();

    }
}
