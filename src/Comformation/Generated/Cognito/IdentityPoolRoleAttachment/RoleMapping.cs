using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// AWS::Cognito::IdentityPoolRoleAttachment RoleMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rolemapping.html
    /// </summary>
    public class RoleMapping
    {

        /// <summary>
        /// Type
        /// The role-mapping type. Token uses cognito:roles and cognito:preferred_role claims from the Amazon
        /// Cognito identity provider token to map groups to roles. Rules attempts to match claims from the
        /// token to map to a role.
        /// Valid values are Token or Rules.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// AmbiguousRoleResolution
        /// Specifies the action to be taken if either no rules match the claim value for the Rules type, or
        /// there is no cognito:preferred_role claim and there are multiple cognito:roles matches for the Token
        /// type. If you specify Token or Rules as the Type, AmbiguousRoleResolution is required.
        /// Valid values are AuthenticatedRole or Deny.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AmbiguousRoleResolution")]
        public Union<string, IntrinsicFunction> AmbiguousRoleResolution { get; set; }

        /// <summary>
        /// RulesConfiguration
        /// The rules to be used for mapping users to roles. If you specify &quot;Rules&quot; as the role-mapping type,
        /// RulesConfiguration is required.
        /// Required: No
        /// Type: RulesConfigurationType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RulesConfiguration")]
        public RulesConfigurationType RulesConfiguration { get; set; }

        /// <summary>
        /// IdentityProvider
        /// Identifier for the identity provider for which the role is mapped. For example: graph. facebook. com
        /// or cognito-idp. us-east-1. amazonaws. com/us-east-1_abcdefghi:app_client_id (http://cognito-idp.
        /// us-east-1. amazonaws. com/us-east-1_abcdefghi:app_client_id). This is the identity provider that is
        /// used by the user for authentication.
        /// If the identity provider property isn&#39;t provided, the key of the entry in the RoleMappings map is
        /// used as the identity provider.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IdentityProvider")]
        public Union<string, IntrinsicFunction> IdentityProvider { get; set; }

    }
}
