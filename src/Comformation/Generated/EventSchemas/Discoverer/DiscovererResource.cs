using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EventSchemas.Discoverer
{
    /// <summary>
    /// AWS::EventSchemas::Discoverer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html
    /// </summary>
    public class DiscovererResource : ResourceBase
    {
        public class DiscovererProperties
        {
            /// <summary>
            /// Description
            /// A description for the discoverer.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SourceArn
            /// The ARN of the event bus.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceArn { get; set; }

            /// <summary>
            /// Tags
            /// Tags associated with the resource.
            /// Required: No
            /// Type: List of TagsEntry
            /// Update requires: No interruption
            /// </summary>
            public List<TagsEntry> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EventSchemas::Discoverer";

        public DiscovererProperties Properties { get; } = new DiscovererProperties();

    }

    public static class DiscovererAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DiscovererArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DiscovererArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DiscovererId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DiscovererId");
    }
}
