using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application
    /// The AWS::KinesisAnalyticsV2::Application resource creates an Amazon Kinesis Data Analytics application. For
    /// more information, see the Amazon Kinesis Data Analytics Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of your Amazon Kinesis Analytics application (for example, sample-app).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// RuntimeEnvironment
            /// The runtime environment for the application (SQL-1. 0 or FLINK-1_6).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RuntimeEnvironment { get; set; }

            /// <summary>
            /// ApplicationConfiguration
            /// Use this parameter to configure the application.
            /// Required: No
            /// Type: ApplicationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public ApplicationConfiguration ApplicationConfiguration { get; set; }

            /// <summary>
            /// ApplicationDescription
            /// A summary description of the application.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationDescription { get; set; }

            /// <summary>
            /// ServiceExecutionRole
            /// The IAM role used by the application to access Kinesis data streams, Kinesis Data Firehose delivery
            /// streams, Amazon S3 objects, and other external resources.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceExecutionRole { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalyticsV2::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }
}
