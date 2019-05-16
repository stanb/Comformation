using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinitionVersion FunctionConfiguration
    /// The group-specific configuration settings for a Lambda function. These settings configure the function&#39;s
    /// behavior in the Greengrass group. 		 For more information, 	see Controlling Execution of Greengrass Lambda
    /// Functions by Using Group-Specific Configuration in the AWS IoT Greengrass Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html
    /// </summary>
    public class FunctionConfiguration
    {

        /// <summary>
        /// MemorySize
        /// The memory size (in KB) required by the function.
        /// 				
        /// Note This property applies only to Lambda functions that run in a Greengrass container.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MemorySize")]
        public Union<int, IntrinsicFunction> MemorySize { get; set; }

        /// <summary>
        /// Pinned
        /// Indicates whether the function is pinned (or long-lived). Pinned functions start when the core
        /// starts and process all requests in the same container. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pinned")]
        public Union<bool, IntrinsicFunction> Pinned { get; set; }

        /// <summary>
        /// ExecArgs
        /// The execution arguments.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ExecArgs")]
        public Union<string, IntrinsicFunction> ExecArgs { get; set; }

        /// <summary>
        /// Timeout
        /// The allowed execution time (in seconds) after which the function should terminate. For pinned
        /// functions, this timeout applies for each request.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<int, IntrinsicFunction> Timeout { get; set; }

        /// <summary>
        /// EncodingType
        /// The expected encoding type of the input payload for the function. Valid values are json (default)
        /// and binary.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EncodingType")]
        public Union<string, IntrinsicFunction> EncodingType { get; set; }

        /// <summary>
        /// Environment
        /// The environment configuration of the function.
        /// Required: No
        /// Type: Environment
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment { get; set; }

        /// <summary>
        /// Executable
        /// The name of the function executable.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Executable")]
        public Union<string, IntrinsicFunction> Executable { get; set; }

    }
}
