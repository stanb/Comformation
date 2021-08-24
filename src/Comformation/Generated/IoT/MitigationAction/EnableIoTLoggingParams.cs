using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.MitigationAction
{
    /// <summary>
    /// AWS::IoT::MitigationAction EnableIoTLoggingParams
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-enableiotloggingparams.html
    /// </summary>
    public class EnableIoTLoggingParams
    {

        /// <summary>
        /// LogLevel
        /// Specifies the type of information to be logged.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogLevel")]
        public Union<string, IntrinsicFunction> LogLevel { get; set; }

        /// <summary>
        /// RoleArnForLogging
        /// The Amazon Resource Name (ARN) of the IAM role used for logging.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArnForLogging")]
        public Union<string, IntrinsicFunction> RoleArnForLogging { get; set; }

    }
}
