using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.User
{
    /// <summary>
    /// AWS::AppStream::User
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            /// UserName
            /// The email address of the user.
            /// Users&#39; email addresses are case-sensitive. During login, if they specify an email address that
            /// doesn&#39;t use the same capitalization as the email address specified when their user pool account was
            /// created, a &quot;user does not exist&quot; error message displays.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// FirstName
            /// The first name, or given name, of the user.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Pattern: ^[A-Za-z0-9_\-\s]+$
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
            /// Allowed values: RESEND | SUPPRESS
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MessageAction { get; set; }

            /// <summary>
            /// LastName
            /// The last name, or surname, of the user.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Pattern: ^[A-Za-z0-9_\-\s]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LastName { get; set; }

            /// <summary>
            /// AuthenticationType
            /// The authentication type for the user. You must specify USERPOOL.
            /// Required: Yes
            /// Type: String
            /// Allowed values: API | SAML | USERPOOL
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::User";

        public UserProperties Properties { get; } = new UserProperties();

    }
}
