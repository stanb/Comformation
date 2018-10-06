using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS::DataPipeline::Pipeline
    /// Creates a data pipeline that you can use to automate the movement and transformation of data. In each
    /// pipeline, you define pipeline objects, such as activities, schedules, data nodes, and resources. For
    /// information about pipeline objects and components that you can use, see Pipeline Object Reference in the AWS
    /// Data Pipeline Developer Guide.
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
            /// A description for the pipeline.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement.
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// A name for the pipeline. Because AWS CloudFormation assigns each new pipeline a unique identifier,
            /// you can use the same name for multiple pipelines that are associated with your AWS account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ParameterObjects
            /// Defines the variables that are in the pipeline definition. For more information, see Creating a
            /// Pipeline Using Parameterized Templates in the AWS Data Pipeline Developer Guide.
            /// Required: No
            /// Type: AWS Data Pipeline Pipeline ParameterObjects
            /// Update requires: No interruption
            /// </summary>
			public List<ParameterObject> ParameterObjects { get; set; }

            /// <summary>
            /// ParameterValues
            /// Defines the values for the parameters that are defined in the ParameterObjects property. For more
            /// information, see Creating a Pipeline Using Parameterized Templates in the AWS Data Pipeline
            /// Developer Guide.
            /// Required: No
            /// Type: AWS Data Pipeline Pipeline ParameterValues
            /// Update requires: No interruption
            /// </summary>
			public List<ParameterValue> ParameterValues { get; set; }

            /// <summary>
            /// PipelineObjects
            /// A list of pipeline objects that make up the pipeline. For more information about pipeline objects
            /// and a description of each object, see Pipeline Object Reference in the AWS Data Pipeline Developer
            /// Guide.
            /// Required: Yes
            /// Type: A list of AWS Data Pipeline PipelineObject
            /// Update requires: Some interruptions. Not all objects, fields, and values can be updated.
            /// Restrictions on what can be updated are documented in Editing Your Pipelines in the AWS Data
            /// Pipeline Developer Guide.
            /// </summary>
			public List<PipelineObject> PipelineObjects { get; set; }

            /// <summary>
            /// PipelineTags
            /// A list of arbitrary tags (key-value pairs) to associate with the pipeline, which you can use to
            /// control permissions. For more information, see Controlling Access to Pipelines and Resources in the
            /// AWS Data Pipeline Developer Guide.
            /// Required: No
            /// Type: AWS Data Pipeline Pipeline PipelineTags
            /// Update requires: No interruption
            /// </summary>
			public List<PipelineTag> PipelineTags { get; set; }

        }
    
        public string Type { get; } = "AWS::DataPipeline::Pipeline";
        
        public PipelineProperties Properties { get; } = new PipelineProperties();

    }
}
