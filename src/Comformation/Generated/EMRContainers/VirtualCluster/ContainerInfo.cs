using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMRContainers.VirtualCluster
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-virtualcluster-containerinfo.html
    /// </summary>
    public class ContainerInfo
    {

        /// <summary>
        /// EksInfo
        /// </summary>
        [JsonProperty("EksInfo")]
        public EksInfo EksInfo { get; set; }

    }
}
