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
            /// You can specify arguments here that your own job-execution script consumes, as well as arguments
            /// that AWS Glue itself consumes.
            /// For information about how to specify and consume your own Job arguments, see the Calling AWS Glue
            /// APIs in Python topic in the developer guide.
            /// For information about the key-value pairs that AWS Glue consumes to set up your job, see the Special
            /// Parameters Used by AWS Glue topic in the developer guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DefaultArguments { get; set; }

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
            /// AllocatedCapacity
            /// The number of capacity units that are allocated to this job.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> AllocatedCapacity { get; set; }

            /// <summary>
            /// ExecutionProperty
            /// The maximum number of concurrent runs that are allowed for this job.
            /// Required: No
            /// Type: ExecutionProperty
            /// Update requires: No interruption
            /// </summary>
			public ExecutionProperty ExecutionProperty { get; set; }

            /// <summary>
            /// Name
            /// The name you assign to this job definition.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Job";

        public JobProperties Properties { get; } = new JobProperties();

    }
}
