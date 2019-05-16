using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket AbortIncompleteMultipartUpload
    /// Specifies the days since the initiation of an incomplete multipart upload that Amazon S3 will wait before
    /// permanently removing all parts of the upload. For more information, see Aborting Incomplete Multipart Uploads
    /// Using a Bucket Lifecycle Policy in the Amazon Simple Storage Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-abortincompletemultipartupload.html
    /// </summary>
    public class AbortIncompleteMultipartUpload
    {

        /// <summary>
        /// DaysAfterInitiation
        /// Specifies the number of days after which Amazon S3 aborts an incomplete multipart upload.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DaysAfterInitiation")]
        public Union<int, IntrinsicFunction> DaysAfterInitiation { get; set; }

    }
}
