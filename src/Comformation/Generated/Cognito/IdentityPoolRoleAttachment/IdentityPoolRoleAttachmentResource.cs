using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// AWS::Cognito::IdentityPoolRoleAttachment
    /// The AWS::Cognito::IdentityPoolRoleAttachment resource manages the role configuration for an Amazon Cognito
    /// identity pool.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html
    /// </summary>
    public class IdentityPoolRoleAttachmentResource : ResourceBase
    {
        public class IdentityPoolRoleAttachmentProperties
        {
            /// <summary>
            /// RoleMappings
            /// How users for a specific identity provider are to mapped to roles. This is a string to RoleMapping
            /// object map. The string identifies the identity provider, for example, "graph. facebook. com" or
            /// "cognito-idp-east-1. amazonaws. com/us-east-1_abcdefghi:app_client_id"
            /// Required: No
            /// Type: String to Amazon Cognito IdentityPoolRoleAttachment RoleMapping object map.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-rolemappings
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RoleMappings { get; set; }

            /// <summary>
            /// IdentityPoolId
            /// An identity pool ID in the format REGION:GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-identitypoolid
            /// </summary>
			public Union<string, IntrinsicFunction> IdentityPoolId { get; set; }

            /// <summary>
            /// Roles
            /// The map of roles associated with this pool. For a given role, the key will be either "authenticated"
            /// or "unauthenticated" and the value will be the Role ARN.
            /// Required: No
            /// Type: String to string map
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-roles
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Roles { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::IdentityPoolRoleAttachment";
        
        public IdentityPoolRoleAttachmentProperties Properties { get; } = new IdentityPoolRoleAttachmentProperties();
    }
}
