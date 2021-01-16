using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Route
{
    /// <summary>
    /// AWS::ApiGatewayV2::Route ParameterConstraints
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-route-parameterconstraints.html
    /// </summary>
    public class ParameterConstraints
    {

        /// <summary>
        /// Required
        /// Specifies whether the parameter is required.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Required")]
        public Union<bool, IntrinsicFunction> Required { get; set; }

    }
}
