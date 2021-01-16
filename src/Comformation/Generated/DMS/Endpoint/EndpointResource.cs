using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html
    /// </summary>
    public class EndpointResource : ResourceBase
    {
        public class EndpointProperties
        {
            /// <summary>
            /// KmsKeyId
            /// An AWS KMS key identifier that is used to encrypt the connection parameters for the endpoint.
            /// If you don&#39;t specify a value for the KmsKeyId parameter, then AWS DMS uses your default encryption
            /// key.
            /// AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different
            /// default encryption key for each AWS Region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// KafkaSettings
            /// Settings in JSON format for the target Apache Kafka endpoint. For more information about the
            /// available settings, see Using Apache Kafka as a Target for AWS Database Migration Service in the AWS
            /// Database Migration Service User Guide.
            /// Required: No
            /// Type: KafkaSettings
            /// Update requires: No interruption
            /// </summary>
            public KafkaSettings KafkaSettings { get; set; }

            /// <summary>
            /// Port
            /// The port used by the endpoint database.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of the endpoint database.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// NeptuneSettings
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: NeptuneSettings
            /// Update requires: No interruption
            /// </summary>
            public NeptuneSettings NeptuneSettings { get; set; }

            /// <summary>
            /// ElasticsearchSettings
            /// Settings in JSON format for the target Elasticsearch endpoint. For more information about the
            /// available settings, see Extra Connection Attributes When Using Elasticsearch as a Target for AWS DMS
            /// in the AWS Database Migration Service User Guide.
            /// Required: No
            /// Type: ElasticsearchSettings
            /// Update requires: No interruption
            /// </summary>
            public ElasticsearchSettings ElasticsearchSettings { get; set; }

            /// <summary>
            /// S3Settings
            /// Settings in JSON format for the target Amazon S3 endpoint. For more information about the available
            /// settings, see Extra Connection Attributes When Using Amazon S3 as a Target for AWS DMS in the AWS
            /// Database Migration Service User Guide.
            /// Required: No
            /// Type: S3Settings
            /// Update requires: No interruption
            /// </summary>
            public S3Settings S3Settings { get; set; }

            /// <summary>
            /// EngineName
            /// The type of engine for the endpoint. Valid values, depending on the EndpointType value, include
            /// &quot;mysql&quot;, &quot;oracle&quot;, &quot;postgres&quot;, &quot;mariadb&quot;, &quot;aurora&quot;, &quot;aurora-postgresql&quot;, &quot;redshift&quot;, &quot;s3&quot;, &quot;db2&quot;,
            /// &quot;azuredb&quot;, &quot;sybase&quot;, &quot;dynamodb&quot;, &quot;mongodb&quot;, &quot;kinesis&quot;, &quot;kafka&quot;, &quot;elasticsearch&quot;, &quot;docdb&quot;,
            /// &quot;sqlserver&quot;, and &quot;neptune&quot;.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EngineName { get; set; }

            /// <summary>
            /// DynamoDbSettings
            /// Settings in JSON format for the target Amazon DynamoDB endpoint. For information about other
            /// available settings, see Using Object Mapping to Migrate Data to DynamoDB in the AWS Database
            /// Migration Service User Guide.
            /// Required: No
            /// Type: DynamoDbSettings
            /// Update requires: No interruption
            /// </summary>
            public DynamoDbSettings DynamoDbSettings { get; set; }

            /// <summary>
            /// KinesisSettings
            /// Settings in JSON format for the target endpoint for Amazon Kinesis Data Streams. For more
            /// information about the available settings, see Using Amazon Kinesis Data Streams as a Target for AWS
            /// Database Migration Service in the AWS Database Migration Service User Guide.
            /// Required: No
            /// Type: KinesisSettings
            /// Update requires: No interruption
            /// </summary>
            public KinesisSettings KinesisSettings { get; set; }

            /// <summary>
            /// Username
            /// The user name to be used to log in to the endpoint database.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Username { get; set; }

            /// <summary>
            /// SslMode
            /// The Secure Sockets Layer (SSL) mode to use for the SSL connection. The default is none
            /// Note When engine_name is set to S3 then the only alowed value is none
            /// Required: No
            /// Type: String
            /// Allowed values: none | require | verify-ca | verify-full
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SslMode { get; set; }

            /// <summary>
            /// ServerName
            /// The name of the server where the endpoint database resides.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServerName { get; set; }

            /// <summary>
            /// ExtraConnectionAttributes
            /// Additional attributes associated with the connection. Each attribute is specified as a name-value
            /// pair associated by an equal sign (=). Multiple attributes are separated by a semicolon (;) with no
            /// additional white space. For information on the attributes available for connecting your source or
            /// target endpoint, see Working with AWS DMS Endpoints in the AWS Database Migration Service User
            /// Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExtraConnectionAttributes { get; set; }

            /// <summary>
            /// EndpointType
            /// The type of endpoint. Valid values are source and target.
            /// Required: Yes
            /// Type: String
            /// Allowed values: source | target
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointType { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags to be assigned to the endpoint.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// EndpointIdentifier
            /// The database endpoint identifier. Identifiers must begin with a letter and must contain only ASCII
            /// letters, digits, and hyphens. They can&#39;t end with a hyphen, or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointIdentifier { get; set; }

            /// <summary>
            /// Password
            /// The password to be used to log in to the endpoint database.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            /// CertificateArn
            /// The Amazon Resource Name (ARN) for the certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateArn { get; set; }

            /// <summary>
            /// MongoDbSettings
            /// Settings in JSON format for the source MongoDB endpoint. For more information about the available
            /// settings, see Using MongoDB as a Target for AWS Database Migration Service in the AWS Database
            /// Migration Service User Guide.
            /// Required: No
            /// Type: MongoDbSettings
            /// Update requires: No interruption
            /// </summary>
            public MongoDbSettings MongoDbSettings { get; set; }

        }

        public string Type { get; } = "AWS::DMS::Endpoint";

        public EndpointProperties Properties { get; } = new EndpointProperties();

    }

    public static class EndpointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ExternalId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ExternalId");
    }
}
