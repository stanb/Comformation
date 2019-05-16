using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationReferenceDataSource RecordColumn
    /// Describes the mapping of each data element in the streaming source to the corresponding column in the
    /// in-application stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordcolumn.html
    /// </summary>
    public class RecordColumn
    {

        /// <summary>
        /// Mapping
        /// Reference to the data element in the streaming input or the reference data source. This element is
        /// required if the RecordFormatType is JSON.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mapping")]
        public Union<string, IntrinsicFunction> Mapping { get; set; }

        /// <summary>
        /// SqlType
        /// Type of column created in the in-application input stream or reference table.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlType")]
        public Union<string, IntrinsicFunction> SqlType { get; set; }

        /// <summary>
        /// Name
        /// Name of the column created in the in-application input stream or reference table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
