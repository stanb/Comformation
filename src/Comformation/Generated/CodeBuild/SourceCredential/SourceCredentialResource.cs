using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.SourceCredential
{
    /// <summary>
    /// AWS::CodeBuild::SourceCredential
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html
    /// </summary>
    public class SourceCredentialResource : ResourceBase
    {
        public class SourceCredentialProperties
        {
            /// <summary>
            /// ServerType
            /// The type of source provider. The valid options are GITHUB, GITHUB_ENTERPRISE, or BITBUCKET.
            /// Required: Yes
            /// Type: String
            /// Allowed values: BITBUCKET | GITHUB | GITHUB_ENTERPRISE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServerType { get; set; }

            /// <summary>
            /// Username
            /// The Bitbucket username when the authType is BASIC_AUTH. This parameter is not valid for other types
            /// of source providers or connections.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Username { get; set; }

            /// <summary>
            /// Token
            /// For GitHub or GitHub Enterprise, this is the personal access token. For Bitbucket, this is the app
            /// password.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Token { get; set; }

            /// <summary>
            /// AuthType
            /// The type of authentication used by the credentials. Valid options are OAUTH, BASIC_AUTH, or
            /// PERSONAL_ACCESS_TOKEN.
            /// Required: Yes
            /// Type: String
            /// Allowed values: BASIC_AUTH | OAUTH | PERSONAL_ACCESS_TOKEN
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthType { get; set; }

        }

        public string Type { get; } = "AWS::CodeBuild::SourceCredential";

        public SourceCredentialProperties Properties { get; } = new SourceCredentialProperties();

    }
}
