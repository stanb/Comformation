using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysissourceentity.html
    /// </summary>
    public class AnalysisSourceEntity
    {

        /// <summary>
        /// SourceTemplate
        /// </summary>
        [JsonProperty("SourceTemplate")]
        public AnalysisSourceTemplate SourceTemplate { get; set; }

    }
}
