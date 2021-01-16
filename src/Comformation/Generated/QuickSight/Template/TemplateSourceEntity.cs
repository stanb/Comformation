using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceentity.html
    /// </summary>
    public class TemplateSourceEntity
    {

        /// <summary>
        /// SourceAnalysis
        /// </summary>
        [JsonProperty("SourceAnalysis")]
        public TemplateSourceAnalysis SourceAnalysis { get; set; }

        /// <summary>
        /// SourceTemplate
        /// </summary>
        [JsonProperty("SourceTemplate")]
        public TemplateSourceTemplate SourceTemplate { get; set; }

    }
}
