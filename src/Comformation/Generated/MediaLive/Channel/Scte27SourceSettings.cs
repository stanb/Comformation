using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Scte27SourceSettings
    /// Information about the SCTE-27 captions to extract from the input.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte27sourcesettings.html
    /// </summary>
    public class Scte27SourceSettings
    {

        /// <summary>
        /// Pid
        /// The PID field is used in conjunction with the captions selector languageCode field as follows:
        /// Specify PID and Language: Extracts captions from that PID; the language is &quot;informational. &quot; Specify
        /// PID and omit Language: Extracts the specified PID. Omit PID and specify Language: Extracts the
        /// specified language, whichever PID that happens to be. Omit PID and omit Language: Valid only if
        /// source is DVB-Sub that is being passed through; all languages are passed through.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pid")]
        public Union<int, IntrinsicFunction> Pid { get; set; }

    }
}
