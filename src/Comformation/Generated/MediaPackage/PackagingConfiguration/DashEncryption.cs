using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration DashEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashencryption.html
    /// </summary>
    public class DashEncryption
    {

        /// <summary>
        /// SpekeKeyProvider
        /// Parameters for the SPEKE key provider.
        /// Required: Yes
        /// Type: SpekeKeyProvider
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpekeKeyProvider")]
        public SpekeKeyProvider SpekeKeyProvider { get; set; }

    }
}
