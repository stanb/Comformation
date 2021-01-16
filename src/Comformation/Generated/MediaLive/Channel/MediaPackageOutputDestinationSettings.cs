using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel MediaPackageOutputDestinationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html
    /// </summary>
    public class MediaPackageOutputDestinationSettings
    {

        /// <summary>
        /// ChannelId
        /// The ID of the channel in MediaPackage that is the destination for this output group. You don&#39;t need
        /// to specify the individual inputs in MediaPackage; MediaLive handles the connection of the two
        /// MediaLive pipelines to the two MediaPackage inputs. The MediaPackage channel and MediaLive channel
        /// must be in the same Region.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelId")]
        public Union<string, IntrinsicFunction> ChannelId { get; set; }

    }
}
