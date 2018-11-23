using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.User
{
    /// <summary>
    /// AWS::AppStream::User
    /// The AWS::AppStream::User resource creates a new user in the user pool for Amazon AppStream 2. 0. For more
    /// information, see CreateUser in the Amazon AppStream 2. 0 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            /// UserName
            /// The email address of the user.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// FirstName
            /// The first name, or given name, of the user.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FirstName { get; set; }

            /// <summary>
            /// MessageAction
            /// The action to take for the welcome email that is sent to a user after the user is created in the
            /// user pool. If you specify SUPPRESS, no email is sent. If you specify RESEND, do not specify the
            /// first name or last name of the user. If the value is null, the email is sent.
            /// Note The temporary password in the welcome email is valid for only 7 days. If users don’t set their
            /// passwords within 7 days, you must send them a new welcome email.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MessageAction { get; set; }

            /// <summary>
            /// LastName
            /// The last name, or surname, of the user.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LastName { get; set; }

            /// <summary>
            /// AuthenticationType
            /// The authentication type for the user. You must specify USERPOOL.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::User";

        public UserProperties Properties { get; } = new UserProperties();

    }
}
