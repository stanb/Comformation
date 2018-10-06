using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.LogStream
{
    /// <summary>
    /// AWS::Logs::LogStream
    /// The AWS::Logs::LogStream resource creates an Amazon CloudWatch Logs log stream in a log group. A log stream
    /// represents the sequence of events coming from an application instance or resource that you are monitoring. For
    /// more information, see Monitoring Log Files in the Amazon CloudWatch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-logstream.html
    /// </summary>
    public class LogStreamResource : ResourceBase
    {
        public class LogStreamProperties
        {
            /// <summary>
            /// LogGroupName
            /// The name of the log group where the log stream is created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// LogStreamName
            /// The name of the log stream to create. The name must be unique within the log group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogStreamName { get; set; }

        }
    
        public string Type { get; } = "AWS::Logs::LogStream";
        
        public LogStreamProperties Properties { get; } = new LogStreamProperties();

    }
}
