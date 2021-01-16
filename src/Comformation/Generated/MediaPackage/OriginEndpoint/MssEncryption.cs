using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint MssEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-mssencryption.html
    /// </summary>
    public class MssEncryption
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
