using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket AbortIncompleteMultipartUpload
    /// The AbortIncompleteMultipartUpload property type creates a lifecycle rule that aborts incomplete multipart
    /// uploads to an Amazon S3 bucket. When Amazon S3 aborts a multipart upload, it deletes all parts associated with
    /// the multipart upload. For more information, see Aborting Incomplete Multipart Uploads Using a Bucket Lifecycle
    /// Policy in the Amazon Simple Storage Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-abortincompletemultipartupload.html
    /// </summary>
    public class AbortIncompleteMultipartUpload
    {

        /// <summary>
        /// DaysAfterInitiation
        /// The number of days after the upload is initiated before aborting the upload.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DaysAfterInitiation")]
        public Union<int, IntrinsicFunction> DaysAfterInitiation { get; set; }

    }
}
