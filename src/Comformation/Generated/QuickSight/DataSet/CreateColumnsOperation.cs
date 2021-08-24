using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet CreateColumnsOperation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-createcolumnsoperation.html
    /// </summary>
    public class CreateColumnsOperation
    {

        /// <summary>
        /// Columns
        /// Calculated columns to create.
        /// Required: Yes
        /// Type: List of CalculatedColumn
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Columns")]
        public List<CalculatedColumn> Columns { get; set; }

    }
}
