using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.ApiGatewayManagedOverrides
{
    /// <summary>
    /// AWS::ApiGatewayV2::ApiGatewayManagedOverrides
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apigatewaymanagedoverrides.html
    /// </summary>
    public class ApiGatewayManagedOverridesResource : ResourceBase
    {
        public class ApiGatewayManagedOverridesProperties
        {
            /// <summary>
            /// Integration
            /// Overrides the integration configuration for an API Gateway-managed integration.
            /// Required: No
            /// Type: IntegrationOverrides
            /// Update requires: No interruption
            /// </summary>
            public IntegrationOverrides Integration { get; set; }

            /// <summary>
            /// Stage
            /// Overrides the stage configuration for an API Gateway-managed stage.
            /// Required: No
            /// Type: StageOverrides
            /// Update requires: No interruption
            /// </summary>
            public StageOverrides Stage { get; set; }

            /// <summary>
            /// ApiId
            /// The ID of the API for which to override the configuration of API Gateway-managed resources.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Route
            /// Overrides the route configuration for an API Gateway-managed route.
            /// Required: No
            /// Type: RouteOverrides
            /// Update requires: No interruption
            /// </summary>
            public RouteOverrides Route { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::ApiGatewayManagedOverrides";

        public ApiGatewayManagedOverridesProperties Properties { get; } = new ApiGatewayManagedOverridesProperties();

    }
}
