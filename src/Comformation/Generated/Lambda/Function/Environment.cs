using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function Environment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-environment.html
    /// </summary>
    public class Environment
    {

        /// <summary>
        /// Variables
        /// Environment variable key-value pairs. For more information, see Using Lambda environment variables.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Variables")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Variables { get; set; }

    }
}
