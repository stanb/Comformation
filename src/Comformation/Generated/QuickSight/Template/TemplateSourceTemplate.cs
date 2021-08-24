using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// AWS::QuickSight::Template TemplateSourceTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templatesourcetemplate.html
    /// </summary>
    public class TemplateSourceTemplate
    {

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
