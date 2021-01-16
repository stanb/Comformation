using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration CmafPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-cmafpackage.html
    /// </summary>
    public class CmafPackage
    {

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
        /// HlsManifests
        /// A list of HLS manifest configurations that are available from this endpoint.
        /// Required: Yes
        /// Type: List of HlsManifest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsManifests")]
        public List<HlsManifest> HlsManifests { get; set; }

        /// <summary>
        /// SegmentDurationSeconds
        /// Duration (in seconds) of each segment. Actual segments are rounded to the nearest multiple of the
        /// source fragment duration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentDurationSeconds")]
        public Union<int, IntrinsicFunction> SegmentDurationSeconds { get; set; }

    }
}
