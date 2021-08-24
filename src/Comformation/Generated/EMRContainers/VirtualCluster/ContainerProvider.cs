using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMRContainers.VirtualCluster
{
    /// <summary>
    /// AWS::EMRContainers::VirtualCluster ContainerProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerprovider.html
    /// </summary>
    public class ContainerProvider
    {

        /// <summary>
        /// Type
        /// The type of the container provider. EKS is the only supported type as of now.
        /// Required: Yes
        /// Type: String
        /// Allowed values: EKS
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Id
        /// The ID of the container cluster.
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[0-9A-Za-z][A-Za-z0-9\-_]*
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Info
        /// The information about the container cluster.
        /// Required: Yes
        /// Type: ContainerInfo
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Info")]
        public ContainerInfo Info { get; set; }

    }
}
