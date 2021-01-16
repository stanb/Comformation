using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint MssPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-msspackage.html
    /// </summary>
    public class MssPackage
    {

        /// <summary>
        /// ManifestWindowSeconds
        /// Time window (in seconds) contained in each manifest.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestWindowSeconds")]
        public Union<int, IntrinsicFunction> ManifestWindowSeconds { get; set; }

        /// <summary>
        /// SegmentDurationSeconds
        /// Duration (in seconds) of each fragment. Actual fragments are rounded to the nearest multiple of the
        /// source fragment duration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentDurationSeconds")]
        public Union<int, IntrinsicFunction> SegmentDurationSeconds { get; set; }

        /// <summary>
        /// Encryption
        /// Parameters for encrypting content.
        /// Required: No
        /// Type: MssEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encryption")]
        public MssEncryption Encryption { get; set; }

        /// <summary>
        /// StreamSelection
        /// Limitations for outputs from the endpoint, based on the video bitrate.
        /// Required: No
        /// Type: StreamSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamSelection")]
        public StreamSelection StreamSelection { get; set; }

    }
}
