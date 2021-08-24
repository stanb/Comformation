using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// AWS::QuickSight::Analysis AnalysisSourceTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourcetemplate.html
    /// </summary>
    public class AnalysisSourceTemplate
    {

        /// <summary>
        /// DataSetReferences
        /// The dataset references of the source template of an analysis.
        /// Required: Yes
        /// Type: List of DataSetReference
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSetReferences")]
        public List<DataSetReference> DataSetReferences { get; set; }

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the source template of an analysis.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
