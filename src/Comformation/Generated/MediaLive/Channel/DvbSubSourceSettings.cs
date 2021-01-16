using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel DvbSubSourceSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubsourcesettings.html
    /// </summary>
    public class DvbSubSourceSettings
    {

        /// <summary>
        /// Pid
        /// When using DVB-Sub with burn-in or SMPTE-TT, use this PID for the source content. It is unused for
        /// DVB-Sub passthrough. All DVB-Sub content is passed through, regardless of selectors.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pid")]
        public Union<int, IntrinsicFunction> Pid { get; set; }

    }
}
