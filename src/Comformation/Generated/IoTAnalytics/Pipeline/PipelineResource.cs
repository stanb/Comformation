using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS::IoTAnalytics::Pipeline
    /// The AWS::IoTAnalytics::Pipeline resource consumes messages from one or more channels and processes the
    /// messages before storing them in a data store. For more information, see How to Use AWS IoT Analytics in the
    /// AWS IoT Analytics User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-pipeline.html
    /// </summary>
    public class PipelineResource : ResourceBase
    {
        public class PipelineProperties
        {
            /// <summary>
            /// PipelineName
            /// The name of the pipeline.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PipelineName { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the pipeline.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// PipelineActivities
            /// A list of pipeline activities which perform transformations on your messages, such as removing,
            /// renaming, or adding message attributes; filtering messages based on attribute value; invoking your
            /// Lambda functions on messages for advanced processing; or performing mathematical transformation to
            /// normalize device data.
            /// Required: Yes
            /// Type: List of Activity property types
            /// Update requires: No interruption
            /// </summary>
			public List<Activity> PipelineActivities { get; set; }

        }

        public string Type { get; } = "AWS::IoTAnalytics::Pipeline";

        public PipelineProperties Properties { get; } = new PipelineProperties();

    }
}
