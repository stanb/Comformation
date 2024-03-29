using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Stage
{
    /// <summary>
    /// AWS::ApiGatewayV2::Stage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html
    /// </summary>
    public class StageResource : ResourceBase
    {
        public class StageProperties
        {
            /// <summary>
            /// ClientCertificateId
            /// The identifier of a client certificate for a Stage. Supported only for WebSocket APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ClientCertificateId { get; set; }

            /// <summary>
            /// DeploymentId
            /// The deployment identifier for the API stage. Can&#39;t be updated if autoDeploy is enabled.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeploymentId { get; set; }

            /// <summary>
            /// Description
            /// The description for the API stage.
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
            /// AutoDeploy
            /// Specifies whether updates to an API automatically trigger a new deployment. The default value is
            /// false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoDeploy { get; set; }

            /// <summary>
            /// RouteSettings
            /// Route settings for the stage.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RouteSettings { get; set; }

            /// <summary>
            /// StageName
            /// The stage name. Stage names can contain only alphanumeric characters, hyphens, and underscores, or
            /// be $default. Maximum length is 128 characters.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StageName { get; set; }

            /// <summary>
            /// StageVariables
            /// A map that defines the stage variables for a Stage. Variable names can have alphanumeric and
            /// underscore characters, and the values must match [A-Za-z0-9-. _~:/?#&amp;amp;=,]+.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> StageVariables { get; set; }

            /// <summary>
            /// AccessPolicyId
            /// This parameter is not currently supported.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AccessPolicyId { get; set; }

            /// <summary>
            /// ApiId
            /// The API identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// DefaultRouteSettings
            /// The default route settings for the stage.
            /// Required: No
            /// Type: RouteSettings
            /// Update requires: No interruption
            /// </summary>
            public RouteSettings DefaultRouteSettings { get; set; }

            /// <summary>
            /// Tags
            /// The collection of tags. Each tag element is associated with a given resource.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Stage";

        public StageProperties Properties { get; } = new StageProperties();

    }
}
