using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobQueue
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html
    /// </summary>
    public class JobQueueResource : ResourceBase
    {
        public class JobQueueProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-computeenvironmentorder
            /// </summary>
			public Union<List<ComputeEnvironmentOrder>, IntrinsicFunction> ComputeEnvironmentOrder { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-priority
            /// </summary>
			public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-state
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-jobqueuename
            /// </summary>
			public Union<string, IntrinsicFunction> JobQueueName { get; set; }

        }
    
        public string Type { get; } = "AWS::Batch::JobQueue";
        
        public JobQueueProperties Properties { get; } = new JobQueueProperties();
    }
}
