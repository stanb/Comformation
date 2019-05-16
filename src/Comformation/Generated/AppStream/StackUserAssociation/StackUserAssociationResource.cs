using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.StackUserAssociation
{
    /// <summary>
    /// AWS::AppStream::StackUserAssociation
    /// The AWS::AppStream::StackUserAssociation resource associates the specified users with the specified stacks for
    /// Amazon AppStream 2. 0. Users in an AppStream 2. 0 user pool cannot be assigned to stacks with fleets that are
    /// joined to an Active Directory domain.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackuserassociation.html
    /// </summary>
    public class StackUserAssociationResource : ResourceBase
    {
        public class StackUserAssociationProperties
        {
            /// <summary>
            /// SendEmailNotification
            /// Specifies whether a welcome email is sent to a user after the user is created in the user pool.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> SendEmailNotification { get; set; }

            /// <summary>
            /// UserName
            /// The email address of the user who is associated with the stack.
            /// Note Users&#39; email addresses are case-sensitive.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// StackName
            /// The name of the stack that is associated with the user.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StackName { get; set; }

            /// <summary>
            /// AuthenticationType
            /// The authentication type for the user who is associated with the stack. You must specify USERPOOL.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: API | SAML | USERPOOL
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::StackUserAssociation";

        public StackUserAssociationProperties Properties { get; } = new StackUserAssociationProperties();

    }
}
