using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    /// AWS::ApiGateway::Deployment
    /// The AWS::ApiGateway::Deployment resource deploys an Amazon API Gateway (API Gateway) RestApi resource to a
    /// stage so that clients can call the API over the Internet. The stage acts as an environment.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html
    /// </summary>
    public class DeploymentResource : ResourceBase
    {
        public class DeploymentProperties
        {
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
            /// Type: Amazon API Gateway Deployment StageDescription
            /// Update requires: No interruption
            /// </summary>
			public Union<StageDescription, IntrinsicFunction> StageDescription { get; set; }

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
