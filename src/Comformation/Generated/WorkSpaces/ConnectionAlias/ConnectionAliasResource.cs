using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WorkSpaces.ConnectionAlias
{
    /// <summary>
    /// AWS::WorkSpaces::ConnectionAlias
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-connectionalias.html
    /// </summary>
    public class ConnectionAliasResource : ResourceBase
    {
        public class ConnectionAliasProperties
        {
            /// <summary>
            /// ConnectionString
            /// The connection string specified for the connection alias. The connection string must be in the form
            /// of a fully qualified domain name (FQDN), such as www. example. com.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: ^[. 0-9a-zA-Z\-]{1,255}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionString { get; set; }

            /// <summary>
            /// Tags
            /// The tags to associate with the connection alias.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::WorkSpaces::ConnectionAlias";

        public ConnectionAliasProperties Properties { get; } = new ConnectionAliasProperties();

    }

    public static class ConnectionAliasAttributes
    {
        public static readonly ResourceAttribute<List<ConnectionAliasAssociation>> Associations = new ResourceAttribute<List<ConnectionAliasAssociation>>("Associations");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AliasId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AliasId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConnectionAliasState = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConnectionAliasState");
    }
}
