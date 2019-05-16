using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Deployment
{
    /// <summary>
    /// AWS::ApiGatewayV2::Deployment
    /// The AWS::ApiGatewayV2::Deployment resource creates a deployment for an API. For more information, see Deploy a
    /// WebSocket API in API Gateway in the API Gateway Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-deployment.html
    /// </summary>
    public class DeploymentResource : ResourceBase
    {
        public class DeploymentProperties
        {
            /// <summary>
            /// Description
            /// The description for the deployment resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// StageName
            /// The name of the Stage resource for the Deployment resource to create.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> StageName { get; set; }

            /// <summary>
            /// ApiId
            /// The API identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Deployment";

        public DeploymentProperties Properties { get; } = new DeploymentProperties();

    }
}
