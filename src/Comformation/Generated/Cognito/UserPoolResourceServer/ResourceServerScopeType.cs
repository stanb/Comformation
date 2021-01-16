using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolResourceServer
{
    /// <summary>
    /// AWS::Cognito::UserPoolResourceServer ResourceServerScopeType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolresourceserver-resourceserverscopetype.html
    /// </summary>
    public class ResourceServerScopeType
    {

        /// <summary>
        /// ScopeName
        /// The name of the scope.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [\x21\x23-\x2E\x30-\x5B\x5D-\x7E]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScopeName")]
        public Union<string, IntrinsicFunction> ScopeName { get; set; }

        /// <summary>
        /// ScopeDescription
        /// A description of the scope.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScopeDescription")]
        public Union<string, IntrinsicFunction> ScopeDescription { get; set; }

    }
}
