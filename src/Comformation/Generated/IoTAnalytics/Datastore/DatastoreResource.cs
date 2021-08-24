using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore
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
            /// FileFormatConfiguration
            /// Contains the configuration information of file formats. AWS IoT Analytics data stores support JSON
            /// and Parquet.
            /// The default file format is JSON. You can specify only one format.
            /// You can&#39;t change the file format after you create the data store.
            /// Required: No
            /// Type: FileFormatConfiguration
            /// Update requires: No interruption
            /// </summary>
            public FileFormatConfiguration FileFormatConfiguration { get; set; }

            /// <summary>
            /// DatastorePartitions
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: DatastorePartitions
            /// Update requires: No interruption
            /// </summary>
            public DatastorePartitions DatastorePartitions { get; set; }

            /// <summary>
            /// DatastoreName
            /// The name of the data store.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: (^(?!_{2}))(^[a-zA-Z0-9_]+$)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DatastoreName { get; set; }

            /// <summary>
            /// RetentionPeriod
            /// How long, in days, message data is kept for the data store. When customerManagedS3 storage is
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
