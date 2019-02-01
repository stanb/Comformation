using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.LayerVersionPermission
{
    /// <summary>
    /// AWS::Lambda::LayerVersionPermission
    /// The AWS::Lambda::LayerVersionPermission resource gives other accounts permission to use a layer version in AWS
    /// Lambda. For more information, see AWS Lambda Layers in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-layerversionpermission.html
    /// </summary>
    public class LayerVersionPermissionResource : ResourceBase
    {
        public class LayerVersionPermissionProperties
        {
            /// <summary>
            /// Action
            /// The API action that grants access to the layer. For example, lambda:GetLayerVersion.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// LayerVersionArn
            /// The ARN of the layer version.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LayerVersionArn { get; set; }

            /// <summary>
            /// OrganizationId
            /// With the principal set to *, grant permission to all accounts in the specified organization.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> OrganizationId { get; set; }

            /// <summary>
            /// Principal
            /// An account ID, or * to grant permission to all AWS accounts.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::LayerVersionPermission";

        public LayerVersionPermissionProperties Properties { get; } = new LayerVersionPermissionProperties();

    }
}
