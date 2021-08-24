using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet TagColumnOperation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-tagcolumnoperation.html
    /// </summary>
    public class TagColumnOperation
    {

        /// <summary>
        /// ColumnName
        /// The column that this operation acts on.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnName")]
        public Union<string, IntrinsicFunction> ColumnName { get; set; }

        /// <summary>
        /// Tags
        /// The dataset column tag, currently only used for geospatial type tagging.
        /// Note This is not tags for the AWS tagging feature.
        /// Required: Yes
        /// Type: List of ColumnTag
        /// Maximum: 16
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<ColumnTag> Tags { get; set; }

    }
}
