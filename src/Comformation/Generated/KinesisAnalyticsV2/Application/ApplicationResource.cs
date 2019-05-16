using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application
    /// Creates an Amazon Kinesis Data Analytics application. For information about creating a Kinesis Data Analytics
    /// application, see Creating an Application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-application.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of the application.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// RuntimeEnvironment
            /// The runtime environment for the application (SQL-1. 0 or FLINK-1_6).
            /// Required: Yes
            /// Type: String
            /// Allowed Values: FLINK-1_6 | SQL-1_0
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
            /// The description of the application.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationDescription { get; set; }

            /// <summary>
            /// ServiceExecutionRole
            /// Specifies the IAM role that the application uses to access external resources.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: arn:aws:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceExecutionRole { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalyticsV2::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }
}
