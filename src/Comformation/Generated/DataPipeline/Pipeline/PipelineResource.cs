using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS::DataPipeline::Pipeline
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datapipeline-pipeline.html
    /// </summary>
    public class PipelineResource : ResourceBase
    {
        public class PipelineProperties
        {
            /// <summary>
            /// Activate
            /// Indicates whether to validate and start the pipeline or stop an active pipeline. By default, the
            /// value is set to true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Activate { get; set; }

            /// <summary>
            /// Description
            /// A description of the pipeline.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// The name of the pipeline.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ParameterObjects
            /// The parameter objects used with the pipeline.
            /// Required: Yes
            /// Type: List of ParameterObject
            /// Update requires: No interruption
            /// </summary>
            public List<ParameterObject> ParameterObjects { get; set; }

            /// <summary>
            /// ParameterValues
            /// The parameter values used with the pipeline.
            /// Required: No
            /// Type: List of ParameterValue
            /// Update requires: No interruption
            /// </summary>
            public List<ParameterValue> ParameterValues { get; set; }

            /// <summary>
            /// PipelineObjects
            /// The objects that define the pipeline. These objects overwrite the existing pipeline definition. Not
            /// all objects, fields, and values can be updated. For information about restrictions, see Editing Your
            /// Pipeline in the AWS Data Pipeline Developer Guide.
            /// Required: No
            /// Type: List of PipelineObject
            /// Update requires: No interruption
            /// </summary>
            public List<PipelineObject> PipelineObjects { get; set; }

            /// <summary>
            /// PipelineTags
            /// A list of arbitrary tags (key-value pairs) to associate with the pipeline, which you can use to
            /// control permissions. For more information, see Controlling Access to Pipelines and Resources in the
            /// AWS Data Pipeline Developer Guide.
            /// Required: No
            /// Type: List of PipelineTag
            /// Update requires: No interruption
            /// </summary>
            public List<PipelineTag> PipelineTags { get; set; }

        }

        public string Type { get; } = "AWS::DataPipeline::Pipeline";

        public PipelineProperties Properties { get; } = new PipelineProperties();

    }
}
