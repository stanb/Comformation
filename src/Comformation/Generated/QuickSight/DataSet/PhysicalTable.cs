using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet PhysicalTable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-physicaltable.html
    /// </summary>
    public class PhysicalTable
    {

        /// <summary>
        /// RelationalTable
        /// A physical table type for relational data sources.
        /// Required: No
        /// Type: RelationalTable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RelationalTable")]
        public RelationalTable RelationalTable { get; set; }

        /// <summary>
        /// CustomSql
        /// A physical table type built from the results of the custom SQL query.
        /// Required: No
        /// Type: CustomSql
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomSql")]
        public CustomSql CustomSql { get; set; }

        /// <summary>
        /// S3Source
        /// A physical table type for as S3 data source.
        /// Required: No
        /// Type: S3Source
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Source")]
        public S3Source S3Source { get; set; }

    }
}
