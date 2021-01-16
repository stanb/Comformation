using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream OpenXJsonSerDe
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html
    /// </summary>
    public class OpenXJsonSerDe
    {

        /// <summary>
        /// CaseInsensitive
        /// When set to true, which is the default, Kinesis Data Firehose converts JSON keys to lowercase before
        /// deserializing them.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaseInsensitive")]
        public Union<bool, IntrinsicFunction> CaseInsensitive { get; set; }

        /// <summary>
        /// ColumnToJsonKeyMappings
        /// Maps column names to JSON keys that aren&#39;t identical to the column names. This is useful when the
        /// JSON contains keys that are Hive keywords. For example, timestamp is a Hive keyword. If you have a
        /// JSON key named timestamp, set this parameter to {&quot;ts&quot;: &quot;timestamp&quot;} to map this key to a column
        /// named ts.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnToJsonKeyMappings")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ColumnToJsonKeyMappings { get; set; }

        /// <summary>
        /// ConvertDotsInJsonKeysToUnderscores
        /// When set to true, specifies that the names of the keys include dots and that you want Kinesis Data
        /// Firehose to replace them with underscores. This is useful because Apache Hive does not allow dots in
        /// column names. For example, if the JSON contains a key whose name is &quot;a. b&quot;, you can define the
        /// column name to be &quot;a_b&quot; when using this option.
        /// The default is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConvertDotsInJsonKeysToUnderscores")]
        public Union<bool, IntrinsicFunction> ConvertDotsInJsonKeysToUnderscores { get; set; }

    }
}
