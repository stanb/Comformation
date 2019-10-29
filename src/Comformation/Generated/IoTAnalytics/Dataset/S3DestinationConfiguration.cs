using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset S3DestinationConfiguration
    /// Configuration information for delivery of data set contents to Amazon S3.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html
    /// </summary>
    public class S3DestinationConfiguration
    {

        /// <summary>
        /// GlueConfiguration
        /// Configuration information for coordination with the AWS Glue ETL (extract, transform and load)
        /// service.
        /// Required: No
        /// Type: GlueConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GlueConfiguration")]
        public GlueConfiguration GlueConfiguration { get; set; }

        /// <summary>
        /// Bucket
        /// The name of the Amazon S3 bucket to which data set contents are delivered.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 255
        /// Pattern: ^[a-zA-Z0-9. \-_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// The key of the data set contents object. Each object in an Amazon S3 bucket has a key that is its
        /// unique identifier within the bucket (each object in a bucket has exactly one key). To produce a
        /// unique key, you can use &quot;!{iotanalytics:scheduleTime}&quot; to insert the time of the scheduled SQL query
        /// run, or &quot;!{iotanalytics:versioned} to insert a unique hash identifying the data set, for example:
        /// &quot;/DataSet/!{iotanalytics:scheduleTime}/!{iotanalytics:versioned}. csv&quot;.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: ^[a-zA-Z0-9!_. *&#39;()/{}:-]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role which grants AWS IoT Analytics permission to interact with your Amazon S3 and
        /// AWS Glue resources.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
