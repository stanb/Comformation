using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet ColumnTag
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columntag.html
    /// </summary>
    public class ColumnTag
    {

        /// <summary>
        /// ColumnGeographicRole
        /// A geospatial role for a column.
        /// Required: No
        /// Type: String
        /// Allowed values: CITY | COUNTRY | COUNTY | LATITUDE | LONGITUDE | POSTCODE | STATE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnGeographicRole")]
        public Union<string, IntrinsicFunction> ColumnGeographicRole { get; set; }

        /// <summary>
        /// ColumnDescription
        /// A description for a column.
        /// Required: No
        /// Type: ColumnDescription
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnDescription")]
        public ColumnDescription ColumnDescription { get; set; }

    }
}
