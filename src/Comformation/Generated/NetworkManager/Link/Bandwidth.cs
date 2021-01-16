using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.Link
{
    /// <summary>
    /// AWS::NetworkManager::Link Bandwidth
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-link-bandwidth.html
    /// </summary>
    public class Bandwidth
    {

        /// <summary>
        /// DownloadSpeed
        /// Download speed in Mbps.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DownloadSpeed")]
        public Union<int, IntrinsicFunction> DownloadSpeed { get; set; }

        /// <summary>
        /// UploadSpeed
        /// Upload speed in Mbps.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UploadSpeed")]
        public Union<int, IntrinsicFunction> UploadSpeed { get; set; }

    }
}
