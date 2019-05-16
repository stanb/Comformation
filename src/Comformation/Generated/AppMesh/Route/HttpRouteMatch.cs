using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpRouteMatch
    /// An object representing the requirements for a route to match HTTP requests for a virtual router.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html
    /// </summary>
    public class HttpRouteMatch
    {

        /// <summary>
        /// Prefix
        /// Specifies the path to match requests with. This parameter must always start with /, which by itself
        /// matches all requests to the virtual service name. You can also match for path-based routing of
        /// requests. For example, if your virtual service name is my-service. local and you want the route to
        /// match requests to my-service. local/metrics, your prefix should be /metrics.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}
