using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoSelectorProgramId
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorprogramid.html
    /// </summary>
    public class VideoSelectorProgramId
    {

        /// <summary>
        /// ProgramId
        /// Selects a specific program from within a multi-program transport stream. If the program doesn&#39;t
        /// exist, MediaLive selects the first program within the transport stream by default.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProgramId")]
        public Union<int, IntrinsicFunction> ProgramId { get; set; }

    }
}
