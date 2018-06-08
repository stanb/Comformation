using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobQueue
{
    /// <summary>
    /// AWS::Batch::JobQueue
    /// The AWS::Batch::JobQueue resource defines your AWS Batch job queue. For more information, see Job Queues in
    /// the AWS Batch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html
    /// </summary>
    public class JobQueueResource : ResourceBase
    {
        public class JobQueueProperties
        {
            /// <summary>
            /// ComputeEnvironmentOrder
            /// The compute environments that are attached to the job queue and the order in which job placement is
            /// preferred. Compute environments are selected for job placement in ascending order.
            /// Required: yes
            /// Type: List of AWS Batch JobQueue ComputeEnvironmentOrder
            /// Update requires: No Interruption
            /// </summary>
			public Union<List<ComputeEnvironmentOrder>, IntrinsicFunction> ComputeEnvironmentOrder { get; set; }

            /// <summary>
            /// Priority
            /// The priority of the job queue.
            /// Required: yes
            /// Type: Integer
            /// Update requires: No Interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            /// State
            /// The status of the job queue (for example, CREATING or VALID).
            /// Required: no
            /// Type: String
            /// Update requires: No Interruption
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// JobQueueName
            /// The name of the job queue.
            /// Required: no
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> JobQueueName { get; set; }

        }
    
        public string Type { get; } = "AWS::Batch::JobQueue";
        
        public JobQueueProperties Properties { get; } = new JobQueueProperties();
    }
}
