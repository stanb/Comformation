using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream CopyCommand
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
        /// Minimum: 0
        /// Maximum: 204800
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CopyOptions")]
        public Union<string, IntrinsicFunction> CopyOptions { get; set; }

        /// <summary>
        /// DataTableColumns
        /// A comma-separated list of column names.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 204800
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataTableColumns")]
        public Union<string, IntrinsicFunction> DataTableColumns { get; set; }

        /// <summary>
        /// DataTableName
        /// The name of the target table. The table must already exist in the database.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataTableName")]
        public Union<string, IntrinsicFunction> DataTableName { get; set; }

    }
}
