using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.LogStream
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-logstream.html
    /// </summary>
    public class LogStreamResource : ResourceBase
    {
        public class LogStreamProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-logstream.html#cfn-logs-logstream-loggroupname
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-logstream.html#cfn-logs-logstream-logstreamname
            /// </summary>
			public Union<string, IntrinsicFunction> LogStreamName { get; set; }

        }
    
        public string Type { get; } = "AWS::Logs::LogStream";
        
        public LogStreamProperties Properties { get; } = new LogStreamProperties();
    }
}
