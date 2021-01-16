using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route GrpcRouteMetadata
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html
    /// </summary>
    public class GrpcRouteMetadata
    {

        /// <summary>
        /// Invert
        /// Specify True to match anything except the match criteria. The default value is False.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Invert")]
        public Union<bool, IntrinsicFunction> Invert { get; set; }

        /// <summary>
        /// Name
        /// The name of the route.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Match
        /// An object that represents the data to match from the request.
        /// Required: No
        /// Type: GrpcRouteMetadataMatchMethod
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public GrpcRouteMetadataMatchMethod Match { get; set; }

    }
}
