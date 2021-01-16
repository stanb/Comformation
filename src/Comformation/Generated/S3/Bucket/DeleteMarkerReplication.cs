using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket DeleteMarkerReplication
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-deletemarkerreplication.html
    /// </summary>
    public class DeleteMarkerReplication
    {

        /// <summary>
        /// Status
        /// Indicates whether to replicate delete markers.
        /// Note Indicates whether to replicate delete markers.
        /// Required: No
        /// Type: String
        /// Allowed values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
