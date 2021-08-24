using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration CmafEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-cmafencryption.html
    /// </summary>
    public class CmafEncryption
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
