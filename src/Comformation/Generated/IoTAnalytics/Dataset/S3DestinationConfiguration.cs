using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset S3DestinationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-s3destinationconfiguration.html
    /// </summary>
    public class S3DestinationConfiguration
    {

        /// <summary>
        /// GlueConfiguration
        /// Configuration information for coordination with AWS Glue, a fully managed extract, transform and
        /// load (ETL) service.
        /// Required: No
        /// Type: GlueConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GlueConfiguration")]
        public GlueConfiguration GlueConfiguration { get; set; }

        /// <summary>
        /// Bucket
        /// The name of the S3 bucket to which dataset contents are delivered.
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
        /// The key of the dataset contents object in an S3 bucket. Each object has a key that is a unique
        /// identifier. Each object has exactly one key.
        /// You can create a unique key with the following options:
        /// Use !{iotanalytics:scheduleTime} to insert the time of a scheduled SQL query run. Use
        /// !{iotanalytics:versionId} to insert a unique hash that identifies a dataset content. Use
        /// !{iotanalytics:creationTime} to insert the creation time of a dataset content.
        /// The following example creates a unique key for a CSV file:
        /// dataset/mydataset/!{iotanalytics:scheduleTime}/!{iotanalytics:versionId}. csv
        /// Note If you don&#39;t use !{iotanalytics:versionId} to specify the key, you might get duplicate keys.
        /// For example, you might have two dataset contents with the same scheduleTime but different
        /// versionIds. This means that one dataset content overwrites the other.
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
        /// The ARN of the role that grants AWS IoT Analytics permission to interact with your Amazon S3 and AWS
        /// Glue resources.
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
