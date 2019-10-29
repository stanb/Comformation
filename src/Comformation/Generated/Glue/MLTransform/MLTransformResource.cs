using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.MLTransform
{
    /// <summary>
    /// AWS::Glue::MLTransform
    /// The AWS::Glue::MLTransform is an AWS Glue resource type that manages machine learning transforms.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html
    /// </summary>
    public class MLTransformResource : ResourceBase
    {
        public class MLTransformProperties
        {
            /// <summary>
            /// Role
            /// The name or Amazon Resource Name (ARN) of the IAM role with the required permissions. The required
            /// permissions include both AWS Glue service role permissions to AWS Glue resources, and Amazon S3
            /// permissions required by the transform.
            /// 		
            /// 		 This role needs AWS Glue service role permissions to allow access to resources in AWS Glue. See
            /// Attach a Policy to IAM Users That Access AWS Glue. This role needs permission to your Amazon Simple
            /// Storage Service (Amazon S3) sources, targets, temporary directory, scripts, and any libraries used
            /// by the task run for this transform.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// MaxRetries
            /// The maximum number of times to retry after an MLTaskRun of the machine learning transform fails.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxRetries { get; set; }

            /// <summary>
            /// WorkerType
            /// The type of predefined worker that is allocated when a task of this transform runs. Accepts a value
            /// of Standard, G. 1X, or G. 2X.
            /// 	
            /// 	 	 	 	 For the Standard worker type, each worker provides 4 vCPU, 16 GB of memory and a 50GB disk,
            /// and 2 executors per worker. For the G. 1X worker type, each worker provides 4 vCPU, 16 GB of memory
            /// and a 64GB disk, and 1 executor per worker. For the G. 2X worker type, each worker provides 8 vCPU,
            /// 32 GB of memory and a 128GB disk, and 1 executor per worker.
            /// 		 		
            /// MaxCapacity is a mutually exclusive option with NumberOfWorkers and WorkerType.
            /// 		 		 		 		 		 If either NumberOfWorkers or WorkerType is set, then MaxCapacity cannot be set. If
            /// MaxCapacity is set then neither NumberOfWorkers or WorkerType can be set. If WorkerType is set, then
            /// NumberOfWorkers is required (and vice versa). MaxCapacity and NumberOfWorkers must both be at least
            /// 1.
            /// 		
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> WorkerType { get; set; }

            /// <summary>
            /// Description
            /// A user-defined, long-form description text for the machine learning transform.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Timeout
            /// The timeout in minutes of the machine learning transform.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Timeout { get; set; }

            /// <summary>
            /// TransformParameters
            /// 	
            /// The algorithm-specific parameters that are associated with the machine learning transform.
            /// Required: Yes
            /// Type: TransformParameters
            /// Update requires: No interruption
            /// </summary>
			public TransformParameters TransformParameters { get; set; }

            /// <summary>
            /// InputRecordTables
            /// A list of AWS Glue table definitions used by the transform.
            /// Required: Yes
            /// Type: InputRecordTables
            /// Update requires: Replacement
            /// </summary>
			public InputRecordTables InputRecordTables { get; set; }

            /// <summary>
            /// NumberOfWorkers
            /// The number of workers of a defined workerType that are allocated when a task of the transform runs.
            /// 		 		
            /// If WorkerType is set, then NumberOfWorkers is required (and vice versa).
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> NumberOfWorkers { get; set; }

            /// <summary>
            /// Name
            /// A user-defined name for the machine learning transform. Names are required to be unique. Name is
            /// optional:
            /// 		
            /// 		 		 		 If you supply Name, the stack cannot be repeatedly created. If Name is not provided, a
            /// randomly generated name will be used instead.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// MaxCapacity
            /// 	
            /// The number of AWS Glue data processing units (DPUs) that are allocated to task runs for this
            /// transform. You can allocate from 2 to 100 DPUs; the default is 10. A DPU is a relative measure of
            /// processing power that consists of 4 vCPUs of compute capacity and 16 GB of memory. For more
            /// information, see the AWS Glue pricing page.
            /// 		 		
            /// MaxCapacity is a mutually exclusive option with NumberOfWorkers and WorkerType.
            /// 		 		 		 		 		 If either NumberOfWorkers or WorkerType is set, then MaxCapacity cannot be set. If
            /// MaxCapacity is set then neither NumberOfWorkers or WorkerType can be set. If WorkerType is set, then
            /// NumberOfWorkers is required (and vice versa). MaxCapacity and NumberOfWorkers must both be at least
            /// 1.
            /// 		 	
            /// When the WorkerType field is set to a value other than Standard, the MaxCapacity field is set
            /// automatically and becomes read-only.
            /// 	
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> MaxCapacity { get; set; }

        }

        public string Type { get; } = "AWS::Glue::MLTransform";

        public MLTransformProperties Properties { get; } = new MLTransformProperties();

    }
}