using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// AWS::QuickSight::Analysis DataSetReference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-datasetreference.html
    /// </summary>
    public class DataSetReference
    {

        /// <summary>
        /// DataSetArn
        /// Dataset Amazon Resource Name (ARN).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSetArn")]
        public Union<string, IntrinsicFunction> DataSetArn { get; set; }

        /// <summary>
        /// DataSetPlaceholder
        /// Dataset placeholder.
        /// Required: Yes
        /// Type: String
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSetPlaceholder")]
        public Union<string, IntrinsicFunction> DataSetPlaceholder { get; set; }

    }
}
