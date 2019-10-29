using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore
    /// AWS::IoTAnalytics::Datastore resource is a repository for messages. For more information, see How to Use AWS
    /// IoT Analytics in the AWS IoT Analytics User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html
    /// </summary>
    public class DatastoreResource : ResourceBase
    {
        public class DatastoreProperties
        {
            /// <summary>
            /// DatastoreStorage
            /// Where data store data is stored.
            /// Required: No
            /// Type: DatastoreStorage
            /// Update requires: No interruption
            /// </summary>
			public DatastoreStorage DatastoreStorage { get; set; }

            /// <summary>
            /// DatastoreName
            /// The name of the data store.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_]+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatastoreName { get; set; }

            /// <summary>
            /// RetentionPeriod
            /// How long, in days, message data is kept for the data store. When &quot;customerManagedS3&quot; storage is
            /// selected, this parameter is ignored.
            /// Required: No
            /// Type: RetentionPeriod
            /// Update requires: No interruption
            /// </summary>
			public RetentionPeriod RetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the data store.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTAnalytics::Datastore";

        public DatastoreProperties Properties { get; } = new DatastoreProperties();

    }
}
