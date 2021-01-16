using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.ApiGatewayManagedOverrides
{
    /// <summary>
    /// AWS::ApiGatewayV2::ApiGatewayManagedOverrides StageOverrides
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-stageoverrides.html
    /// </summary>
    public class StageOverrides
    {

        /// <summary>
        /// Description
        /// The description for the API stage.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// AccessLogSettings
        /// Settings for logging access in a stage.
        /// Required: No
        /// Type: AccessLogSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessLogSettings")]
        public AccessLogSettings AccessLogSettings { get; set; }

        /// <summary>
        /// AutoDeploy
        /// Specifies whether updates to an API automatically trigger a new deployment. The default value is
        /// true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutoDeploy")]
        public Union<bool, IntrinsicFunction> AutoDeploy { get; set; }

        /// <summary>
        /// RouteSettings
        /// Route settings for the stage.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RouteSettings")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RouteSettings { get; set; }

        /// <summary>
        /// StageVariables
        /// A map that defines the stage variables for a Stage. Variable names can have alphanumeric and
        /// underscore characters, and the values must match [A-Za-z0-9-. _~:/?#&amp;amp;=,]+.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StageVariables")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> StageVariables { get; set; }

        /// <summary>
        /// DefaultRouteSettings
        /// The default route settings for the stage.
        /// Required: No
        /// Type: RouteSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultRouteSettings")]
        public RouteSettings DefaultRouteSettings { get; set; }

    }
}
