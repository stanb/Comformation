using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore
    /// The AWS::IoTAnalytics::Datastore resource is a repository for messages. For more information, see How to Use
    /// AWS IoT Analytics in the AWS IoT Analytics User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html
    /// </summary>
    public class DatastoreResource : ResourceBase
    {
        public class DatastoreProperties
        {
            /// <summary>
            /// DatastoreName
            /// The name of the data store.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatastoreName { get; set; }

            /// <summary>
            /// RetentionPeriod
            /// How long, in days, message data is kept for the data store.
            /// Required: No
            /// Type: RetentionPeriod
            /// Update requires: No interruption
            /// </summary>
			public RetentionPeriod RetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the data store.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTAnalytics::Datastore";

        public DatastoreProperties Properties { get; } = new DatastoreProperties();

    }
}
