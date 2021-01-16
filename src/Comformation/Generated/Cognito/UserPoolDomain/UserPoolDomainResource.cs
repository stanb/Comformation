using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolDomain
{
    /// <summary>
    /// AWS::Cognito::UserPoolDomain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html
    /// </summary>
    public class UserPoolDomainResource : ResourceBase
    {
        public class UserPoolDomainProperties
        {
            /// <summary>
            /// UserPoolId
            /// The user pool ID for the user pool where you want to associate a user pool domain.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 55
            /// Pattern: [\w-]+_[0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// CustomDomainConfig
            /// The configuration for a custom domain that hosts the sign-up and sign-in pages for your application.
            /// Use this object to specify an SSL certificate that is managed by ACM.
            /// Required: No
            /// Type: CustomDomainConfigType
            /// Update requires: No interruption
            /// </summary>
            public CustomDomainConfigType CustomDomainConfig { get; set; }

            /// <summary>
            /// Domain
            /// The domain name for the domain that hosts the sign-up and sign-in pages for your application. For
            /// example: auth. example. com. If you&#39;re using a prefix domain, this field denotes the first part of
            /// the domain before . auth. [region]. amazoncognito. com.
            /// This string can include only lowercase letters, numbers, and hyphens. Don&#39;t use a hyphen for the
            /// first or last character. Use periods to separate subdomain names.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Pattern: ^[a-z0-9](?:[a-z0-9\-]{0,61}[a-z0-9])?$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Domain { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolDomain";

        public UserPoolDomainProperties Properties { get; } = new UserPoolDomainProperties();

    }
}
