using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS::IoTAnalytics::Pipeline
    /// The AWS::IoTAnalytics::Pipeline resource consumes messages from one or more channels and allows you to process
    /// the messages before storing them in a data store. You must specify both a channel and a datastore activity
    /// and, optionally, as many as 23 additional activities in the pipelineActivities array. For more information,
    /// see How to Use AWS IoT Analytics in the AWS IoT Analytics User Guide.
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
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_]+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PipelineName { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the pipeline.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// PipelineActivities
            /// A list of &quot;PipelineActivity&quot; objects. Activities perform transformations on your messages, such as
            /// removing, renaming or adding message attributes; filtering messages based on attribute values;
            /// invoking your Lambda functions on messages for advanced processing; or performing mathematical
            /// transformations to normalize device data.
            /// The list can be 2-25 PipelineActivity objects and must contain both a channel and a datastore
            /// activity. Each entry in the list must contain only one activity, for example:
            /// pipelineActivities = [ { &quot;channel&quot;: { . . . } }, { &quot;lambda&quot;: { . . . } }, . . . ]
            /// Required: Yes
            /// Type: List of Activity
            /// Maximum: 25
            /// Update requires: No interruption
            /// </summary>
			public List<Activity> PipelineActivities { get; set; }

        }

        public string Type { get; } = "AWS::IoTAnalytics::Pipeline";

        public PipelineProperties Properties { get; } = new PipelineProperties();

    }
}
