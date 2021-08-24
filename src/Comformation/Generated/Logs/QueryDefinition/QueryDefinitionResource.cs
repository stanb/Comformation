using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.QueryDefinition
{
    /// <summary>
    /// AWS::Logs::QueryDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-querydefinition.html
    /// </summary>
    public class QueryDefinitionResource : ResourceBase
    {
        public class QueryDefinitionProperties
        {
            /// <summary>
            /// Name
            /// A name for the query definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// QueryString
            /// The query string to use for this query definition. For more information, see CloudWatch Logs
            /// Insights Query Syntax.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> QueryString { get; set; }

            /// <summary>
            /// LogGroupNames
            /// Use this parameter if you want the query to query only certain log groups.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> LogGroupNames { get; set; }

        }

        public string Type { get; } = "AWS::Logs::QueryDefinition";

        public QueryDefinitionProperties Properties { get; } = new QueryDefinitionProperties();

    }

    public static class QueryDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> QueryDefinitionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("QueryDefinitionId");
    }
}
