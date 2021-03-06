using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.LoggerDefinition
{
    /// <summary>
    /// AWS::Greengrass::LoggerDefinition LoggerDefinitionVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinition-loggerdefinitionversion.html
    /// </summary>
    public class LoggerDefinitionVersion
    {

        /// <summary>
        /// Loggers
        /// The loggers in this version.
        /// Required: Yes
        /// Type: List of Logger
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Loggers")]
        public List<Logger> Loggers { get; set; }

    }
}
