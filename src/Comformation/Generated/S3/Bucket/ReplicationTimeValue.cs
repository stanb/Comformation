using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ReplicationTimeValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtimevalue.html
    /// </summary>
    public class ReplicationTimeValue
    {

        /// <summary>
        /// Minutes
        /// Contains an integer specifying time in minutes.
        /// Valid values: 15 minutes.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Minutes")]
        public Union<int, IntrinsicFunction> Minutes { get; set; }

    }
}
