using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS::Glue::Job
    /// The AWS::Glue::Job resource specifies an AWS Glue job in the data catalog. For more information, see Adding
    /// Jobs in AWS Glue and Job Structure in the AWS Glue Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html
    /// </summary>
    public class JobResource : ResourceBase
    {
        public class JobProperties
        {
            /// <summary>
            /// Role
            /// The role that's associated with the job.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-role
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// DefaultArguments
            /// UTF-8 string–to–UTF-8 string key-value pairs that specify the default parameters for the job.
            /// You can specify arguments here that your own job-execution script consumes, as well as arguments
            /// that AWS Glue itself consumes. For information about how to specify and consume your own Job
            /// arguments, see the Passing and Accessing Python Parameters in AWS Glue in the AWS Glue Developer
            /// Guide.
            /// AWS Glue consumes the following arguments to set up the Job script environment:
            /// --scriptLocation — The Amazon S3 location where your ETL script is located (in a form like
            /// s3://path/to/my/script. py). --extra-py-files — Amazon S3 path(s) to additional Python modules that
            /// AWS Glue adds to the Python path before executing your script. Multiple values must be complete
            /// paths separated by a comma (,). Note that only pure Python modules will work currently. Extension
            /// modules written in C or other languages are not supported. --extra-jars — Amazon S3 path(s) to
            /// additional Java . jar file(s) that AWS Glue adds to the Java classpath before executing your script.
            /// Multiple values must be complete paths separated by a comma (,). --extra-files — Amazon S3 path(s)
            /// to additional files such as configuration files) that AWS Glue copies to the working directory of
            /// your script before executing it. Multiple values must be complete paths separated by a comma (,).
            /// There are several argument names used by AWS Glue internally that you should never set:
            /// --conf — Internal to AWS Glue. Do not set! --debug — Internal to AWS Glue. Do not set! --mode —
            /// Internal to AWS Glue. Do not set! --JOB_NAME — Internal to AWS Glue. Do not set!
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-defaultarguments
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DefaultArguments { get; set; }

            /// <summary>
            /// Connections
            /// The connections that are used by the job.
            /// Required: No
            /// Type: AWS Glue Job ConnectionsList
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-connections
            /// </summary>
			public Union<ConnectionsList, IntrinsicFunction> Connections { get; set; }

            /// <summary>
            /// MaxRetries
            /// The maximum number of times to retry this job if it fails.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-maxretries
            /// </summary>
			public Union<double, IntrinsicFunction> MaxRetries { get; set; }

            /// <summary>
            /// Description
            /// The description of the job.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// LogUri
            /// The location of the logs for the job.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-loguri
            /// </summary>
			public Union<string, IntrinsicFunction> LogUri { get; set; }

            /// <summary>
            /// Command
            /// The code that executes a job.
            /// Required: Yes
            /// Type: AWS Glue Job JobCommand
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-command
            /// </summary>
			public Union<JobCommand, IntrinsicFunction> Command { get; set; }

            /// <summary>
            /// AllocatedCapacity
            /// The number of capacity units that are allocated to this job.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-allocatedcapacity
            /// </summary>
			public Union<double, IntrinsicFunction> AllocatedCapacity { get; set; }

            /// <summary>
            /// ExecutionProperty
            /// The execution property of the job, which specifies the maximum number of concurrent runs that are
            /// allowed for the job.
            /// Required: No
            /// Type: AWS Glue Job ExecutionProperty
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-executionproperty
            /// </summary>
			public Union<ExecutionProperty, IntrinsicFunction> ExecutionProperty { get; set; }

            /// <summary>
            /// Name
            /// The name of the job. It must match the single-line string pattern:
            /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-job.html#cfn-glue-job-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::Job";
        
        public JobProperties Properties { get; } = new JobProperties();
    }
}
