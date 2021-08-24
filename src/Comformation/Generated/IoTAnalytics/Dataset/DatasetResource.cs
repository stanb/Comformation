using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-dataset.html
    /// </summary>
    public class DatasetResource : ResourceBase
    {
        public class DatasetProperties
        {
            /// <summary>
            /// Actions
            /// The DatasetAction objects that automatically create the dataset contents.
            /// Required: Yes
            /// Type: List of Action
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<Action> Actions { get; set; }

            /// <summary>
            /// LateDataRules
            /// A list of data rules that send notifications to CloudWatch, when data arrives late. To specify
            /// lateDataRules, the dataset must use a DeltaTimer filter.
            /// Required: No
            /// Type: List of LateDataRule
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<LateDataRule> LateDataRules { get; set; }

            /// <summary>
            /// DatasetName
            /// The name of the dataset.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: (^(?!_{2}))(^[a-zA-Z0-9_]+$)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DatasetName { get; set; }

            /// <summary>
            /// ContentDeliveryRules
            /// When dataset contents are created they are delivered to destinations specified here.
            /// Required: No
            /// Type: List of DatasetContentDeliveryRule
            /// Maximum: 20
            /// Update requires: No interruption
            /// </summary>
            public List<DatasetContentDeliveryRule> ContentDeliveryRules { get; set; }

            /// <summary>
            /// Triggers
            /// The DatasetTrigger objects that specify when the dataset is automatically updated.
            /// Required: No
            /// Type: List of Trigger
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
            public List<Trigger> Triggers { get; set; }

            /// <summary>
            /// VersioningConfiguration
            /// Optional. How many versions of dataset contents are kept. If not specified or set to null, only the
            /// latest version plus the latest succeeded version (if they are different) are kept for the time
            /// period specified by the retentionPeriod parameter. For more information, see Keeping Multiple
            /// Versions of AWS IoT Analytics datasets in the AWS IoT Analytics User Guide.
            /// Required: No
            /// Type: VersioningConfiguration
            /// Update requires: No interruption
            /// </summary>
            public VersioningConfiguration VersioningConfiguration { get; set; }

            /// <summary>
            /// RetentionPeriod
            /// Optional. How long, in days, message data is kept for the dataset.
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
