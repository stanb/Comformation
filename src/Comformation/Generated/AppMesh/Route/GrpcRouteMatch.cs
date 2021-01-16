using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route GrpcRouteMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html
    /// </summary>
    public class GrpcRouteMatch
    {

        /// <summary>
        /// ServiceName
        /// The fully qualified domain name for the service to match from the request.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

        /// <summary>
        /// Metadata
        /// An object that represents the data to match from the request.
        /// Required: No
        /// Type: List of GrpcRouteMetadata
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metadata")]
        public List<GrpcRouteMetadata> Metadata { get; set; }

        /// <summary>
        /// MethodName
        /// The method name to match from the request. If you specify a name, you must also specify a
        /// serviceName.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MethodName")]
        public Union<string, IntrinsicFunction> MethodName { get; set; }

    }
}
