using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Detective.Graph
{
    /// <summary>
    /// AWS::Detective::Graph
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-graph.html
    /// </summary>
    public class GraphResource : ResourceBase
    {
        public class GraphProperties
        {
            /// <summary>
            /// Tags
            /// The tag values to assign to the new behavior graph.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Detective::Graph";

        public GraphProperties Properties { get; } = new GraphProperties();

    }

    public static class GraphAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
