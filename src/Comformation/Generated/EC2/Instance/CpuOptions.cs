using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance CpuOptions
    /// The CPU options for the instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-cpuoptions.html
    /// </summary>
    public class CpuOptions
    {

        /// <summary>
        /// CoreCount
        /// The number of CPU cores for the instance.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CoreCount")]
        public Union<int, IntrinsicFunction> CoreCount { get; set; }

        /// <summary>
        /// ThreadsPerCore
        /// The number of threads per CPU core.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThreadsPerCore")]
        public Union<int, IntrinsicFunction> ThreadsPerCore { get; set; }

    }
}
