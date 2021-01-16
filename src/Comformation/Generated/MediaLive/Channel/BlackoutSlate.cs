using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel BlackoutSlate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-blackoutslate.html
    /// </summary>
    public class BlackoutSlate
    {

        /// <summary>
        /// NetworkEndBlackout
        /// Setting to enabled causes MediaLive to blackout the video, audio, and captions, and raise the
        /// &quot;Network Blackout Image&quot; slate when an SCTE104/35 Network End Segmentation Descriptor is
        /// encountered. The blackout is lifted when the Network Start Segmentation Descriptor is encountered.
        /// The Network End and Network Start descriptors must contain a network ID that matches the value
        /// entered in Network ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkEndBlackout")]
        public Union<string, IntrinsicFunction> NetworkEndBlackout { get; set; }

        /// <summary>
        /// State
        /// When set to enabled, this causes video, audio, and captions to be blanked when indicated by program
        /// metadata.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("State")]
        public Union<string, IntrinsicFunction> State { get; set; }

        /// <summary>
        /// NetworkId
        /// Provides a Network ID that matches EIDR ID format (for example, &quot;10.
        /// XXXX/XXXX-XXXX-XXXX-XXXX-XXXX-C&quot;).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkId")]
        public Union<string, IntrinsicFunction> NetworkId { get; set; }

        /// <summary>
        /// NetworkEndBlackoutImage
        /// The path to the local file to use as the Network End Blackout image. The image is scaled to fill the
        /// entire output raster.
        /// Required: No
        /// Type: InputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkEndBlackoutImage")]
        public InputLocation NetworkEndBlackoutImage { get; set; }

        /// <summary>
        /// BlackoutSlateImage
        /// The blackout slate image to be used. Keep empty for solid black. Only . bmp and . png images are
        /// supported.
        /// Required: No
        /// Type: InputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlackoutSlateImage")]
        public InputLocation BlackoutSlateImage { get; set; }

    }
}
