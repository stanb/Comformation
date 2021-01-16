using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration DashManifest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashmanifest.html
    /// </summary>
    public class DashManifest
    {

        /// <summary>
        /// ManifestLayout
        /// Determines the position of some tags in the Media Presentation Description (MPD). When set to FULL,
        /// elements like SegmentTemplate and ContentProtection are included in each Representation. When set to
        /// COMPACT, duplicate elements are combined and presented at the AdaptationSet level.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestLayout")]
        public Union<string, IntrinsicFunction> ManifestLayout { get; set; }

        /// <summary>
        /// ManifestName
        /// A short string that&#39;s appended to the end of the endpoint URL to create a unique path to this
        /// packaging configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestName")]
        public Union<string, IntrinsicFunction> ManifestName { get; set; }

        /// <summary>
        /// MinBufferTimeSeconds
        /// Minimum amount of content (measured in seconds) that a player must keep available in the buffer.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinBufferTimeSeconds")]
        public Union<int, IntrinsicFunction> MinBufferTimeSeconds { get; set; }

        /// <summary>
        /// Profile
        /// The DASH profile type. When set to HBBTV_1_5, the content is compliant with HbbTV 1. 5.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Profile")]
        public Union<string, IntrinsicFunction> Profile { get; set; }

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
