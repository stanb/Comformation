using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// Amazon Cognito IdentityPoolRoleAttachment RoleMapping
    /// RoleMapping is a property of the AWS::Cognito::IdentityPoolRoleAttachment resource that defines the role
    /// mapping attributes of an Amazon Cognito identity pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rolemapping.html
    /// </summary>
    public class RoleMapping
    {

        /// <summary>
        /// Type
        /// The role mapping type. Token will use cognito:roles and cognito:preferred_role claims from the
        /// Amazon Cognito identity provider token to map groups to roles. Rules will attempt to match claims
        /// from the token to map to a role.
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
        /// The rules to be used for mapping users to roles. If you specify Rules as the role mapping type,
        /// RulesConfiguration is required.
        /// Required: No
        /// Type: Amazon Cognito IdentityPoolRoleAttachment RoleMapping RulesConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RulesConfiguration")]
        public Union<RulesConfigurationType, IntrinsicFunction> RulesConfiguration { get; set; }

    }
}
