using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// AWS::KinesisAnalytics::Application
    /// The AWS::KinesisAnalytics::Application resource creates an Amazon Kinesis Data Analytics application. For more
    /// information, see the Amazon Kinesis Data Analytics Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// Name of your Amazon Kinesis Analytics application (for example, sample-app).
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Inputs
            /// Use this parameter to configure the application input.
            /// You can configure your application to receive input from a single streaming source. In this
            /// configuration, you map this streaming source to an in-application stream that is created. Your
            /// application code can then query the in-application stream like a table (you can think of it as a
            /// constantly updating table).
            /// For the streaming source, you provide its Amazon Resource Name (ARN) and format of data on the
            /// stream (for example, JSON, CSV, etc. ). You also must provide an IAM role that Amazon Kinesis
            /// Analytics can assume to read this stream on your behalf.
            /// To create the in-application stream, you need to specify a schema to transform your data into a
            /// schematized version used in SQL. In the schema, you provide the necessary mapping of the data
            /// elements in the streaming source to record columns in the in-app stream.
            /// Required: Yes
            /// Type: List of Input
            /// Update requires: No interruption
            /// </summary>
			public List<Input> Inputs { get; set; }

            /// <summary>
            /// ApplicationDescription
            /// Summary description of the application.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationDescription { get; set; }

            /// <summary>
            /// ApplicationCode
            /// One or more SQL statements that read input data, transform it, and generate output. For example, you
            /// can write a SQL statement that reads data from one in-application stream, generates a running
            /// average of the number of advertisement clicks by vendor, and insert resulting rows in another
            /// in-application stream using pumps. For more information about the typical pattern, see Application
            /// Code.
            /// You can provide such series of SQL statements, where output of one statement can be used as the
            /// input for the next statement. You store intermediate results by creating in-application streams and
            /// pumps.
            /// Note that the application code must create the streams with names specified in the Outputs. For
            /// example, if your Outputs defines output streams named ExampleOutputStream1 and ExampleOutputStream2,
            /// then your application code must create these streams.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 102400
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationCode { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalytics::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }
}
