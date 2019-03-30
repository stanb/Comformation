using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS AppMesh Route WeightedTarget
    /// An object representing a target and its relative weight. Traffic is distributed across targets according to
    /// their relative weight. For example, a weighted target with a relative weight of 50 receives five times as much
    /// traffic as one with a relative weight of 10.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html
    /// </summary>
    public class WeightedTarget
    {

        /// <summary>
        /// VirtualNode
        /// The virtual node to associate with the weighted target.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualNode")]
        public Union<string, IntrinsicFunction> VirtualNode { get; set; }

        /// <summary>
        /// Weight
        /// The relative weight of the weighted target.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Weight")]
        public Union<int, IntrinsicFunction> Weight { get; set; }

    }
}
