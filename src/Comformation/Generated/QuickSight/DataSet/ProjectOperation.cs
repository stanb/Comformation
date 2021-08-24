using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet ProjectOperation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-projectoperation.html
    /// </summary>
    public class ProjectOperation
    {

        /// <summary>
        /// ProjectedColumns
        /// Projected columns.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 2000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProjectedColumns")]
        public List<Union<string, IntrinsicFunction>> ProjectedColumns { get; set; }

    }
}
