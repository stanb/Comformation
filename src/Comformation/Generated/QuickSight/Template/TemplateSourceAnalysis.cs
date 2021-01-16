using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceanalysis.html
    /// </summary>
    public class TemplateSourceAnalysis
    {

        /// <summary>
        /// DataSetReferences
        /// </summary>
        [JsonProperty("DataSetReferences")]
        public List<DataSetReference> DataSetReferences { get; set; }

        /// <summary>
        /// Arn
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
