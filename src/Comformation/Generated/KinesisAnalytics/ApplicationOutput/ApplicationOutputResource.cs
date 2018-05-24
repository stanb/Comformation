using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationoutput.html
    /// </summary>
    public class ApplicationOutputResource : ResourceBase
    {
        public class ApplicationOutputProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationoutput.html#cfn-kinesisanalytics-applicationoutput-applicationname
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationoutput.html#cfn-kinesisanalytics-applicationoutput-output
            /// </summary>
			public Union<Output, IntrinsicFunction> Output { get; set; }

        }
    
        public string Type { get; } = "AWS::KinesisAnalytics::ApplicationOutput";
        
        public ApplicationOutputProperties Properties { get; } = new ApplicationOutputProperties();
    }
}
