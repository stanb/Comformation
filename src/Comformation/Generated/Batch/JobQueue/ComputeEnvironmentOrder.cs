using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobQueue
{
    /// <summary>
    /// AWS::Batch::JobQueue ComputeEnvironmentOrder
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-computeenvironmentorder.html
    /// </summary>
    public class ComputeEnvironmentOrder
    {

        /// <summary>
        /// ComputeEnvironment
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeEnvironment")]
        public Union<string, IntrinsicFunction> ComputeEnvironment { get; set; }

        /// <summary>
        /// Order
        /// The order of the compute environment. Compute environments are tried in ascending order. For
        /// example, if two compute environments are associated with a job queue, the compute environment with a
        /// lower order integer value is tried for job placement first.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Order")]
        public Union<int, IntrinsicFunction> Order { get; set; }

    }
}
