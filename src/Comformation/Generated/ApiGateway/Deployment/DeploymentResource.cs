using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    /// AWS::ApiGateway::Deployment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html
    /// </summary>
    public class DeploymentResource : ResourceBase
    {
        public class DeploymentProperties
        {
            /// <summary>
            /// DeploymentCanarySettings
            /// Specifies settings for the canary deployment.
            /// Required: No
            /// Type: DeploymentCanarySettings
            /// Update requires: Replacement
            /// </summary>
            public DeploymentCanarySettings DeploymentCanarySettings { get; set; }

            /// <summary>
            /// Description
            /// A description of the purpose of the API Gateway deployment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// RestApiId
            /// The ID of the RestApi resource to deploy.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// StageDescription
            /// Configures the stage that API Gateway creates with this deployment.
            /// Required: No
            /// Type: StageDescription
            /// Update requires: No interruption
            /// </summary>
            public StageDescription StageDescription { get; set; }

            /// <summary>
            /// StageName
            /// A name for the stage that API Gateway creates with this deployment. Use only alphanumeric
            /// characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> StageName { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::Deployment";

        public DeploymentProperties Properties { get; } = new DeploymentProperties();

    }
}
