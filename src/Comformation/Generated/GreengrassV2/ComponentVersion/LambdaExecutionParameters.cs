using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion LambdaExecutionParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html
    /// </summary>
    public class LambdaExecutionParameters
    {

        /// <summary>
        /// EventSources
        /// The list of event sources to which to subscribe to receive work messages. The Lambda function runs
        /// when it receives a message from an event source. You can subscribe this function to local
        /// publish/subscribe messages and AWS IoT Core MQTT messages.
        /// Required: No
        /// Type: List of LambdaEventSource
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EventSources")]
        public List<LambdaEventSource> EventSources { get; set; }

        /// <summary>
        /// MaxQueueSize
        /// The maximum size of the message queue for the Lambda function component. The Greengrass core device
        /// stores messages in a FIFO (first-in-first-out) queue until it can run the Lambda function to consume
        /// each message.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MaxQueueSize")]
        public Union<int, IntrinsicFunction> MaxQueueSize { get; set; }

        /// <summary>
        /// MaxInstancesCount
        /// The maximum number of instances that a non-pinned Lambda function can run at the same time.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MaxInstancesCount")]
        public Union<int, IntrinsicFunction> MaxInstancesCount { get; set; }

        /// <summary>
        /// MaxIdleTimeInSeconds
        /// The maximum amount of time in seconds that a non-pinned Lambda function can idle before the AWS IoT
        /// Greengrass Core software stops its process.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MaxIdleTimeInSeconds")]
        public Union<int, IntrinsicFunction> MaxIdleTimeInSeconds { get; set; }

        /// <summary>
        /// TimeoutInSeconds
        /// The maximum amount of time in seconds that the Lambda function can process a work item.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TimeoutInSeconds")]
        public Union<int, IntrinsicFunction> TimeoutInSeconds { get; set; }

        /// <summary>
        /// StatusTimeoutInSeconds
        /// The interval in seconds at which a pinned (also known as long-lived) Lambda function component sends
        /// status updates to the Lambda manager component.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StatusTimeoutInSeconds")]
        public Union<int, IntrinsicFunction> StatusTimeoutInSeconds { get; set; }

        /// <summary>
        /// Pinned
        /// Whether or not the Lambda function is pinned, or long-lived.
        /// A pinned Lambda function starts when the AWS IoT Greengrass Core starts and keeps running in its own
        /// container. A non-pinned Lambda function starts only when it receives a work item and exists after it
        /// idles for maxIdleTimeInSeconds. If the function has multiple work items, the AWS IoT Greengrass Core
        /// software creates multiple instances of the function.
        /// Default: true
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Pinned")]
        public Union<bool, IntrinsicFunction> Pinned { get; set; }

        /// <summary>
        /// InputPayloadEncodingType
        /// The encoding type that the Lambda function supports.
        /// Default: json
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InputPayloadEncodingType")]
        public Union<string, IntrinsicFunction> InputPayloadEncodingType { get; set; }

        /// <summary>
        /// ExecArgs
        /// The list of arguments to pass to the Lambda function when it runs.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ExecArgs")]
        public List<Union<string, IntrinsicFunction>> ExecArgs { get; set; }

        /// <summary>
        /// EnvironmentVariables
        /// The map of environment variables that are available to the Lambda function when it runs.
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EnvironmentVariables")]
        public Dictionary<string, Union<string, IntrinsicFunction>> EnvironmentVariables { get; set; }

        /// <summary>
        /// LinuxProcessParams
        /// The parameters for the Linux process that contains the Lambda function.
        /// Required: No
        /// Type: LambdaLinuxProcessParams
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LinuxProcessParams")]
        public LambdaLinuxProcessParams LinuxProcessParams { get; set; }

    }
}
