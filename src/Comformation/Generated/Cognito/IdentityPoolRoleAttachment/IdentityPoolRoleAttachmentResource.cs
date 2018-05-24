using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html
    /// </summary>
    public class IdentityPoolRoleAttachmentResource : ResourceBase
    {
        public class IdentityPoolRoleAttachmentProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-rolemappings
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RoleMappings { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-identitypoolid
            /// </summary>
			public Union<string, IntrinsicFunction> IdentityPoolId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-roles
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Roles { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::IdentityPoolRoleAttachment";
        
        public IdentityPoolRoleAttachmentProperties Properties { get; } = new IdentityPoolRoleAttachmentProperties();
    }
}
