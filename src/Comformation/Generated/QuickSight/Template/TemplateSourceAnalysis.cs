using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// AWS::QuickSight::Template TemplateSourceAnalysis
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourceanalysis.html
    /// </summary>
    public class TemplateSourceAnalysis
    {

        /// <summary>
        /// DataSetReferences
        /// A structure containing information about the dataset references used as placeholders in the
        /// template.
        /// Required: Yes
        /// Type: List of DataSetReference
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSetReferences")]
        public List<DataSetReference> DataSetReferences { get; set; }

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the resource.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
