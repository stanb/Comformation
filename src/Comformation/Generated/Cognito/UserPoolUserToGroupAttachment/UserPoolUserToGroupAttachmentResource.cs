using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolUserToGroupAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolUserToGroupAttachment
    /// The AWS::Cognito::UserPoolUserToGroupAttachment resource attaches a user to an Amazon Cognito user pool user
    /// group.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html
    /// </summary>
    public class UserPoolUserToGroupAttachmentResource : ResourceBase
    {
        public class UserPoolUserToGroupAttachmentProperties
        {
            /// <summary>
            /// GroupName
            /// The name of the group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html#cfn-cognito-userpoolusertogroupattachment-groupname
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// UserPoolId
            /// The ID of the user pool.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html#cfn-cognito-userpoolusertogroupattachment-userpoolid
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// Username
            /// The user's user name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html#cfn-cognito-userpoolusertogroupattachment-username
            /// </summary>
			public Union<string, IntrinsicFunction> Username { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::UserPoolUserToGroupAttachment";
        
        public UserPoolUserToGroupAttachmentProperties Properties { get; } = new UserPoolUserToGroupAttachmentProperties();
    }
}
