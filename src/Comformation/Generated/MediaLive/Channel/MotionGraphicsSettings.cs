using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel MotionGraphicsSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicssettings.html
    /// </summary>
    public class MotionGraphicsSettings
    {

        /// <summary>
        /// HtmlMotionGraphicsSettings
        /// Settings to configure the motion graphics overlay to use an HTML asset.
        /// Required: No
        /// Type: HtmlMotionGraphicsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HtmlMotionGraphicsSettings")]
        public HtmlMotionGraphicsSettings HtmlMotionGraphicsSettings { get; set; }

    }
}
