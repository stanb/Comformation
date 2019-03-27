using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationReferenceDataSource
    /// The AWS::KinesisAnalyticsV2::ApplicationReferenceDataSource resource describes a reference data source for a
    /// SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationreferencedatasource.html
    /// </summary>
    public class ApplicationReferenceDataSourceResource : ResourceBase
    {
        public class ApplicationReferenceDataSourceProperties
        {
            /// <summary>
            /// ApplicationName
            /// The application name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// ReferenceDataSource
            /// For an SQL-based Amazon Kinesis Data Analytics application, describes the reference data source.
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
