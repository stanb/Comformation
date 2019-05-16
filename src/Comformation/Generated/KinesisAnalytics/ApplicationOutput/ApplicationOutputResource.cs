using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationOutput
    /// Adds an external destination to your Amazon Kinesis Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationoutput.html
    /// </summary>
    public class ApplicationOutputResource : ResourceBase
    {
        public class ApplicationOutputProperties
        {
            /// <summary>
            /// ApplicationName
            /// Name of the application to which you want to add the output configuration.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Output
            /// An array of objects, each describing one output configuration. In the output configuration, you
            /// specify the name of an in-application stream, a destination (that is, an Amazon Kinesis stream, an
            /// Amazon Kinesis Firehose delivery stream, or an AWS Lambda function), and record the formation to use
            /// when writing to the destination.
            /// Required: Yes
            /// Type: Output
            /// Update requires: No interruption
            /// </summary>
			public Output Output { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalytics::ApplicationOutput";

        public ApplicationOutputProperties Properties { get; } = new ApplicationOutputProperties();

    }
}
