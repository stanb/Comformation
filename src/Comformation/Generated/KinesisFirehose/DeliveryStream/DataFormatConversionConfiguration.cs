using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream DataFormatConversionConfiguration
    /// Specifies that you want Kinesis Data Firehose to convert data from the JSON format to the Parquet or ORC
    /// format before writing it to Amazon S3. Kinesis Data Firehose uses the serializer and deserializer that you
    /// specify, in addition to the column information from the AWS Glue table, to deserialize your input data from
    /// JSON and then serialize it to the Parquet or ORC format. For more information, see Kinesis Data Firehose
    /// Record Format Conversion.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html
    /// </summary>
    public class DataFormatConversionConfiguration
    {

        /// <summary>
        /// Enabled
        /// Defaults to true. Set it to false if you want to disable format conversion while preserving the
        /// configuration details.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// InputFormatConfiguration
        /// Specifies the deserializer that you want Kinesis Data Firehose to use to convert the format of your
        /// data from JSON.
        /// Required: Yes
        /// Type: InputFormatConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputFormatConfiguration")]
        public InputFormatConfiguration InputFormatConfiguration { get; set; }

        /// <summary>
        /// OutputFormatConfiguration
        /// Specifies the serializer that you want Kinesis Data Firehose to use to convert the format of your
        /// data to the Parquet or ORC format.
        /// Required: Yes
        /// Type: OutputFormatConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputFormatConfiguration")]
        public OutputFormatConfiguration OutputFormatConfiguration { get; set; }

        /// <summary>
        /// SchemaConfiguration
        /// Specifies the AWS Glue Data Catalog table that contains the column information.
        /// Required: Yes
        /// Type: SchemaConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaConfiguration")]
        public SchemaConfiguration SchemaConfiguration { get; set; }

    }
}
