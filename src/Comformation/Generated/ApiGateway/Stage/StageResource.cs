using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Stage
{
    /// <summary>
    /// AWS::ApiGateway::Stage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html
    /// </summary>
    public class StageResource : ResourceBase
    {
        public class StageProperties
        {
            /// <summary>
            /// AccessLogSetting
            /// Specifies settings for logging access in this stage.
            /// Required: No
            /// Type: AccessLogSetting
            /// Update requires: No interruption
            /// </summary>
            public AccessLogSetting AccessLogSetting { get; set; }

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
            /// CanarySetting
            /// Specifies settings for the canary deployment in this stage.
            /// Required: No
            /// Type: CanarySetting
            /// Update requires: No interruption
            /// </summary>
            public CanarySetting CanarySetting { get; set; }

            /// <summary>
            /// ClientCertificateId
            /// The ID of the client certificate that API Gateway uses to call your integration endpoints in the
            /// stage.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ClientCertificateId { get; set; }

            /// <summary>
            /// DeploymentId
            /// The ID of the deployment that the stage is associated with. This parameter is required to create a
            /// stage.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeploymentId { get; set; }

            /// <summary>
            /// Description
            /// A description of the stage.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DocumentationVersion
            /// The version ID of the API documentation snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DocumentationVersion { get; set; }

            /// <summary>
            /// MethodSettings
            /// Settings for all methods in the stage.
            /// Required: No
            /// Type: List of MethodSetting
            /// Update requires: No interruption
            /// </summary>
            public List<MethodSetting> MethodSettings { get; set; }

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
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StageName { get; set; }

            /// <summary>
            /// Tags
            /// An array of arbitrary tags (key-value pairs) to associate with the stage.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TracingEnabled
            /// Specifies whether active X-Ray tracing is enabled for this stage.
            /// For more information, see Trace API Gateway API Execution with AWS X-Ray in the API Gateway
            /// Developer Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> TracingEnabled { get; set; }

            /// <summary>
            /// Variables
            /// A map (string-to-string map) that defines the stage variables, where the variable name is the key
            /// and the variable value is the value. Variable names are limited to alphanumeric characters. Values
            /// must match the following regular expression: [A-Za-z0-9-. _~:/?#&amp;amp;=,]+.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Variables { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::Stage";

        public StageProperties Properties { get; } = new StageProperties();

    }
}
