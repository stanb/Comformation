using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel NielsenConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-nielsenconfiguration.html
    /// </summary>
    public class NielsenConfiguration
    {

        /// <summary>
        /// DistributorId
        /// Enter the Distributor ID assigned to your organization by Nielsen.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DistributorId")]
        public Union<string, IntrinsicFunction> DistributorId { get; set; }

        /// <summary>
        /// NielsenPcmToId3Tagging
        /// Enables Nielsen PCM to ID3 tagging
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NielsenPcmToId3Tagging")]
        public Union<string, IntrinsicFunction> NielsenPcmToId3Tagging { get; set; }

    }
}
