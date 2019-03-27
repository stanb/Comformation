using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationOutput
    /// The AWS::KinesisAnalyticsV2::ApplicationOutput resource describes a SQL-based Amazon Kinesis Data Analytics
    /// application&#39;s output configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationoutput.html
    /// </summary>
    public class ApplicationOutputResource : ResourceBase
    {
        public class ApplicationOutputProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of your application (for example, sample-app).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Output
            /// Describes an SQL-based Kinesis Data Analytics application&#39;s output configuration.
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
