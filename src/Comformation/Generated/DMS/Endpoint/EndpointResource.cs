using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint
    /// The AWS::DMS::Endpoint resource creates an AWS DMS endpoint.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-endpoint.html
    /// </summary>
    public class EndpointResource : ResourceBase
    {
        public class EndpointProperties
        {
            /// <summary>
            /// KmsKeyId
            /// The AWS KMS key identifier to use to encrypt the connection parameters. If you don&#39;t specify a value
            /// for the KmsKeyId parameter, then AWS DMS uses your default encryption key. AWS KMS creates the
            /// default encryption key for your AWS account. Your AWS account has a different default encryption key
            /// for each AWS Region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

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
            /// ElasticsearchSettings
            /// Settings in JSON format for the target Elasticsearch endpoint. For more information about the
            /// available settings, see Extra Connection Attributes When Using Elasticsearch as a Target for AWS DMS
            /// in the AWS Database Migration User Guide.
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
            /// The type of engine for the endpoint. Valid values, depending on the EndPointType value, include
            /// mysql, oracle, postgres, mariadb, aurora, aurora-postgresql, redshift, s3, db2, azuredb, sybase,
            /// dynamodb, mongodb, and sqlserver.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EngineName { get; set; }

            /// <summary>
            /// DynamoDbSettings
            /// Settings in JSON format for the target Amazon DynamoDB endpoint. For more information about the
            /// available settings, see Using Object Mapping to Migrate Data to DynamoDB in the AWS Database
            /// Migration Service User Guide.
            /// Required: No
            /// Type: DynamoDbSettings
            /// Update requires: No interruption
            /// </summary>
			public DynamoDbSettings DynamoDbSettings { get; set; }

            /// <summary>
            /// KinesisSettings
            /// Settings in JSON format for the target Amazon Kinesis Data Streams endpoint. For more information
            /// about the available settings, see Using Object Mapping to Migrate Data to a Kinesis Data Stream in
            /// the AWS Database Migration User Guide.
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
            /// The Secure Sockets Layer (SSL) mode to use for the SSL connection. The SSL mode can be one of four
            /// values: none, require, verify-ca, verify-full. The default value is none.
            /// Required: No
            /// Type: String
            /// Allowed Values: none | require | verify-ca | verify-full
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
            /// Additional attributes associated with the connection.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExtraConnectionAttributes { get; set; }

            /// <summary>
            /// EndpointType
            /// The type of endpoint.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: source | target
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointType { get; set; }

            /// <summary>
            /// Tags
            /// Tags to be added to the endpoint.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// EndpointIdentifier
            /// The database endpoint identifier. Identifiers must begin with a letter; must contain only ASCII
            /// letters, digits, and hyphens; and must not end with a hyphen or contain two consecutive hyphens.
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
            /// settings, see the configuration properties section in Using MongoDB as a Target for AWS Database
            /// Migration Service in the AWS Database Migration Service User Guide.
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
