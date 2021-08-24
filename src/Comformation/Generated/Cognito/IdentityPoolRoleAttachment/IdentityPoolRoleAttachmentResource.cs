using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// AWS::Cognito::IdentityPoolRoleAttachment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html
    /// </summary>
    public class IdentityPoolRoleAttachmentResource : ResourceBase
    {
        public class IdentityPoolRoleAttachmentProperties
        {
            /// <summary>
            /// RoleMappings
            /// How users for a specific identity provider are mapped to roles. This is a string to the RoleMapping
            /// object map. The string identifies the identity provider. For example: graph. facebook. com or
            /// cognito-idp. us-east-1. amazonaws. com/us-east-1_abcdefghi:app_client_id.
            /// If the IdentityProvider field isn&#39;t provided in this object, the string is used as the identity
            /// provider name.
            /// For more information, see the RoleMapping property.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RoleMappings { get; set; }

            /// <summary>
            /// IdentityPoolId
            /// An identity pool ID in the format REGION:GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IdentityPoolId { get; set; }

            /// <summary>
            /// Roles
            /// The map of the roles associated with this pool. For a given role, the key is either &quot;authenticated&quot;
            /// or &quot;unauthenticated&quot;. The value is the role ARN.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Roles { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::IdentityPoolRoleAttachment";

        public IdentityPoolRoleAttachmentProperties Properties { get; } = new IdentityPoolRoleAttachmentProperties();

    }
}
