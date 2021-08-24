using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule HttpParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-httpparameters.html
    /// </summary>
    public class HttpParameters
    {

        /// <summary>
        /// HeaderParameters
        /// The headers that need to be sent as part of request invoking the API Gateway REST API or EventBridge
        /// ApiDestination.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderParameters")]
        public Dictionary<string, Union<string, IntrinsicFunction>> HeaderParameters { get; set; }

        /// <summary>
        /// PathParameterValues
        /// The path parameter values to be used to populate API Gateway REST API or EventBridge ApiDestination
        /// path wildcards (&quot;*&quot;).
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PathParameterValues")]
        public List<Union<string, IntrinsicFunction>> PathParameterValues { get; set; }

        /// <summary>
        /// QueryStringParameters
        /// The query string keys/values that need to be sent as part of request invoking the API Gateway REST
        /// API or EventBridge ApiDestination.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryStringParameters")]
        public Dictionary<string, Union<string, IntrinsicFunction>> QueryStringParameters { get; set; }

    }
}
