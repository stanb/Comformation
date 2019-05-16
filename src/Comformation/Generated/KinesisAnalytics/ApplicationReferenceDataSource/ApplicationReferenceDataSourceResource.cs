using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationReferenceDataSource
    /// Adds a reference data source to an existing application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html
    /// </summary>
    public class ApplicationReferenceDataSourceResource : ResourceBase
    {
        public class ApplicationReferenceDataSourceProperties
        {
            /// <summary>
            /// ApplicationName
            /// Name of an existing application.
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
            /// The reference data source can be an object in your Amazon S3 bucket. Amazon Kinesis Analytics reads
            /// the object and copies the data into the in-application table that is created. You provide an S3
            /// bucket, object key name, and the resulting in-application table that is created. You must also
            /// provide an IAM role with the necessary permissions that Amazon Kinesis Analytics can assume to read
            /// the object from your S3 bucket on your behalf.
            /// Required: Yes
            /// Type: ReferenceDataSource
            /// Update requires: No interruption
            /// </summary>
			public ReferenceDataSource ReferenceDataSource { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalytics::ApplicationReferenceDataSource";

        public ApplicationReferenceDataSourceProperties Properties { get; } = new ApplicationReferenceDataSourceProperties();

    }
}
