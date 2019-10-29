using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS::Glue::Job
    /// The AWS::Glue::Job resource specifies an AWS Glue job in the data catalog. For more information, see Adding
    /// Jobs in AWS Glue and Job Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html
    /// </summary>
    public class JobResource : ResourceBase
    {
        public class JobProperties
        {
            /// <summary>
            /// Connections
            /// The connections used for this job.
            /// Required: No
            /// Type: ConnectionsList
            /// Update requires: No interruption
            /// </summary>
			public ConnectionsList Connections { get; set; }

            /// <summary>
            /// MaxRetries
            /// The maximum number of times to retry this job after a JobRun fails.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> MaxRetries { get; set; }

            /// <summary>
            /// Description
            /// A description of the job.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Timeout
            /// The job timeout in minutes. This is the maximum time that a job run can consume resources before it
            /// is terminated and enters TIMEOUT status. The default is 2,880 minutes (48 hours).
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Timeout { get; set; }

            /// <summary>
            /// AllocatedCapacity
            /// The number of capacity units that are allocated to this job.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> AllocatedCapacity { get; set; }

            /// <summary>
            /// Name
            /// The name you assign to this job definition.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Role
            /// The name or Amazon Resource Name (ARN) of the IAM role associated with this job.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// DefaultArguments
            /// The default arguments for this job, specified as name-value pairs.
            /// You can specify arguments here that your own job-execution script consumes, in addition to arguments
            /// that AWS Glue itself consumes.
            /// For information about how to specify and consume your own job arguments, see Calling AWS Glue APIs
            /// in Python in the AWS Glue Developer Guide.
            /// For information about the key-value pairs that AWS Glue consumes to set up your job, see Special
            /// Parameters Used by AWS Glue in the AWS Glue Developer Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DefaultArguments { get; set; }

            /// <summary>
            /// NotificationProperty
            /// Specifies configuration properties of a notification.
            /// Required: No
            /// Type: NotificationProperty
            /// Update requires: No interruption
            /// </summary>
			public NotificationProperty NotificationProperty { get; set; }

            /// <summary>
            /// WorkerType
            /// The type of predefined worker that is allocated when a job runs. Accepts a value of Standard, G. 1X,
            /// or G. 2X.
            /// 	
            /// 	 	 	 	 For the Standard worker type, each worker provides 4 vCPU, 16 GB of memory and a 50GB disk,
            /// and 2 executors per worker. For the G. 1X worker type, each worker maps to 1 DPU (4 vCPU, 16 GB of
            /// memory, 64 GB disk), and provides 1 executor per worker. We recommend this worker type for
            /// memory-intensive jobs. For the G. 2X worker type, each worker maps to 2 DPU (8 vCPU, 32 GB of
            /// memory, 128 GB disk), and provides 1 executor per worker. We recommend this worker type for
            /// memory-intensive jobs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> WorkerType { get; set; }

            /// <summary>
            /// LogUri
            /// This field is reserved for future use.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> LogUri { get; set; }

            /// <summary>
            /// Command
            /// The code that executes a job.
            /// Required: Yes
            /// Type: JobCommand
            /// Update requires: No interruption
            /// </summary>
			public JobCommand Command { get; set; }

            /// <summary>
            /// GlueVersion
            /// Glue version determines the versions of Apache Spark and Python that AWS Glue supports. The Python
            /// version indicates the version supported for jobs of type Spark.
            /// For more information about the available AWS Glue versions and corresponding Spark and Python
            /// versions, see Glue version in the developer guide.
            /// 	 	
            /// Jobs that are created without specifying a Glue version default to Glue 0. 9.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> GlueVersion { get; set; }

            /// <summary>
            /// ExecutionProperty
            /// The maximum number of concurrent runs that are allowed for this job.
            /// Required: No
            /// Type: ExecutionProperty
            /// Update requires: No interruption
            /// </summary>
			public ExecutionProperty ExecutionProperty { get; set; }

            /// <summary>
            /// SecurityConfiguration
            /// The name of the SecurityConfiguration structure to be used with this job.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SecurityConfiguration { get; set; }

            /// <summary>
            /// NumberOfWorkers
            /// The number of workers of a defined workerType that are allocated when a job runs.
            /// 	 		
            /// The maximum number of workers you can define are 299 for G. 1X, and 149 for G. 2X.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> NumberOfWorkers { get; set; }

            /// <summary>
            /// Tags
            /// The tags to use with this job.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// MaxCapacity
            /// 	
            /// The number of AWS Glue data processing units (DPUs) that can be allocated when this job runs. A DPU
            /// is a relative measure of processing power that consists of 4 vCPUs of compute capacity and 16 GB of
            /// memory.
            /// 	 	
            /// Do not set Max Capacity if using WorkerType and NumberOfWorkers.
            /// 	 	
            /// The value that can be allocated for MaxCapacity depends on whether you are running a Python shell
            /// job or an Apache Spark ETL job:
            /// 		 	 	 When you specify a Python shell job (JobCommand. Name=&quot;pythonshell&quot;), you can allocate either
            /// 0. 0625 or 1 DPU. The default is 0. 0625 DPU. When you specify an Apache Spark ETL job (JobCommand.
            /// Name=&quot;glueetl&quot;), you can allocate from 2 to 100 DPUs. The default is 10 DPUs. This job type cannot
            /// have a fractional DPU allocation.
            /// 		
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> MaxCapacity { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Job";

        public JobProperties Properties { get; } = new JobProperties();

    }
}
