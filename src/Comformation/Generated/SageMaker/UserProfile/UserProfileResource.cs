using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.UserProfile
{
    /// <summary>
    /// AWS::SageMaker::UserProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html
    /// </summary>
    public class UserProfileResource : ResourceBase
    {
        public class UserProfileProperties
        {
            /// <summary>
            /// DomainId
            /// The domain ID.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainId { get; set; }

            /// <summary>
            /// SingleSignOnUserIdentifier
            /// A specifier for the type of value specified in SingleSignOnUserValue. Currently, the only supported
            /// value is &quot;UserName&quot;. If the Domain&#39;s AuthMode is SSO, this field is required. If the Domain&#39;s
            /// AuthMode is not SSO, this field cannot be specified.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SingleSignOnUserIdentifier { get; set; }

            /// <summary>
            /// SingleSignOnUserValue
            /// The username of the associated AWS Single Sign-On User for this UserProfile. If the Domain&#39;s
            /// AuthMode is SSO, this field is required, and must match a valid username of a user in your
            /// directory. If the Domain&#39;s AuthMode is not SSO, this field cannot be specified.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SingleSignOnUserValue { get; set; }

            /// <summary>
            /// UserProfileName
            /// The user profile name.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserProfileName { get; set; }

            /// <summary>
            /// UserSettings
            /// A collection of settings that apply to users of Amazon SageMaker Studio.
            /// Required: No
            /// Type: UserSettings
            /// Update requires: No interruption
            /// </summary>
            public UserSettings UserSettings { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// Tags that you specify for the User Profile are also added to all Apps that the User Profile
            /// launches.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::UserProfile";

        public UserProfileProperties Properties { get; } = new UserProfileProperties();

    }

    public static class UserProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> UserProfileArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("UserProfileArn");
    }
}
