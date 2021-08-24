using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-datasource.html
    /// </summary>
    public class DataSourceResource : ResourceBase
    {
        public class DataSourceProperties
        {
            /// <summary>
            /// AlternateDataSourceParameters
            /// A set of alternate data source parameters that you want to share for the credentials stored with
            /// this data source. The credentials are applied in tandem with the data source parameters when you
            /// copy a data source by using a create or update request. The API operation compares the
            /// DataSourceParameters structure that&#39;s in the request with the structures in the
            /// AlternateDataSourceParameters allow list. If the structures are an exact match, the request is
            /// allowed to use the credentials from this existing data source. If the AlternateDataSourceParameters
            /// list is null, the Credentials originally used with this DataSourceParameters are automatically
            /// allowed.
            /// Required: No
            /// Type: List of DataSourceParameters
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<DataSourceParameters> AlternateDataSourceParameters { get; set; }

            /// <summary>
            /// AwsAccountId
            /// 		
            /// The AWS account; ID.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 12
            /// Maximum: 12
            /// Pattern: ^[0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// Credentials
            /// 		
            /// The credentials QuickSight that uses to connect to your underlying source. Currently, only
            /// 			credentials based on user name and password are supported.
            /// 	
            /// Required: No
            /// Type: DataSourceCredentials
            /// Update requires: No interruption
            /// </summary>
            public DataSourceCredentials Credentials { get; set; }

            /// <summary>
            /// DataSourceId
            /// 		
            /// An ID for the data source. This ID is unique per AWS Region; for each AWS account;.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DataSourceId { get; set; }

            /// <summary>
            /// DataSourceParameters
            /// 		
            /// The parameters that QuickSight uses to connect to your underlying source.
            /// 	
            /// Required: No
            /// Type: DataSourceParameters
            /// Update requires: No interruption
            /// </summary>
            public DataSourceParameters DataSourceParameters { get; set; }

            /// <summary>
            /// ErrorInfo
            /// Error information from the last update or the creation of the data source.
            /// Required: No
            /// Type: DataSourceErrorInfo
            /// Update requires: No interruption
            /// </summary>
            public DataSourceErrorInfo ErrorInfo { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// A display name for the data source.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Permissions
            /// 		
            /// A list of resource permissions on the data source.
            /// 	
            /// Required: No
            /// Type: List of ResourcePermission
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// SslProperties
            /// 		
            /// Secure Socket Layer (SSL) properties that apply when QuickSight connects to your underlying source.
            /// 	
            /// Required: No
            /// Type: SslProperties
            /// Update requires: No interruption
            /// </summary>
            public SslProperties SslProperties { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// Contains a map of the key-value pairs for the resource tag or tags assigned to the data source.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// 		
            /// The type of the data source. Currently, the supported types for this operation are: 			ATHENA,
            /// AURORA, AURORA_POSTGRESQL, AMAZON_ELASTICSEARCH, MARIADB, MYSQL, POSTGRESQL, PRESTO, REDSHIFT, S3,
            /// 			SNOWFLAKE, SPARK, SQLSERVER, TERADATA. 			Use ListDataSources to return a 			list of all data
            /// sources.
            /// 		
            /// AMAZON_ELASTICSEARCH is for Amazon managed Elasticsearch Service.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: ADOBE_ANALYTICS | AMAZON_ELASTICSEARCH | ATHENA | AURORA | AURORA_POSTGRESQL |
            /// AWS_IOT_ANALYTICS | GITHUB | JIRA | MARIADB | MYSQL | ORACLE | POSTGRESQL | PRESTO | REDSHIFT | S3 |
            /// SALESFORCE | SERVICENOW | SNOWFLAKE | SPARK | SQLSERVER | TERADATA | TIMESTREAM | TWITTER
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// VpcConnectionProperties
            /// 		
            /// Use this parameter only when you want QuickSight to use a VPC connection when connecting to 			your
            /// underlying source.
            /// 	
            /// Required: No
            /// Type: VpcConnectionProperties
            /// Update requires: No interruption
            /// </summary>
            public VpcConnectionProperties VpcConnectionProperties { get; set; }

        }

        public string Type { get; } = "AWS::QuickSight::DataSource";

        public DataSourceProperties Properties { get; } = new DataSourceProperties();

    }

    public static class DataSourceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
    }
}
