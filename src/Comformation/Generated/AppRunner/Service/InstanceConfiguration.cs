using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service InstanceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-instanceconfiguration.html
    /// </summary>
    public class InstanceConfiguration
    {

        /// <summary>
        /// Cpu
        /// The number of CPU units reserved for each instance of your App Runner service.
        /// Default: 1 vCPU
        /// Required: No
        /// Type: String
        /// Minimum: 4
        /// Maximum: 6
        /// Pattern: 1024|2048|(1|2) vCPU
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cpu")]
        public Union<string, IntrinsicFunction> Cpu { get; set; }

        /// <summary>
        /// Memory
        /// The amount of memory, in MB or GB, reserved for each instance of your App Runner service.
        /// Default: 2 GB
        /// Required: No
        /// Type: String
        /// Minimum: 4
        /// Maximum: 4
        /// Pattern: 2048|3072|4096|(2|3|4) GB
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Memory")]
        public Union<string, IntrinsicFunction> Memory { get; set; }

        /// <summary>
        /// InstanceRoleArn
        /// The Amazon Resource Name (ARN) of an IAM role that provides permissions to your App Runner service.
        /// These are permissions that your code needs when it calls any AWS APIs.
        /// Required: No
        /// Type: String
        /// Minimum: 29
        /// Maximum: 1024
        /// Pattern:
        /// arn:(aws|aws-us-gov|aws-cn|aws-iso|aws-iso-b):iam::[0-9]{12}:(role|role\/service-role)\/[\w+=,.
        /// @\-/]{1,1000}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceRoleArn")]
        public Union<string, IntrinsicFunction> InstanceRoleArn { get; set; }

    }
}
