using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.Channel
{
    /// <summary>
    /// AWS::MediaPackage::Channel HlsIngest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-hlsingest.html
    /// </summary>
    public class HlsIngest
    {

        /// <summary>
        /// ingestEndpoints
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of IngestEndpoint
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ingestEndpoints")]
        public List<IngestEndpoint> ingestEndpoints { get; set; }

    }
}
