using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.LogStream
{
    /// <summary>
    /// AWS::Logs::LogStream
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
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: [\. \-_/#A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// LogStreamName
            /// The name of the log stream. The name must be unique within the log group.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: [^:*]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LogStreamName { get; set; }

        }

        public string Type { get; } = "AWS::Logs::LogStream";

        public LogStreamProperties Properties { get; } = new LogStreamProperties();

    }
}
