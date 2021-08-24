using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet ColumnLevelPermissionRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columnlevelpermissionrule.html
    /// </summary>
    public class ColumnLevelPermissionRule
    {

        /// <summary>
        /// ColumnNames
        /// An array of column names.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnNames")]
        public List<Union<string, IntrinsicFunction>> ColumnNames { get; set; }

        /// <summary>
        /// Principals
        /// An array of Amazon Resource Names (ARNs) for Amazon QuickSightusers or groups.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Principals")]
        public List<Union<string, IntrinsicFunction>> Principals { get; set; }

    }
}
