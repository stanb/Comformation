using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// AWS::QuickSight::Template TemplateSourceEntity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceentity.html
    /// </summary>
    public class TemplateSourceEntity
    {

        /// <summary>
        /// SourceAnalysis
        /// The source analysis, if it is based on an analysis.
        /// Required: No
        /// Type: TemplateSourceAnalysis
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceAnalysis")]
        public TemplateSourceAnalysis SourceAnalysis { get; set; }

        /// <summary>
        /// SourceTemplate
        /// The source template, if it is based on an template.
        /// Required: No
        /// Type: TemplateSourceTemplate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceTemplate")]
        public TemplateSourceTemplate SourceTemplate { get; set; }

    }
}
