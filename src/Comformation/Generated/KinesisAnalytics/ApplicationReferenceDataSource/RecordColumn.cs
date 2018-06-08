using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource RecordColumn
    /// The RecordColumn property type specifies the mapping of each data element in the streaming source to the
    /// corresponding column in the in-application stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordcolumn.html
    /// </summary>
    public class RecordColumn
    {

        /// <summary>
        /// Mapping
        /// The reference to the data element in the streaming input of the reference data source.
        /// Required: No
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mapping")]
        public Union<string, IntrinsicFunction> Mapping { get; set; }

        /// <summary>
        /// SqlType
        /// The SQL data type of the column created in the in-application input stream or reference table.
        /// Required: Yes
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlType")]
        public Union<string, IntrinsicFunction> SqlType { get; set; }

        /// <summary>
        /// Name
        /// The name of the column created in the in-application input stream or reference table.
        /// Required: Yes
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
