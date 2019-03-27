using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource RecordColumn
    /// The RecordColumn property type specifies the mapping of each data element in the reference source in a
    /// SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-recordcolumn.html
    /// </summary>
    public class RecordColumn
    {

        /// <summary>
        /// Mapping
        /// A reference to the data element in the reference data source.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mapping")]
        public Union<string, IntrinsicFunction> Mapping { get; set; }

        /// <summary>
        /// SqlType
        /// The type of column created in the in-application reference table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlType")]
        public Union<string, IntrinsicFunction> SqlType { get; set; }

        /// <summary>
        /// Name
        /// The name of the column that is created in the in-application reference table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
