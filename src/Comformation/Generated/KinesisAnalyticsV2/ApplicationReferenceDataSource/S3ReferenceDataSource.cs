using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource S3ReferenceDataSource
    /// The S3ReferenceDataSource property type specifies the Amazon S3 bucket and object that contains reference data
    /// for a SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-s3referencedatasource.html
    /// </summary>
    public class S3ReferenceDataSource
    {

        /// <summary>
        /// BucketARN
        /// The Amazon Resource Name (ARN) of the S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// FileKey
        /// The object key name containing the reference data.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileKey")]
        public Union<string, IntrinsicFunction> FileKey { get; set; }

    }
}
