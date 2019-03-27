using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Deployment
{
    /// <summary>
    /// AWS::ApiGatewayV2::Deployment
    /// The AWS::ApiGatewayV2::Deployment resource represents a deployment for an API. For more information, see
    /// CreateDeployment in the Amazon API Gateway V2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-deployment.html
    /// </summary>
    public class DeploymentResource : ResourceBase
    {
        public class DeploymentProperties
        {
            /// <summary>
            /// Description
            /// Describes the stage that API Gateway creates with this deployment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// StageName
            /// A name for the stage that API Gateway creates with this deployment. Use only alphanumeric
            /// characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> StageName { get; set; }

            /// <summary>
            /// ApiId
            /// The ID of the Api resource to deploy.
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
