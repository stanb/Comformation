using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.Asset
{
    /// <summary>
    /// AWS::MediaPackage::Asset EgressEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-asset-egressendpoint.html
    /// </summary>
    public class EgressEndpoint
    {

        /// <summary>
        /// PackagingConfigurationId
        /// The ID of a packaging configuration that&#39;s applied to this asset.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PackagingConfigurationId")]
        public Union<string, IntrinsicFunction> PackagingConfigurationId { get; set; }

        /// <summary>
        /// Url
        /// The URL that&#39;s used to request content from this endpoint.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
