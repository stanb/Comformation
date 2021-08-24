using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint NeptuneSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html
    /// </summary>
    public class NeptuneSettings
    {

        /// <summary>
        /// MaxRetryCount
        /// The number of times for AWS DMS to retry a bulk load of migrated graph data to the Neptune target
        /// database before raising an error. The default is 5.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxRetryCount")]
        public Union<int, IntrinsicFunction> MaxRetryCount { get; set; }

        /// <summary>
        /// MaxFileSize
        /// The maximum size in kilobytes of migrated graph data stored in a . csv file before AWS DMS
        /// bulk-loads the data to the Neptune target database. The default is 1,048,576 KB. If the bulk load is
        /// successful, AWS DMS clears the bucket, ready to store the next batch of migrated graph data.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxFileSize")]
        public Union<int, IntrinsicFunction> MaxFileSize { get; set; }

        /// <summary>
        /// S3BucketFolder
        /// A folder path where you want AWS DMS to store migrated graph data in the S3 bucket specified by
        /// S3BucketName
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketFolder")]
        public Union<string, IntrinsicFunction> S3BucketFolder { get; set; }

        /// <summary>
        /// ErrorRetryDuration
        /// The number of milliseconds for AWS DMS to wait to retry a bulk-load of migrated graph data to the
        /// Neptune target database before raising an error. The default is 250.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorRetryDuration")]
        public Union<int, IntrinsicFunction> ErrorRetryDuration { get; set; }

        /// <summary>
        /// IamAuthEnabled
        /// If you want AWS Identity and Access Management (IAM) authorization enabled for this endpoint, set
        /// this parameter to true. Then attach the appropriate IAM policy document to your service role
        /// specified by ServiceAccessRoleArn. The default is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamAuthEnabled")]
        public Union<bool, IntrinsicFunction> IamAuthEnabled { get; set; }

        /// <summary>
        /// S3BucketName
        /// The name of the Amazon S3 bucket where AWS DMS can temporarily store migrated graph data in . csv
        /// files before bulk-loading it to the Neptune target database. AWS DMS maps the SQL source data to
        /// graph data before storing it in these . csv files.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketName")]
        public Union<string, IntrinsicFunction> S3BucketName { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// The Amazon Resource Name (ARN) of the service role that you created for the Neptune target endpoint.
        /// The role must allow the iam:PassRole action. For more information, see Creating an IAM Service Role
        /// for Accessing Amazon Neptune as a Target in the AWS Database Migration Service User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

    }
}
