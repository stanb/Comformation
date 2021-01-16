using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConnectionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-connectionconfiguration.html
    /// </summary>
    public class ConnectionConfiguration
    {

        /// <summary>
        /// DatabaseHost
        /// The name of the host for the database. Can be either a string (host. subdomain. domain. tld) or an
        /// IPv4 or IPv6 address.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 253
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseHost")]
        public Union<string, IntrinsicFunction> DatabaseHost { get; set; }

        /// <summary>
        /// DatabasePort
        /// The port that the database uses for connections.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabasePort")]
        public Union<int, IntrinsicFunction> DatabasePort { get; set; }

        /// <summary>
        /// DatabaseName
        /// The name of the database containing the document data.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// TableName
        /// The name of the table that contains the document data.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) of credentials stored in AWS Secrets Manager. The credentials should
        /// be a user/password pair. For more information, see Using a Database Data Source. For more
        /// information about AWS Secrets Manager, see What Is AWS Secrets Manager in the AWS Secrets Manager
        /// user guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1284
        /// Pattern: arn:[a-z0-9-\. ]{1,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[^/].
        /// {0,1023}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

    }
}
