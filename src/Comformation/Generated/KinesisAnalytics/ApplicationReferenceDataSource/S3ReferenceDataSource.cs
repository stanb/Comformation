using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationReferenceDataSource S3ReferenceDataSource
    /// Identifies the S3 bucket and object that contains the reference data. Also identifies the IAM role Amazon
    /// Kinesis Analytics can assume to read this object on your behalf.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-s3referencedatasource.html
    /// </summary>
    public class S3ReferenceDataSource
    {

        /// <summary>
        /// BucketARN
        /// Amazon Resource Name (ARN) of the S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// FileKey
        /// Object key name containing reference data.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileKey")]
        public Union<string, IntrinsicFunction> FileKey { get; set; }

        /// <summary>
        /// ReferenceRoleARN
        /// ARN of the IAM role that the service can assume to read data on your behalf. This role must have
        /// permission for the s3:GetObject action on the object and trust policy that allows Amazon Kinesis
        /// Analytics service principal to assume this role.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:aws:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReferenceRoleARN")]
        public Union<string, IntrinsicFunction> ReferenceRoleARN { get; set; }

    }
}
