using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT1Click.Placement
{
    /// <summary>
    /// AWS::IoT1Click::Placement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-placement.html
    /// </summary>
    public class PlacementResource : ResourceBase
    {
        public class PlacementProperties
        {
            /// <summary>
            /// PlacementName
            /// The name of the placement.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PlacementName { get; set; }

            /// <summary>
            /// ProjectName
            /// The name of the project containing the placement.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectName { get; set; }

            /// <summary>
            /// AssociatedDevices
            /// The devices to associate with the placement, as defined by a mapping of zero or more key-value pairs
            /// wherein the key is a template name and the value is a device ID.
            /// Required: No
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AssociatedDevices { get; set; }

            /// <summary>
            /// Attributes
            /// The user-defined attributes associated with the placement.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Attributes { get; set; }

        }

        public string Type { get; } = "AWS::IoT1Click::Placement";

        public PlacementProperties Properties { get; } = new PlacementProperties();

    }

    public static class PlacementAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PlacementName = new ResourceAttribute<Union<string, IntrinsicFunction>>("PlacementName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProjectName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProjectName");
    }
}
