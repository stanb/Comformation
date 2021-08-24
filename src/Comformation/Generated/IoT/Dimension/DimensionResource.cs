using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Dimension
{
    /// <summary>
    /// AWS::IoT::Dimension
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-dimension.html
    /// </summary>
    public class DimensionResource : ResourceBase
    {
        public class DimensionProperties
        {
            /// <summary>
            /// Name
            /// A unique identifier for the dimension.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Type
            /// Specifies the type of dimension. Supported types: TOPIC_FILTER.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// StringValues
            /// Specifies the value or list of values for the dimension. For TOPIC_FILTER dimensions, this is a
            /// pattern used to match the MQTT topic (for example, &quot;admin/#&quot;).
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> StringValues { get; set; }

            /// <summary>
            /// Tags
            /// Metadata that can be used to manage the dimension.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoT::Dimension";

        public DimensionProperties Properties { get; } = new DimensionProperties();

    }

    public static class DimensionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
