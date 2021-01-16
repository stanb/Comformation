using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolUICustomizationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolUICustomizationAttachment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluicustomizationattachment.html
    /// </summary>
    public class UserPoolUICustomizationAttachmentResource : ResourceBase
    {
        public class UserPoolUICustomizationAttachmentProperties
        {
            /// <summary>
            /// CSS
            /// The CSS values in the UI customization.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CSS { get; set; }

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
            /// ClientId
            /// The client ID for the client app. You can specify the UI customization settings for a single client
            /// (with a specific clientId) or for all clients (by setting the clientId to ALL).
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClientId { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolUICustomizationAttachment";

        public UserPoolUICustomizationAttachmentProperties Properties { get; } = new UserPoolUICustomizationAttachmentProperties();

    }
}
