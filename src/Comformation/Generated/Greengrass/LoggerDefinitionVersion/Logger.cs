using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.LoggerDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::LoggerDefinitionVersion Logger
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinitionversion-logger.html
    /// </summary>
    public class Logger
    {

        /// <summary>
        /// Space
        /// The amount of file space (in KB) to use when writing logs to the local file system. 				 This
        /// property does not apply for CloudWatch Logs.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Space")]
        public Union<int, IntrinsicFunction> Space { get; set; }

        /// <summary>
        /// Type
        /// The storage mechanism for log events. Valid values are FileSystem or AWSCloudWatch. 				 When
        /// AWSCloudWatch is used, log events are sent to CloudWatch Logs. 				 When FileSystem is used, log
        /// events are stored on the local file system.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Level
        /// The log-level threshold. Log events below this threshold are filtered out and aren&#39;t stored. 				
        /// Valid values are DEBUG, INFO (recommended), WARN, 				 ERROR, or FATAL.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Level")]
        public Union<string, IntrinsicFunction> Level { get; set; }

        /// <summary>
        /// Id
        /// A descriptive or arbitrary ID for the logger. This value must be unique within the logger definition
        /// version. Maximum length is 128 characters with pattern [a-zA-Z0-9:_-]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Component
        /// The source of the log event. Valid values are GreengrassSystem or Lambda. 				 When GreengrassSystem
        /// is used, events from Greengrass system components are logged. 				 When Lambda is used, events from
        /// user-defined Lambda functions are logged.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Component")]
        public Union<string, IntrinsicFunction> Component { get; set; }

    }
}
