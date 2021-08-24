using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.Bucket
{
    /// <summary>
    /// AWS::S3Outposts::Bucket AbortIncompleteMultipartUpload
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-abortincompletemultipartupload.html
    /// </summary>
    public class AbortIncompleteMultipartUpload
    {

        /// <summary>
        /// DaysAfterInitiation
        /// Specifies the number of days after initiation that Amazon S3 on Outposts aborts an incomplete
        /// multipart upload.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DaysAfterInitiation")]
        public Union<int, IntrinsicFunction> DaysAfterInitiation { get; set; }

    }
}
