using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.Endpoint
{
    /// <summary>
    /// AWS::S3Outposts::Endpoint NetworkInterface
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-endpoint-networkinterface.html
    /// </summary>
    public class NetworkInterface
    {

        /// <summary>
        /// NetworkInterfaceId
        /// The ID for the network interface.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

    }
}
