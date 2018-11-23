using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// AWS::Cognito::IdentityPoolRoleAttachment
    /// The AWS::Cognito::IdentityPoolRoleAttachment resource manages the role configuration for an Amazon Cognito
    /// identity pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html
    /// </summary>
    public class IdentityPoolRoleAttachmentResource : ResourceBase
    {
        public class IdentityPoolRoleAttachmentProperties
        {
            /// <summary>
            /// RoleMappings
            /// How users for a specific identity provider are to mapped to roles. This is a string to RoleMapping
            /// object map. The string identifies the identity provider, for example, &quot;graph. facebook. com&quot; or
            /// &quot;cognito-idp-east-1. amazonaws. com/us-east-1_abcdefghi:app_client_id&quot;
            /// Required: No
            /// Type: String to Amazon Cognito IdentityPoolRoleAttachment RoleMapping object map.
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
            /// The map of roles associated with this pool. For a given role, the key will be either &quot;authenticated&quot;
            /// or &quot;unauthenticated&quot; and the value will be the Role ARN.
            /// Required: No
            /// Type: String to string map
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Roles { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::IdentityPoolRoleAttachment";

        public IdentityPoolRoleAttachmentProperties Properties { get; } = new IdentityPoolRoleAttachmentProperties();

    }
}
