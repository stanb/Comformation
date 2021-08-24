using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobQueue
{
    /// <summary>
    /// AWS::Batch::JobQueue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html
    /// </summary>
    public class JobQueueResource : ResourceBase
    {
        public class JobQueueProperties
        {
            /// <summary>
            /// ComputeEnvironmentOrder
            /// The set of compute environments mapped to a job queue and their order relative to each other. The
            /// job scheduler uses this parameter to determine which compute environment should run a specific job.
            /// Compute environments must be in the VALID state before you can associate them with a job queue. You
            /// can associate up to three compute environments with a job queue. All of the compute environments
            /// must be either EC2 (EC2 or SPOT) or Fargate (FARGATE or FARGATE_SPOT); EC2 and Fargate compute
            /// environments can&#39;t be mixed.
            /// Note All compute environments that are associated with a job queue must share the same architecture.
            /// AWS Batch doesn&#39;t support mixing compute environment architecture types in a single job queue.
            /// Required: Yes
            /// Type: List of ComputeEnvironmentOrder
            /// Update requires: No interruption
            /// </summary>
            public List<ComputeEnvironmentOrder> ComputeEnvironmentOrder { get; set; }

            /// <summary>
            /// Priority
            /// The priority of the job queue. Job queues with a higher priority (or a higher integer value for the
            /// priority parameter) are evaluated first when associated with the same compute environment. Priority
            /// is determined in descending order. For example, a job queue with a priority value of 10 is given
            /// scheduling preference over a job queue with a priority value of 1. All of the compute environments
            /// must be either EC2 (EC2 or SPOT) or Fargate (FARGATE or FARGATE_SPOT); EC2 and Fargate compute
            /// environments can&#39;t be mixed.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            /// State
            /// The state of the job queue. If the job queue state is ENABLED, it is able to accept jobs. If the job
            /// queue state is DISABLED, new jobs can&#39;t be added to the queue, but jobs already in the queue can
            /// finish.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// JobQueueName
            /// The name of the job queue. Up to 128 letters (uppercase and lowercase), numbers, and underscores are
            /// allowed.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> JobQueueName { get; set; }

            /// <summary>
            /// Tags
            /// The tags applied to the job queue. For more information, see Tagging your AWS Batch resources in AWS
            /// Batch User Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Batch::JobQueue";

        public JobQueueProperties Properties { get; } = new JobQueueProperties();

    }
}
