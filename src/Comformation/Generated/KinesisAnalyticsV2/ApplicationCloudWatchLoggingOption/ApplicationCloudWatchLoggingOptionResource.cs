using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationCloudWatchLoggingOption
    /// Adds an Amazon CloudWatch log stream to monitor application configuration errors.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationcloudwatchloggingoption.html
    /// </summary>
    public class ApplicationCloudWatchLoggingOptionResource : ResourceBase
    {
        public class ApplicationCloudWatchLoggingOptionProperties
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
            /// CloudWatchLoggingOption
            /// Provides a description of Amazon CloudWatch logging options, including the log stream Amazon
            /// Resource Name (ARN).
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
