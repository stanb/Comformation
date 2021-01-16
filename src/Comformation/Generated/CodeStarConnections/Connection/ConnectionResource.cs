using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeStarConnections.Connection
{
    /// <summary>
    /// AWS::CodeStarConnections::Connection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-connection.html
    /// </summary>
    public class ConnectionResource : ResourceBase
    {
        public class ConnectionProperties
        {
            /// <summary>
            /// ConnectionName
            /// The name of the connection. Connection names must be unique in an AWS user account.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: [\s\S]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionName { get; set; }

            /// <summary>
            /// ProviderType
            /// The name of the external provider where your third-party code repository is configured.
            /// Required: No
            /// Type: String
            /// Allowed values: Bitbucket | GitHub | GitHubEnterpriseServer
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProviderType { get; set; }

            /// <summary>
            /// HostArn
            /// The Amazon Resource Name (ARN) of the host associated with the connection.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: arn:aws(-[\w]+)*:codestar-connections:. +:[0-9]{12}:host\/. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> HostArn { get; set; }

            /// <summary>
            /// Tags
            /// Specifies the tags applied to the resource.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CodeStarConnections::Connection";

        public ConnectionProperties Properties { get; } = new ConnectionProperties();

    }

    public static class ConnectionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConnectionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConnectionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConnectionStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConnectionStatus");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OwnerAccountId = new ResourceAttribute<Union<string, IntrinsicFunction>>("OwnerAccountId");
    }
}
