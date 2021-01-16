using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationNFS
{
    /// <summary>
    /// AWS::DataSync::LocationNFS OnPremConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationnfs-onpremconfig.html
    /// </summary>
    public class OnPremConfig
    {

        /// <summary>
        /// AgentArns
        /// ARNs of the agents to use for an NFS location.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 4
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AgentArns")]
        public List<Union<string, IntrinsicFunction>> AgentArns { get; set; }

    }
}
