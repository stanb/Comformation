using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.StackUserAssociation
{
    /// <summary>
    /// AWS::AppStream::StackUserAssociation
    /// The AWS::AppStream::StackUserAssociation resource associates the specified stacks with the specified users for
    /// Amazon AppStream 2. 0. For more information, see UserStackAssociation in the Amazon AppStream 2. 0 API
    /// Reference.
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
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> SendEmailNotification { get; set; }

            /// <summary>
            /// UserName
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// StackName
            /// The name of the stack.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StackName { get; set; }

            /// <summary>
            /// AuthenticationType
            /// The authentication type for the user.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::StackUserAssociation";

        public StackUserAssociationProperties Properties { get; } = new StackUserAssociationProperties();

    }
}
