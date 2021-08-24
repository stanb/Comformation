using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.Cluster
{
    /// <summary>
    /// AWS::Redshift::Cluster Endpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-cluster-endpoint.html
    /// </summary>
    public class Endpoint
    {

        /// <summary>
        /// Port
        /// The port that the database engine is listening on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<string, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// Address
        /// The DNS address of the Cluster.
        /// Required: No
        /// Type: String
        /// Maximum: 2147483647
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Address")]
        public Union<string, IntrinsicFunction> Address { get; set; }

    }
}
