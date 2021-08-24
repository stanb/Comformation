using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMRContainers.VirtualCluster
{
    /// <summary>
    /// AWS::EMRContainers::VirtualCluster ContainerInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerinfo.html
    /// </summary>
    public class ContainerInfo
    {

        /// <summary>
        /// EksInfo
        /// The information about the EKS cluster.
        /// Required: Yes
        /// Type: EksInfo
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EksInfo")]
        public EksInfo EksInfo { get; set; }

    }
}
