using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.NamedQuery
{
    /// <summary>
    /// AWS::Athena::NamedQuery
    /// The AWS::Athena::NamedQuery resource specifies an Amazon Athena query, where QueryString is the list of SQL
    /// query statements that comprise the query. For more information, see CreateNamedQuery in the Amazon Athena API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-namedquery.html
    /// </summary>
    public class NamedQueryResource : ResourceBase
    {
        public class NamedQueryProperties
        {
            /// <summary>
            /// Description
            /// The query description.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// QueryString
            /// The SQL query statements that comprise the query.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 262144
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> QueryString { get; set; }

            /// <summary>
            /// Database
            /// The database to which the query belongs.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Database { get; set; }

            /// <summary>
            /// Name
            /// The query name.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Athena::NamedQuery";

        public NamedQueryProperties Properties { get; } = new NamedQueryProperties();

    }
}
