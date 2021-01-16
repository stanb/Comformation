using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WorkSpaces.ConnectionAlias
{
    /// <summary>
    /// AWS::WorkSpaces::ConnectionAlias ConnectionAliasAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-connectionalias-connectionaliasassociation.html
    /// </summary>
    public class ConnectionAliasAssociation
    {

        /// <summary>
        /// AssociationStatus
        /// The association status of the connection alias.
        /// Required: No
        /// Type: String
        /// Allowed values: ASSOCIATED_WITH_OWNER_ACCOUNT | ASSOCIATED_WITH_SHARED_ACCOUNT | NOT_ASSOCIATED |
        /// PENDING_ASSOCIATION | PENDING_DISASSOCIATION
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssociationStatus")]
        public Union<string, IntrinsicFunction> AssociationStatus { get; set; }

        /// <summary>
        /// AssociatedAccountId
        /// The identifier of the AWS account that associated the connection alias with a directory.
        /// Required: No
        /// Type: String
        /// Pattern: ^\d{12}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssociatedAccountId")]
        public Union<string, IntrinsicFunction> AssociatedAccountId { get; set; }

        /// <summary>
        /// ResourceId
        /// The identifier of the directory associated with a connection alias.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceId")]
        public Union<string, IntrinsicFunction> ResourceId { get; set; }

        /// <summary>
        /// ConnectionIdentifier
        /// The identifier of the connection alias association. You use the connection identifier in the DNS TXT
        /// record when you&#39;re configuring your DNS routing policies.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 20
        /// Pattern: ^[a-zA-Z0-9]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionIdentifier")]
        public Union<string, IntrinsicFunction> ConnectionIdentifier { get; set; }

    }
}
