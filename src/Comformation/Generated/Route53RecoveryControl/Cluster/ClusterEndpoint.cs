using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.Cluster
{
    /// <summary>
    /// AWS::Route53RecoveryControl::Cluster ClusterEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoverycontrol-cluster-clusterendpoint.html
    /// </summary>
    public class ClusterEndpoint
    {

        /// <summary>
        /// Endpoint
        /// A cluster endpoint. Specify an endpoint and AWS Region when you want to set or retrieve a routing
        /// 				control state in the cluster.
        /// To get or update the routing control state, see the Meridian Cluster (Data Plane) Actions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

        /// <summary>
        /// Region
        /// The AWS Region for a cluster endpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

    }
}
