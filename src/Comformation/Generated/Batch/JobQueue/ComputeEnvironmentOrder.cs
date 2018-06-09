using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobQueue
{
    /// <summary>
    /// AWS Batch JobQueue ComputeEnvironmentOrder
    /// The ComputeEnvironmentOrder property type specifies the order in which compute environments are tried for job
    /// placement within a queue. Compute environments are tried in ascending order. For example, if two compute
    /// environments are associated with a job queue, the compute environment with a lower order integer value is
    /// tried for job placement first.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-computeenvironmentorder.html
    /// </summary>
    public class ComputeEnvironmentOrder
    {

        /// <summary>
        /// ComputeEnvironment
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// Required: yes
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("ComputeEnvironment")]
        public Union<string, IntrinsicFunction> ComputeEnvironment { get; set; }

        /// <summary>
        /// Order
        /// The order of the compute environment.
        /// Required: yes
        /// Type: Integer
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Order")]
        public Union<int, IntrinsicFunction> Order { get; set; }

    }
}
