using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRouteMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html
    /// </summary>
    public class HttpGatewayRouteMatch
    {

        /// <summary>
        /// Path
        /// The path to match on.
        /// Required: No
        /// Type: HttpPathMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public HttpPathMatch Path { get; set; }

        /// <summary>
        /// Headers
        /// The client request headers to match on.
        /// Required: No
        /// Type: List of HttpGatewayRouteHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Headers")]
        public List<HttpGatewayRouteHeader> Headers { get; set; }

        /// <summary>
        /// Hostname
        /// The host name to match on.
        /// Required: No
        /// Type: GatewayRouteHostnameMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hostname")]
        public GatewayRouteHostnameMatch Hostname { get; set; }

        /// <summary>
        /// Prefix
        /// Specifies the path to match requests with. This parameter must always start with /, which by itself
        /// matches all requests to the virtual service name. You can also match for path-based routing of
        /// requests. For example, if your virtual service name is my-service. local and you want the route to
        /// match requests to my-service. local/metrics, your prefix should be /metrics.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// Method
        /// The method to match on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Method")]
        public Union<string, IntrinsicFunction> Method { get; set; }

        /// <summary>
        /// QueryParameters
        /// The query parameter to match on.
        /// Required: No
        /// Type: List of QueryParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryParameters")]
        public List<QueryParameter> QueryParameters { get; set; }

    }
}
