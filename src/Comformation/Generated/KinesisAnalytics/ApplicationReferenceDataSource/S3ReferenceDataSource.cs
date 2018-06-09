using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource S3ReferenceDataSource
    /// The S3ReferenceDataSource property type specifies the Amazon S3 bucket and object that contains the reference
    /// data for Amazon Kinesis Data Analytics.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-s3referencedatasource.html
    /// </summary>
    public class S3ReferenceDataSource
    {

        /// <summary>
        /// BucketARN
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket.
        /// Required: Yes
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// FileKey
        /// The object key name containing reference data.
        /// Required: Yes
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileKey")]
        public Union<string, IntrinsicFunction> FileKey { get; set; }

        /// <summary>
        /// ReferenceRoleARN
        /// The ARN of the IAM role that the service can assume to read data on your behalf.
        /// Required: Yes
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReferenceRoleARN")]
        public Union<string, IntrinsicFunction> ReferenceRoleARN { get; set; }

    }
}
