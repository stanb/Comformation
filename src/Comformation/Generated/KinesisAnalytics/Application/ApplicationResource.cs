using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// AWS::KinesisAnalytics::Application
    /// The AWS::KinesisAnalytics::Application resource creates an Amazon Kinesis Data Analytics application. For more
    /// information, see the Amazon Kinesis Data Analytics Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of your Amazon Kinesis Data Analytics application.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-applicationname
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Inputs
            /// Use this parameter to configure the application input.
            /// Required: Yes
            /// Type: List of Kinesis Data Analytics Application Input
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-inputs
            /// </summary>
			public Union<List<Input>, IntrinsicFunction> Inputs { get; set; }

            /// <summary>
            /// ApplicationDescription
            /// The summary description of the application.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-applicationdescription
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationDescription { get; set; }

            /// <summary>
            /// ApplicationCode
            /// One or more SQL statements that read input data, transform it, and generate output.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-applicationcode
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationCode { get; set; }

        }
    
        public string Type { get; } = "AWS::KinesisAnalytics::Application";
        
        public ApplicationProperties Properties { get; } = new ApplicationProperties();
    }
}
