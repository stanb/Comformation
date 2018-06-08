using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket AccessControlTranslation
    /// The AccessControlTranslation property type specifies replica ownership of the AWS account that owns the
    /// destination bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accesscontroltranslation.html
    /// </summary>
    public class AccessControlTranslation
    {

        /// <summary>
        /// Owner
        /// Specifies the replica ownership.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

    }
}
