using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Stage
{
    /// <summary>
    /// AWS::ApiGatewayV2::Stage
    /// The AWS::ApiGatewayV2::Stage resource creates a stage for an Amazon API Gateway deployment. For more
    /// information, see CreateStage in the Amazon API Gateway V2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html
    /// </summary>
    public class StageResource : ResourceBase
    {
        public class StageProperties
        {
            /// <summary>
            /// ClientCertificateId
            /// The ID of a client certificate for the stage.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ClientCertificateId { get; set; }

            /// <summary>
            /// DeploymentId
            /// The ID of the deployment that the stage is associated with.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentId { get; set; }

            /// <summary>
            /// Description
            /// Description of the stage.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AccessLogSettings
            /// Settings for logging access in this stage.
            /// Required: No
            /// Type: AccessLogSettings
            /// Update requires: No interruption
            /// </summary>
			public AccessLogSettings AccessLogSettings { get; set; }

            /// <summary>
            /// RouteSettings
            /// Route settings for the stage. This is a mapping of Strings to RouteSettings.
            /// Required: No
            /// Type: Mapping of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RouteSettings { get; set; }

            /// <summary>
            /// StageName
            /// The name of the stage.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StageName { get; set; }

            /// <summary>
            /// StageVariables
            /// A String to String mapping that defines the stage variables for a stage resource. Variable names can
            /// have alphanumeric and underscore characters, and the values must match [A-Za-z0-9-. _~:/?#&amp;amp;=,]+.
            /// Required: No
            /// Type: Mapping of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> StageVariables { get; set; }

            /// <summary>
            /// ApiId
            /// The API ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// DefaultRouteSettings
            /// Default route settings for the stage.
            /// Required: No
            /// Type: RouteSettings
            /// Update requires: No interruption
            /// </summary>
			public RouteSettings DefaultRouteSettings { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Stage";

        public StageProperties Properties { get; } = new StageProperties();

    }
}
