using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint CmafPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-cmafpackage.html
    /// </summary>
    public class CmafPackage
    {

        /// <summary>
        /// SegmentDurationSeconds
        /// Duration (in seconds) of each segment. Actual segments are rounded to the nearest multiple of the
        /// source segment duration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentDurationSeconds")]
        public Union<int, IntrinsicFunction> SegmentDurationSeconds { get; set; }

        /// <summary>
        /// SegmentPrefix
        /// An optional custom string that is prepended to the name of each segment. If not specified, the
        /// segment prefix defaults to the ChannelId.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentPrefix")]
        public Union<string, IntrinsicFunction> SegmentPrefix { get; set; }

        /// <summary>
        /// Encryption
        /// Parameters for encrypting content.
        /// Required: No
        /// Type: CmafEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encryption")]
        public CmafEncryption Encryption { get; set; }

        /// <summary>
        /// StreamSelection
        /// Limitations for outputs from the endpoint, based on the video bitrate.
        /// Required: No
        /// Type: StreamSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamSelection")]
        public StreamSelection StreamSelection { get; set; }

        /// <summary>
        /// HlsManifests
        /// A list of HLS manifest configurations that are available from this endpoint.
        /// Required: No
        /// Type: List of HlsManifest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsManifests")]
        public List<HlsManifest> HlsManifests { get; set; }

    }
}
