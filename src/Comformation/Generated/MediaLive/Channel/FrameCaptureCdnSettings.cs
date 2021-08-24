using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FrameCaptureCdnSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturecdnsettings.html
    /// </summary>
    public class FrameCaptureCdnSettings
    {

        /// <summary>
        /// FrameCaptureS3Settings
        /// Sets up Amazon S3 as the destination for this Frame Capture output.
        /// Required: No
        /// Type: FrameCaptureS3Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FrameCaptureS3Settings")]
        public FrameCaptureS3Settings FrameCaptureS3Settings { get; set; }

    }
}
