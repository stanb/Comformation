using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule RedshiftDataParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-redshiftdataparameters.html
    /// </summary>
    public class RedshiftDataParameters
    {

        /// <summary>
        /// Database
        /// The name of the database. Required when authenticating using temporary credentials.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Database")]
        public Union<string, IntrinsicFunction> Database { get; set; }

        /// <summary>
        /// DbUser
        /// The database user name. Required when authenticating using temporary credentials.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DbUser")]
        public Union<string, IntrinsicFunction> DbUser { get; set; }

        /// <summary>
        /// SecretManagerArn
        /// The name or ARN of the secret that enables access to the database. Required when authenticating
        /// using AWS Secrets Manager.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Pattern: (^arn:aws([a-z]|\-)*:secretsmanager:[a-z0-9-. ]+:. *)|(\$(\. [\w_-]+(\[(\d+|\*)\])*)*)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretManagerArn")]
        public Union<string, IntrinsicFunction> SecretManagerArn { get; set; }

        /// <summary>
        /// Sql
        /// The SQL statement text to run.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sql")]
        public Union<string, IntrinsicFunction> Sql { get; set; }

        /// <summary>
        /// StatementName
        /// The name of the SQL statement. You can name the SQL statement when you create it to identify the
        /// query.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatementName")]
        public Union<string, IntrinsicFunction> StatementName { get; set; }

        /// <summary>
        /// WithEvent
        /// Indicates whether to send an event back to EventBridge after the SQL statement runs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WithEvent")]
        public Union<bool, IntrinsicFunction> WithEvent { get; set; }

    }
}
