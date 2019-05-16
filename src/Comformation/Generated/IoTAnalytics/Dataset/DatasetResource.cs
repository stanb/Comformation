using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset
    /// The AWS::IoTAnalytics::Dataset resource stores data retrieved from a data store by applying a &quot;queryAction&quot;
    /// (an SQL query) or a &quot;containerAction&quot; (executing a containerized application). The data set can be populated
    /// manually by calling &quot;CreateDatasetContent&quot; or automatically according to a &quot;trigger&quot; you specify. For more
    /// information, see How to Use AWS IoT Analytics in the AWS IoT Analytics User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html
    /// </summary>
    public class DatasetResource : ResourceBase
    {
        public class DatasetProperties
        {
            /// <summary>
            /// Actions
            /// The &quot;DatasetAction&quot; objects that automatically create the data set contents.
            /// Required: Yes
            /// Type: List of Action
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
			public List<Action> Actions { get; set; }

            /// <summary>
            /// DatasetName
            /// The name of the data set.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_]+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatasetName { get; set; }

            /// <summary>
            /// Triggers
            /// The &quot;DatasetTrigger&quot; objects that specify when the data set is automatically updated.
            /// Required: No
            /// Type: List of Trigger
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<Trigger> Triggers { get; set; }

            /// <summary>
            /// RetentionPeriod
            /// [Optional] How long, in days, message data is kept for the data set.
            /// Required: No
            /// Type: RetentionPeriod
            /// Update requires: No interruption
            /// </summary>
			public RetentionPeriod RetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the data set.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTAnalytics::Dataset";

        public DatasetProperties Properties { get; } = new DatasetProperties();

    }
}
