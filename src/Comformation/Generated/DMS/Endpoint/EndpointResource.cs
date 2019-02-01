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
            /// The KMS key identifier that will be used to encrypt the connection parameters. If you do not specify
            /// a value for the KmsKeyId parameter, then AWS DMS will use your default encryption key. AWS KMS
            /// creates the default encryption key for your AWS account. Your AWS account has a different default
            /// encryption key for each AWS region.
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
            /// </summary>
			public ElasticsearchSettings ElasticsearchSettings { get; set; }

            /// <summary>
            /// S3Settings
            /// Settings in JSON format for the target Amazon S3 endpoint. For more information about the available
            /// settings, see the Extra Connection Attributes section at Using Amazon S3 as a Target for AWS
            /// Database Migration Service in the AWS Database Migration Service User Guide.
            /// Required: No
            /// Type: AWS DMS Endpoint S3Settings
            /// Update requires: No interruption
            /// </summary>
			public S3Settings S3Settings { get; set; }

            /// <summary>
            /// EngineName
            /// The type of engine for the endpoint. Valid values depend on the EndPointType and include mysql,
            /// oracle, postgres, mariadb, aurora, aurora-postgresql, redshift, s3, db2, azuredb, sybase, dynamodb,
            /// mongodb, and sqlserver.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EngineName { get; set; }

            /// <summary>
            /// DynamoDbSettings
            /// Settings in JSON format for the target DynamoDB endpoint. For more information about the available
            /// settings, see the Using Object Mapping to Migrate Data to DynamoDB section at Using an Amazon
            /// DynamoDB Database as a Target for AWS Database Migration Service.
            /// Required: No
            /// Type: AWS DMS Endpoint DynamoDBSettings
            /// Update requires: No interruption
            /// </summary>
			public DynamoDbSettings DynamoDbSettings { get; set; }

            /// <summary>
            /// KinesisSettings
            /// </summary>
			public KinesisSettings KinesisSettings { get; set; }

            /// <summary>
            /// Username
            /// The user name to be used to login to the endpoint database.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Username { get; set; }

            /// <summary>
            /// SslMode
            /// The SSL mode to use for the SSL connection.
            /// SSL mode can be one of four values: none, require, verify-ca, verify-full. The default value is
            /// none.
            /// Required: No
            /// Type: String
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
            /// The type of endpoint. Valid values are source and target.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointType { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the DMS endpoint.
            /// Required: No
            /// Type: List of resource tags in key-value format
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
            /// The password to be used to login to the endpoint database. Do not use this parameter directly. Use
            /// Password as an input parameter with noEcho as shown in the Parameters. For best practices
            /// information, see Do Not Embed Credentials in Your Templates.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            /// CertificateArn
            /// The Amazon Resource Number (ARN) for the certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateArn { get; set; }

            /// <summary>
            /// MongoDbSettings
            /// Settings in JSON format for the source MongoDB endpoint. For more information about the available
            /// settings, see the Configuration Properties When Using MongoDB as a Source for AWS Database Migration
            /// Service section at Using Amazon S3 as a Target for AWS Database Migration Service.
            /// Required: No
            /// Type: AWS DMS Endpoint MongoDbSettings
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
