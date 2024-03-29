using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.LayerVersionPermission
{
    /// <summary>
    /// AWS::Lambda::LayerVersionPermission
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
            /// Maximum: 22
            /// Pattern: lambda:GetLayerVersion
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// LayerVersionArn
            /// The name or Amazon Resource Name (ARN) of the layer.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern: (arn:[a-zA-Z0-9-]+:lambda:[a-zA-Z0-9-]+:\d{12}:layer:[a-zA-Z0-9-_]+)|[a-zA-Z0-9-_]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LayerVersionArn { get; set; }

            /// <summary>
            /// OrganizationId
            /// With the principal set to *, grant permission to all accounts in the specified organization.
            /// Required: No
            /// Type: String
            /// Maximum: 34
            /// Pattern: o-[a-z0-9]{10,32}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OrganizationId { get; set; }

            /// <summary>
            /// Principal
            /// An account ID, or * to grant layer usage permission to all accounts in an organization, or all AWS
            /// accounts (if organizationId is not specified). For the last case, make sure that you really do want
            /// all AWS accounts to have usage permission to this layer.
            /// Required: Yes
            /// Type: String
            /// Pattern: \d{12}|\*|arn:(aws[a-zA-Z-]*):iam::\d{12}:root
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Principal { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::LayerVersionPermission";

        public LayerVersionPermissionProperties Properties { get; } = new LayerVersionPermissionProperties();

    }
}
