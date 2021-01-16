using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBProxy
{
    /// <summary>
    /// AWS::RDS::DBProxy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html
    /// </summary>
    public class DBProxyResource : ResourceBase
    {
        public class DBProxyProperties
        {
            /// <summary>
            /// Auth
            /// The authorization mechanism that the proxy uses.
            /// Required: Yes
            /// Type: List of AuthFormat
            /// Update requires: No interruption
            /// </summary>
            public List<AuthFormat> Auth { get; set; }

            /// <summary>
            /// DBProxyName
            /// The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in
            /// the specified AWS Region. An identifier must begin with a letter and must contain only ASCII
            /// letters, digits, and hyphens; it can&#39;t end with a hyphen or contain two consecutive hyphens.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBProxyName { get; set; }

            /// <summary>
            /// DebugLogging
            /// Whether the proxy includes detailed information about SQL statements in its logs. This information
            /// helps you to debug issues involving SQL behavior or the performance and scalability of the proxy
            /// connections. The debug information includes the text of SQL statements that you submit through the
            /// proxy. Thus, only enable this setting when needed for debugging, and only when you have security
            /// measures in place to safeguard any sensitive information that appears in the logs.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DebugLogging { get; set; }

            /// <summary>
            /// EngineFamily
            /// The kinds of databases that the proxy can connect to. This value determines which database network
            /// protocol the proxy recognizes when it interprets network traffic to and from the database. The
            /// engine family applies to MySQL and PostgreSQL for both RDS and Aurora.
            /// Valid values: MYSQL | POSTGRESQL
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineFamily { get; set; }

            /// <summary>
            /// IdleClientTimeout
            /// The number of seconds that a connection to the proxy can be inactive before the proxy disconnects
            /// it. You can set this value higher or lower than the connection timeout limit for the associated
            /// database.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> IdleClientTimeout { get; set; }

            /// <summary>
            /// RequireTLS
            /// A Boolean parameter that specifies whether Transport Layer Security (TLS) encryption is required for
            /// connections to the proxy. By enabling this setting, you can enforce encrypted TLS connections to the
            /// proxy.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> RequireTLS { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access secrets in AWS Secrets
            /// Manager.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// An optional set of key-value pairs to associate arbitrary data of your choosing with the proxy.
            /// Required: No
            /// Type: List of TagFormat
            /// Update requires: No interruption
            /// </summary>
            public List<TagFormat> Tags { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// One or more VPC security group IDs to associate with the new proxy.
            /// If you plan to update the resource, don&#39;t specify VPC security groups in a shared VPC.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// VpcSubnetIds
            /// One or more VPC subnet IDs to associate with the new proxy.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSubnetIds { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBProxy";

        public DBProxyProperties Properties { get; } = new DBProxyProperties();

    }

    public static class DBProxyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DBProxyArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DBProxyArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
    }
}
