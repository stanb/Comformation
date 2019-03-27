using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationCloudWatchLoggingOption
    /// The AWS::KinesisAnalyticsV2::ApplicationCloudWatchLoggingOption resource to add an Amazon CloudWatch log
    /// stream to monitor application configuration errors. For more information, see CloudWatchLoggingOption in the
    /// Amazon Kinesis Data Analytics Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationcloudwatchloggingoption.html
    /// </summary>
    public class ApplicationCloudWatchLoggingOptionResource : ResourceBase
    {
        public class ApplicationCloudWatchLoggingOptionProperties
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
            /// CloudWatchLoggingOption
            /// Use this parameter to configure an Amazon CloudWatch log stream to monitor application configuration
            /// errors.
            /// Required: Yes
            /// Type: CloudWatchLoggingOption
            /// Update requires: No interruption
            /// </summary>
			public CloudWatchLoggingOption CloudWatchLoggingOption { get; set; }

        }

        public string Type { get; } = "AWS::KinesisAnalyticsV2::ApplicationCloudWatchLoggingOption";

        public ApplicationCloudWatchLoggingOptionProperties Properties { get; } = new ApplicationCloudWatchLoggingOptionProperties();

    }
}
