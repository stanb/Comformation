using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset
    /// The AWS::IoTAnalytics::Dataset resource retrieves data from a data store. For more information, see How to Use
    /// AWS IoT Analytics in the AWS IoT Analytics User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html
    /// </summary>
    public class DatasetResource : ResourceBase
    {
        public class DatasetProperties
        {
            /// <summary>
            /// Actions
            /// A list of actions that create the data set contents.
            /// Required: Yes
            /// Type: List of Action property types
            /// Update requires: No interruption
            /// </summary>
			public List<Action> Actions { get; set; }

            /// <summary>
            /// DatasetName
            /// The name of the data set.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatasetName { get; set; }

            /// <summary>
            /// Triggers
            /// A list of triggers. A trigger causes data set contents to be populated at a specified time interval
            /// or when another data set&#39;s contents are created. The list of triggers can be empty or contain up to
            /// five objects.
            /// Required: No
            /// Type: List of Trigger property types
            /// Update requires: No interruption
            /// </summary>
			public List<Trigger> Triggers { get; set; }

            /// <summary>
            /// RetentionPeriod
            /// How long, in days, message data is kept for the data set.
            /// Required: No
            /// Type: RetentionPeriod
            /// Update requires: No interruption
            /// </summary>
			public RetentionPeriod RetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the data set.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTAnalytics::Dataset";

        public DatasetProperties Properties { get; } = new DatasetProperties();

    }
}
