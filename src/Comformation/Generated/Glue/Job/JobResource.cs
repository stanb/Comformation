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
            /// The role that&#39;s associated with the job.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// DefaultArguments
            /// UTF-8 string–to–UTF-8 string key-value pairs that specify the default parameters for the job.
            /// You can specify arguments here that your own job-execution script consumes, as well as arguments
            /// that AWS Glue itself consumes. For information about how to specify and consume your own Job
            /// arguments, see the Passing and Accessing Python Parameters in AWS Glue in the AWS Glue Developer
            /// Guide.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DefaultArguments { get; set; }

            /// <summary>
            /// Connections
            /// The connections that are used by the job.
            /// Required: No
            /// Type: ConnectionsList
            /// Update requires: No interruption
            /// </summary>
			public ConnectionsList Connections { get; set; }

            /// <summary>
            /// MaxRetries
            /// The maximum number of times to retry this job if it fails.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> MaxRetries { get; set; }

            /// <summary>
            /// Description
            /// The description of the job.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// LogUri
            /// The location of the logs for the job.
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
            /// The execution property of the job, which specifies the maximum number of concurrent runs that are
            /// allowed for the job.
            /// Required: No
            /// Type: ExecutionProperty
            /// Update requires: No interruption
            /// </summary>
			public ExecutionProperty ExecutionProperty { get; set; }

            /// <summary>
            /// Name
            /// The name of the job. It must match the single-line string pattern:
            /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
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
