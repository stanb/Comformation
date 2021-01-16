using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration MssManifest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-mssmanifest.html
    /// </summary>
    public class MssManifest
    {

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
        /// StreamSelection
        /// Video bitrate limitations for outputs from this packaging configuration.
        /// Required: No
        /// Type: StreamSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamSelection")]
        public StreamSelection StreamSelection { get; set; }

    }
}
