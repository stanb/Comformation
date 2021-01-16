using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration MssPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-msspackage.html
    /// </summary>
    public class MssPackage
    {

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
        /// MssManifests
        /// A list of Microsoft Smooth manifest configurations that are available from this endpoint.
        /// Required: Yes
        /// Type: List of MssManifest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MssManifests")]
        public List<MssManifest> MssManifests { get; set; }

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

    }
}
