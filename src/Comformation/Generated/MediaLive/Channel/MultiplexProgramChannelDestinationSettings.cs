using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel MultiplexProgramChannelDestinationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexprogramchanneldestinationsettings.html
    /// </summary>
    public class MultiplexProgramChannelDestinationSettings
    {

        /// <summary>
        /// MultiplexId
        /// The ID of the Multiplex that the encoder is providing output to. You do not need to specify the
        /// individual inputs to the Multiplex; MediaLive will handle the connection of the two MediaLive
        /// pipelines to the two Multiplex instances. The Multiplex must be in the same region as the Channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MultiplexId")]
        public Union<string, IntrinsicFunction> MultiplexId { get; set; }

        /// <summary>
        /// ProgramName
        /// The program name of the Multiplex program that the encoder is providing output to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProgramName")]
        public Union<string, IntrinsicFunction> ProgramName { get; set; }

    }
}
