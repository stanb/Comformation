using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobQueue
{
    /// <summary>
    /// AWS::Batch::JobQueue
    /// The AWS::Batch::JobQueue resource specifies the parameters for an AWS Batch job queue definition. For more
    /// information, see Job Queues in the AWS Batch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html
    /// </summary>
    public class JobQueueResource : ResourceBase
    {
        public class JobQueueProperties
        {
            /// <summary>
            /// ComputeEnvironmentOrder
            /// The set of compute environments mapped to a job queue and their order relative to each other. The
            /// job scheduler uses this parameter to determine which compute environment should execute a given job.
            /// Compute environments must be in the VALID state before you can associate them with a job queue. You
            /// can associate up to three compute environments with a job queue.
            /// Required: Yes
            /// Type: List of ComputeEnvironmentOrder
            /// Update requires: No interruption
            /// </summary>
			public List<ComputeEnvironmentOrder> ComputeEnvironmentOrder { get; set; }

            /// <summary>
            /// Priority
            /// The priority of the job queue. Job queues with a higher priority (or a higher integer value for the
            /// priority parameter) are evaluated first when associated with the same compute environment. Priority
            /// is determined in descending order, for example, a job queue with a priority value of 10 is given
            /// scheduling preference over a job queue with a priority value of 1.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            /// State
            /// The state of the job queue. If the job queue state is ENABLED, it is able to accept jobs.
            /// Required: No
            /// Type: String
            /// Allowed Values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// JobQueueName
            /// The name of the job queue.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> JobQueueName { get; set; }

        }

        public string Type { get; } = "AWS::Batch::JobQueue";

        public JobQueueProperties Properties { get; } = new JobQueueProperties();

    }
}
