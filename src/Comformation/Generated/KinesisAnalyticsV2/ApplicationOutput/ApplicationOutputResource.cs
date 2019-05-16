using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationOutput
    /// Adds an external destination to your SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationoutput.html
    /// </summary>
    public class ApplicationOutputResource : ResourceBase
    {
        public class ApplicationOutputProperties
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
            /// Output
            /// Describes an SQL-based Amazon Kinesis Data Analytics application&#39;s output configuration, in which
            /// you identify an in-application stream and a destination where you want the in-application stream
            /// data to be written. The destination can be a Kinesis data stream or a Kinesis Data Firehose delivery
            /// stream.
            /// Required: Yes
            /// Type: Output
            /// Update requires: No interruption
            /// </summary>
			public Output Output { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalyticsV2::ApplicationOutput";

        public ApplicationOutputProperties Properties { get; } = new ApplicationOutputProperties();

    }
}
