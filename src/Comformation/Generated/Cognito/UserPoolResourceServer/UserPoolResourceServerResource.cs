using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolResourceServer
{
    /// <summary>
    /// AWS::Cognito::UserPoolResourceServer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html
    /// </summary>
    public class UserPoolResourceServerResource : ResourceBase
    {
        public class UserPoolResourceServerProperties
        {
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
            /// Identifier
            /// A unique resource server identifier for the resource server. This could be an HTTPS endpoint where
            /// the resource server is located. For example: https://my-weather-api. example. com.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [\x21\x23-\x5B\x5D-\x7E]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Identifier { get; set; }

            /// <summary>
            /// Scopes
            /// A list of scopes. Each scope is a map with keys ScopeName and ScopeDescription.
            /// Required: No
            /// Type: List of ResourceServerScopeType
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public List<ResourceServerScopeType> Scopes { get; set; }

            /// <summary>
            /// Name
            /// A friendly name for the resource server.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [\w\s+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolResourceServer";

        public UserPoolResourceServerProperties Properties { get; } = new UserPoolResourceServerProperties();

    }
}
