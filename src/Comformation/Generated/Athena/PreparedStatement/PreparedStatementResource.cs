using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.PreparedStatement
{
    /// <summary>
    /// AWS::Athena::PreparedStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-preparedstatement.html
    /// </summary>
    public class PreparedStatementResource : ResourceBase
    {
        public class PreparedStatementProperties
        {
            /// <summary>
            /// StatementName
            /// The name of the prepared statement.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [a-zA-Z_][a-zA-Z0-9_@:]{1,256}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StatementName { get; set; }

            /// <summary>
            /// WorkGroup
            /// The workgroup to which the prepared statement belongs.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WorkGroup { get; set; }

            /// <summary>
            /// Description
            /// The description of the prepared statement.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// QueryStatement
            /// The query string for the prepared statement.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 262144
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> QueryStatement { get; set; }

        }

        public string Type { get; } = "AWS::Athena::PreparedStatement";

        public PreparedStatementProperties Properties { get; } = new PreparedStatementProperties();

    }
}
