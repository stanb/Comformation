using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationOutput
    /// The AWS::KinesisAnalytics::ApplicationOutput resource adds an external destination to your Amazon Kinesis Data
    /// Analytics application. For more information, see AddApplicationOutput in the Amazon Kinesis Data Analytics
    /// Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationoutput.html
    /// </summary>
    public class ApplicationOutputResource : ResourceBase
    {
        public class ApplicationOutputProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of the application to which you want to add the output configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Output
            /// An array of objects, each describing one output configuration.
            /// Required: Yes
            /// Type: Kinesis Data Analytics ApplicationOutput Output
            /// Update requires: No interruption
            /// </summary>
			public Output Output { get; set; }

        }
    
        public string Type { get; } = "AWS::KinesisAnalytics::ApplicationOutput";
        
        public ApplicationOutputProperties Properties { get; } = new ApplicationOutputProperties();

    }
}
