using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.NamedQuery
{
    /// <summary>
    /// AWS::Athena::NamedQuery
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-namedquery.html
    /// </summary>
    public class NamedQueryResource : ResourceBase
    {
        public class NamedQueryProperties
        {
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
            /// WorkGroup
            /// The name of the workgroup that contains the named query.
            /// Required: No
            /// Type: String
            /// Pattern: [a-zA-Z0-9. _-]{1,128}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WorkGroup { get; set; }

        }

        public string Type { get; } = "AWS::Athena::NamedQuery";

        public NamedQueryProperties Properties { get; } = new NamedQueryProperties();

    }

    public static class NamedQueryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NamedQueryId = new ResourceAttribute<Union<string, IntrinsicFunction>>("NamedQueryId");
    }
}
