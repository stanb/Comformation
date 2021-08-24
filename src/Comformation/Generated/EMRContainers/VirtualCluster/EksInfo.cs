using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMRContainers.VirtualCluster
{
    /// <summary>
    /// AWS::EMRContainers::VirtualCluster EksInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-eksinfo.html
    /// </summary>
    public class EksInfo
    {

        /// <summary>
        /// Namespace
        /// The namespaces of the EKS cluster.
        /// Minimum: 1
        /// Maximum: 63
        /// Pattern: [a-z0-9]([-a-z0-9]*[a-z0-9])?
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

    }
}
