using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationReferenceDataSource
    /// Adds a reference data source to an existing SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationreferencedatasource.html
    /// </summary>
    public class ApplicationReferenceDataSourceResource : ResourceBase
    {
        public class ApplicationReferenceDataSourceProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of the application.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// ReferenceDataSource
            /// For an SQL-based Amazon Kinesis Data Analytics application, describes the reference data source by
            /// providing the source information (Amazon S3 bucket name and object key name), the resulting
            /// in-application table name that is created, and the necessary schema to map the data elements in the
            /// Amazon S3 object to the in-application table.
            /// Required: Yes
            /// Type: ReferenceDataSource
            /// Update requires: No interruption
            /// </summary>
			public ReferenceDataSource ReferenceDataSource { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalyticsV2::ApplicationReferenceDataSource";

        public ApplicationReferenceDataSourceProperties Properties { get; } = new ApplicationReferenceDataSourceProperties();

    }
}
