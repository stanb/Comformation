using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FrameCaptureGroupSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-framecapturegroupsettings.html
    /// </summary>
    public class FrameCaptureGroupSettings
    {

        /// <summary>
        /// Destination
        /// The destination for the frame capture files. The destination is either the URI for an Amazon S3
        /// bucket and object, plus a file name prefix (for example,
        /// s3ssl://sportsDelivery/highlights/20180820/curling_) or the URI for a MediaStore container, plus a
        /// file name prefix (for example, mediastoressl://sportsDelivery/20180820/curling_). The final file
        /// names consist of the prefix from the destination field (for example, &quot;curling_&quot;) + name modifier +
        /// the counter (5 digits, starting from 00001) + extension (which is always . jpg). For example,
        /// curlingLow. 00001. jpg.
        /// Required: No
        /// Type: OutputLocationRef
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public OutputLocationRef Destination { get; set; }

    }
}
