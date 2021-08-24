using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html
    /// </summary>
    public class EnvironmentResource : ResourceBase
    {
        public class EnvironmentProperties
        {
            /// <summary>
            /// Name
            /// The name of your Amazon MWAA environment.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ExecutionRoleArn
            /// The Amazon Resource Name (ARN) of the execution role in IAM that allows MWAA to access AWS resources
            /// in your environment. For example, arn:aws:iam::123456789:role/my-execution-role. To learn more, see
            /// Amazon MWAA Execution role.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// KmsKey
            /// The AWS Key Management Service (KMS) key to encrypt and decrypt the data in your environment. You
            /// can use an AWS KMS key managed by MWAA, or a customer-managed KMS key (advanced).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKey { get; set; }

            /// <summary>
            /// AirflowVersion
            /// The version of Apache Airflow to use for the environment. If no value is specified, defaults to the
            /// latest version. Valid values: 2. 0. 2, 1. 10. 12.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AirflowVersion { get; set; }

            /// <summary>
            /// SourceBucketArn
            /// The Amazon Resource Name (ARN) of the Amazon S3 bucket where your DAG code and supporting files are
            /// stored. For example, arn:aws:s3:::my-airflow-bucket-unique-name. To learn more, see Create an Amazon
            /// S3 bucket for Amazon MWAA.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SourceBucketArn { get; set; }

            /// <summary>
            /// DagS3Path
            /// The relative path to the DAGs folder on your Amazon S3 bucket. For example, dags. To learn more, see
            /// Adding or updating DAGs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DagS3Path { get; set; }

            /// <summary>
            /// PluginsS3Path
            /// The relative path to the plugins. zip file on your Amazon S3 bucket. For example, plugins. zip. To
            /// learn more, see Installing custom plugins.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PluginsS3Path { get; set; }

            /// <summary>
            /// PluginsS3ObjectVersion
            /// The version of the plugins. zip file on your Amazon S3 bucket. To learn more, see Installing custom
            /// plugins.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PluginsS3ObjectVersion { get; set; }

            /// <summary>
            /// RequirementsS3Path
            /// The relative path to the requirements. txt file on your Amazon S3 bucket. For example, requirements.
            /// txt. To learn more, see Installing Python dependencies.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequirementsS3Path { get; set; }

            /// <summary>
            /// RequirementsS3ObjectVersion
            /// The version of the requirements. txt file on your Amazon S3 bucket. To learn more, see Installing
            /// Python dependencies.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequirementsS3ObjectVersion { get; set; }

            /// <summary>
            /// AirflowConfigurationOptions
            /// A list of key-value pairs containing the Airflow configuration options for your environment. For
            /// example, core. default_timezone: utc. To learn more, see Apache Airflow configuration options.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AirflowConfigurationOptions { get; set; }

            /// <summary>
            /// EnvironmentClass
            /// The environment class type. Valid values: mw1. small, mw1. medium, mw1. large. To learn more, see
            /// Amazon MWAA environment class.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EnvironmentClass { get; set; }

            /// <summary>
            /// MaxWorkers
            /// The maximum number of workers that you want to run in your environment. MWAA scales the number of
            /// Apache Airflow workers up to the number you specify in the MaxWorkers field. For example, 20. When
            /// there are no more tasks running, and no more in the queue, MWAA disposes of the extra workers
            /// leaving the one worker that is included with your environment, or the number you specify in
            /// MinWorkers.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxWorkers { get; set; }

            /// <summary>
            /// MinWorkers
            /// The minimum number of workers that you want to run in your environment. MWAA scales the number of
            /// Apache Airflow workers up to the number you specify in the MaxWorkers field. When there are no more
            /// tasks running, and no more in the queue, MWAA disposes of the extra workers leaving the worker count
            /// you specify in the MinWorkers field. For example, 2.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MinWorkers { get; set; }

            /// <summary>
            /// Schedulers
            /// The number of schedulers that you want to run in your environment. Valid values:
            /// v2. 0. 2 - Accepts between 2 to 5. Defaults to 2. v1. 10. 12 - Accepts 1.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Schedulers { get; set; }

            /// <summary>
            /// NetworkConfiguration
            /// The VPC networking components used to secure and enable network traffic between the AWS resources
            /// for your environment. To learn more, see About networking on Amazon MWAA.
            /// Required: No
            /// Type: NetworkConfiguration
            /// Update requires: No interruption
            /// </summary>
            public NetworkConfiguration NetworkConfiguration { get; set; }

            /// <summary>
            /// LoggingConfiguration
            /// The Apache Airflow logs being sent to CloudWatch Logs: DagProcessingLogs, SchedulerLogs, TaskLogs,
            /// WebserverLogs, WorkerLogs.
            /// Required: No
            /// Type: LoggingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public LoggingConfiguration LoggingConfiguration { get; set; }

            /// <summary>
            /// WeeklyMaintenanceWindowStart
            /// The day and time of the week to start weekly maintenance updates of your environment in the
            /// following format: DAY:HH:MM. For example: TUE:03:30. You can specify a start time in 30 minute
            /// increments only. Supported input includes the following:
            /// MON|TUE|WED|THU|FRI|SAT|SUN:([01]\\d|2[0-3]):(00|30)
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> WeeklyMaintenanceWindowStart { get; set; }

            /// <summary>
            /// WebserverAccessMode
            /// The Apache Airflow Web server access mode. To learn more, see Apache Airflow access modes. Valid
            /// values: PRIVATE_ONLY or PUBLIC_ONLY.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> WebserverAccessMode { get; set; }

        }

        public string Type { get; } = "AWS::MWAA::Environment";

        public EnvironmentProperties Properties { get; } = new EnvironmentProperties();

    }

    public static class EnvironmentAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> WebserverUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("WebserverUrl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoggingConfiguration_DagProcessingLogs_CloudWatchLogGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoggingConfiguration", "DagProcessingLogs", "CloudWatchLogGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoggingConfiguration_SchedulerLogs_CloudWatchLogGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoggingConfiguration", "SchedulerLogs", "CloudWatchLogGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoggingConfiguration_WebserverLogs_CloudWatchLogGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoggingConfiguration", "WebserverLogs", "CloudWatchLogGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoggingConfiguration_WorkerLogs_CloudWatchLogGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoggingConfiguration", "WorkerLogs", "CloudWatchLogGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoggingConfiguration_TaskLogs_CloudWatchLogGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoggingConfiguration", "TaskLogs", "CloudWatchLogGroupArn");
    }
}
