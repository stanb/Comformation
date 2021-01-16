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
            /// WebserverUrl
            /// The URL to access the Apache Airflow UI in the environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> WebserverUrl { get; set; }

            /// <summary>
            /// ExecutionRoleArn
            /// The ARN of the IAM role to use as the execution role for the environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// KmsKey
            /// The AWS Key Management Service (KMS) key to encrypt and decrypt the data in your environment. You
            /// can use an AWS KMS key managed by MWAA, or a custom KMS key (advanced).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKey { get; set; }

            /// <summary>
            /// AirflowVersion
            /// The version of Apache Airflow to use for the environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AirflowVersion { get; set; }

            /// <summary>
            /// SourceBucketArn
            /// The ARN of the S3 bucket to use to store your DAGs and associated support files for the environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SourceBucketArn { get; set; }

            /// <summary>
            /// DagS3Path
            /// The path to the DAGs folder in the S3 bucket.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DagS3Path { get; set; }

            /// <summary>
            /// PluginsS3Path
            /// The S3 URI to the plugins. zip file to use for the environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PluginsS3Path { get; set; }

            /// <summary>
            /// PluginsS3ObjectVersion
            /// The version of the plugins. zip in file to use from the S3 bucket.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PluginsS3ObjectVersion { get; set; }

            /// <summary>
            /// RequirementsS3Path
            /// The S3 URI to the requirements. txt file to use for the environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequirementsS3Path { get; set; }

            /// <summary>
            /// RequirementsS3ObjectVersion
            /// The version of the requirements. txt in file to use from the S3 bucket.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequirementsS3ObjectVersion { get; set; }

            /// <summary>
            /// EnvironmentClass
            /// The instance class to use to create the environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EnvironmentClass { get; set; }

            /// <summary>
            /// MaxWorkers
            /// The maximum number of workers to scale up to in the environment.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxWorkers { get; set; }

            /// <summary>
            /// NetworkConfiguration
            /// The VPC networking components to use for your Amazon MWAA environment. The VPC network must include
            /// at least two private subnets and one VPC security group.
            /// Required: No
            /// Type: NetworkConfiguration
            /// Update requires: Replacement
            /// </summary>
            public NetworkConfiguration NetworkConfiguration { get; set; }

            /// <summary>
            /// LoggingConfiguration
            /// Specifies the logging settings for the environment.
            /// Required: No
            /// Type: LoggingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public LoggingConfiguration LoggingConfiguration { get; set; }

            /// <summary>
            /// WeeklyMaintenanceWindowStart
            /// The day and time of the week to start weekly maintenance updates of your environment, in the format
            /// DAY:HH:MM, such as TUE:03:30. You can specify a start time in 30 minute increments only. Supported
            /// input includes the following: MON|TUE|WED|THU|FRI|SAT|SUN:([01]\\d|2[0-3]):(00|30)
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> WeeklyMaintenanceWindowStart { get; set; }

            /// <summary>
            /// WebserverAccessMode
            /// The mode to access the Apache Airflow web server. Use a public network to allow access to the Apache
            /// Airflow UI in your environment over the Internet. You can manage permissions by using an IAM policy.
            /// Choose a private network to limits access to Apache Airflow to only users within your VPC.
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
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedAt");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServiceRoleArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServiceRoleArn");
        public static readonly ResourceAttribute<LastUpdate> LastUpdate = new ResourceAttribute<LastUpdate>("LastUpdate");
    }
}
