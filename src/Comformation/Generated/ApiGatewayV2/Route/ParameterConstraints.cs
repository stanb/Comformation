using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Route
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-route-parameterconstraints.html
    /// </summary>
    public class ParameterConstraints
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("Required")]
        public Union<bool, IntrinsicFunction> Required { get; set; }

    }
}
