using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.Map
{
    /// <summary>
    /// AWS::Location::Map
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-map.html
    /// </summary>
    public class MapResource : ResourceBase
    {
        public class MapProperties
        {
            /// <summary>
            /// Configuration
            /// Specifies the map style selected from an available data provider.
            /// Required: Yes
            /// Type: MapConfiguration
            /// Update requires: Replacement
            /// </summary>
            public MapConfiguration Configuration { get; set; }

            /// <summary>
            /// Description
            /// An optional description for the map resource.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1000
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// MapName
            /// The name for the map resource.
            /// Requirements:
            /// Must contain only alphanumeric characters (A–Z, a–z, 0–9), hyphens (-), periods (. ), and
            /// underscores (_). Must be a unique map resource name. No spaces allowed. For example, ExampleMap.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[-. _\w]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MapName { get; set; }

            /// <summary>
            /// PricingPlan
            /// Specifies the pricing plan for your map resource.
            /// For additional details and restrictions on each pricing plan option, see the Amazon Location Service
            /// pricing page.
            /// Required: Yes
            /// Type: String
            /// Allowed values: MobileAssetManagement | MobileAssetTracking | RequestBasedUsage
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PricingPlan { get; set; }

        }

        public string Type { get; } = "AWS::Location::Map";

        public MapProperties Properties { get; } = new MapProperties();

    }

    public static class MapAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreateTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DataSource = new ResourceAttribute<Union<string, IntrinsicFunction>>("DataSource");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MapArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("MapArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> UpdateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("UpdateTime");
    }
}
