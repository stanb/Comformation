using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application
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
            /// The runtime environment for the application (SQL-1_0, FLINK-1_6, FLINK-1_8, or FLINK-1_11).
            /// Required: Yes
            /// Type: String
            /// Allowed values: FLINK-1_11 | FLINK-1_6 | FLINK-1_8 | SQL-1_0 | ZEPPELIN-FLINK-1_0
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RuntimeEnvironment { get; set; }

            /// <summary>
            /// ApplicationMode
            /// To create a Kinesis Data Analytics Studio notebook, you must set the mode to INTERACTIVE. However,
            /// for a Kinesis Data Analytics for Apache Flink application, the mode is optional.
            /// Required: No
            /// Type: String
            /// Allowed values: INTERACTIVE | STREAMING
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationMode { get; set; }

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
            /// Tags
            /// A list of one or more tags to assign to the application. A tag is a key-value pair that identifies
            /// an application. Note that the maximum number of application tags includes system tags. The maximum
            /// number of user-defined application tags is 50.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ServiceExecutionRole
            /// Specifies the IAM role that the application uses to access external resources.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: arn:. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceExecutionRole { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalyticsV2::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }
}
