using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application ParallelismConfiguration
    /// The ParallelismConfiguration property type specifies parameters for how a Java-based Amazon Kinesis Data
    /// Analytics application executes multiple tasks simultaneously.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-parallelismconfiguration.html
    /// </summary>
    public class ParallelismConfiguration
    {

        /// <summary>
        /// ConfigurationType
        /// Describes whether the application uses the default parallelism for the Kinesis Data Analytics
        /// service.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfigurationType")]
        public Union<string, IntrinsicFunction> ConfigurationType { get; set; }

        /// <summary>
        /// ParallelismPerKPU
        /// Describes the number of parallel tasks that a Java-based Kinesis Data Analytics application can
        /// perform per Kinesis Processing Unit (KPU) used by the application.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParallelismPerKPU")]
        public Union<int, IntrinsicFunction> ParallelismPerKPU { get; set; }

        /// <summary>
        /// AutoScalingEnabled
        /// Describes whether the Kinesis Data Analytics service can increase the parallelism of the application
        /// in response to increased throughput.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutoScalingEnabled")]
        public Union<bool, IntrinsicFunction> AutoScalingEnabled { get; set; }

        /// <summary>
        /// Parallelism
        /// Describes the initial number of parallel tasks that a Java-based Kinesis Data Analytics application
        /// can perform.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parallelism")]
        public Union<int, IntrinsicFunction> Parallelism { get; set; }

    }
}
