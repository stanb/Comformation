using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FrameCaptureOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecaptureoutputsettings.html
    /// </summary>
    public class FrameCaptureOutputSettings
    {

        /// <summary>
        /// NameModifier
        /// Required if the output group contains more than one output. This modifier forms part of the output
        /// file name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NameModifier")]
        public Union<string, IntrinsicFunction> NameModifier { get; set; }

    }
}
