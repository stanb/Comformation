using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function ImageConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-imageconfig.html
    /// </summary>
    public class ImageConfig
    {

        /// <summary>
        /// EntryPoint
        /// Specifies the entry point to their application, which is typically the location of the runtime
        /// executable.
        /// Required: No
        /// Type: List of String
        /// Maximum: 1500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntryPoint")]
        public List<Union<string, IntrinsicFunction>> EntryPoint { get; set; }

        /// <summary>
        /// Command
        /// Specifies parameters that you want to pass in with ENTRYPOINT.
        /// Required: No
        /// Type: List of String
        /// Maximum: 1500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Command")]
        public List<Union<string, IntrinsicFunction>> Command { get; set; }

        /// <summary>
        /// WorkingDirectory
        /// Specifies the working directory.
        /// Required: No
        /// Type: String
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public Union<string, IntrinsicFunction> WorkingDirectory { get; set; }

    }
}
