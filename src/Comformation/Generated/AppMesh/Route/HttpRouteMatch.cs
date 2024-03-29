using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpRouteMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html
    /// </summary>
    public class HttpRouteMatch
    {

        /// <summary>
        /// Path
        /// The client request path to match on.
        /// Required: No
        /// Type: HttpPathMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public HttpPathMatch Path { get; set; }

        /// <summary>
        /// Scheme
        /// The client request scheme to match on. Specify only one. Applicable only for HTTP2 routes.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scheme")]
        public Union<string, IntrinsicFunction> Scheme { get; set; }

        /// <summary>
        /// Headers
        /// The client request headers to match on.
        /// Required: No
        /// Type: List of HttpRouteHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Headers")]
        public List<HttpRouteHeader> Headers { get; set; }

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
        /// The client request method to match on. Specify only one.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Method")]
        public Union<string, IntrinsicFunction> Method { get; set; }

        /// <summary>
        /// QueryParameters
        /// The client request query parameters to match on.
        /// Required: No
        /// Type: List of QueryParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryParameters")]
        public List<QueryParameter> QueryParameters { get; set; }

    }
}
