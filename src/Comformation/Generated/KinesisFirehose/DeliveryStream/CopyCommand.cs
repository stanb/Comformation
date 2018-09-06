using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Data Firehose DeliveryStream CopyCommand
    /// The CopyCommand property type configures the Amazon Redshift COPY command that Amazon Kinesis Data Firehose
    /// (Kinesis Data Firehose) uses to load data into an Amazon Redshift cluster from an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-copycommand.html
    /// </summary>
    public class CopyCommand
    {

        /// <summary>
        /// CopyOptions
        /// Parameters to use with the Amazon Redshift COPY command. For examples, see the CopyOptions content
        /// for the CopyCommand data type in the Amazon Kinesis Data Firehose API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CopyOptions")]
        public Union<string, IntrinsicFunction> CopyOptions { get; set; }

        /// <summary>
        /// DataTableColumns
        /// A comma-separated list of the column names in the table that Kinesis Data Firehose copies data to.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DataTableColumns")]
        public Union<string, IntrinsicFunction> DataTableColumns { get; set; }

        /// <summary>
        /// DataTableName
        /// The name of the table where Kinesis Data Firehose adds the copied data.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DataTableName")]
        public Union<string, IntrinsicFunction> DataTableName { get; set; }

    }
}
