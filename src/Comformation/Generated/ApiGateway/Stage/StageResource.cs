using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Stage
{
    /// <summary>
    /// AWS::ApiGateway::Stage
    /// The AWS::ApiGateway::Stage resource creates a stage for an Amazon API Gateway (API Gateway) deployment.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html
    /// </summary>
    public class StageResource : ResourceBase
    {
        public class StageProperties
        {
            /// <summary>
            /// CacheClusterEnabled
            /// Indicates whether cache clustering is enabled for the stage.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> CacheClusterEnabled { get; set; }

            /// <summary>
            /// CacheClusterSize
            /// The stage&#39;s cache cluster size.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CacheClusterSize { get; set; }

            /// <summary>
            /// ClientCertificateId
            /// The identifier of the client certificate that API Gateway uses to call your integration endpoints in
            /// the stage.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ClientCertificateId { get; set; }

            /// <summary>
            /// DeploymentId
            /// The ID of the deployment that the stage points to.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentId { get; set; }

            /// <summary>
            /// Description
            /// A description of the stage&#39;s purpose.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DocumentationVersion
            /// The version identifier of the API documentation snapshot.
            /// Required: No
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> DocumentationVersion { get; set; }

            /// <summary>
            /// MethodSettings
            /// Settings for all methods in the stage.
            /// Required: No
            /// Type: List of API Gateway Stage MethodSetting
            /// Update requires: No interruption
            /// </summary>
			public Union<List<MethodSetting>, IntrinsicFunction> MethodSettings { get; set; }

            /// <summary>
            /// RestApiId
            /// The ID of the RestApi resource that you&#39;re deploying with this stage.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// StageName
            /// The name of the stage, which API Gateway uses as the first path segment in the invoked Uniform
            /// Resource Identifier (URI).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StageName { get; set; }

            /// <summary>
            /// Variables
            /// A map (string-to-string map) that defines the stage variables, where the variable name is the key
            /// and the variable value is the value. Variable names are limited to alphanumeric characters. Values
            /// must match the following regular expression: [A-Za-z0-9-. _~:/?#&amp;amp;amp;=,]+.
            /// Required: No
            /// Type: Mapping of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> Variables { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::Stage";
        
        public StageProperties Properties { get; } = new StageProperties();
    }
}
