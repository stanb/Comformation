using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.LoggerDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::LoggerDefinitionVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-loggerdefinitionversion.html
    /// </summary>
    public class LoggerDefinitionVersionResource : ResourceBase
    {
        public class LoggerDefinitionVersionProperties
        {
            /// <summary>
            /// LoggerDefinitionId
            /// The ID of the logger definition associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LoggerDefinitionId { get; set; }

            /// <summary>
            /// Loggers
            /// The loggers in this version.
            /// Required: Yes
            /// Type: List of Logger
            /// Update requires: Replacement
            /// </summary>
            public List<Logger> Loggers { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::LoggerDefinitionVersion";

        public LoggerDefinitionVersionProperties Properties { get; } = new LoggerDefinitionVersionProperties();

    }
}
