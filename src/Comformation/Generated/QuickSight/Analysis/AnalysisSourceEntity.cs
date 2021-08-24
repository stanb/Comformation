using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// AWS::QuickSight::Analysis AnalysisSourceEntity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourceentity.html
    /// </summary>
    public class AnalysisSourceEntity
    {

        /// <summary>
        /// SourceTemplate
        /// The source template for the source entity of the analysis.
        /// Required: No
        /// Type: AnalysisSourceTemplate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceTemplate")]
        public AnalysisSourceTemplate SourceTemplate { get; set; }

    }
}
