using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-config.html
    /// </summary>
    public class ConfigResource : ResourceBase
    {
        public class ConfigProperties
        {
            /// <summary>
            /// Name
            /// The name of the config object.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Tags
            /// Tags assigned to a resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ConfigData
            /// Object containing the parameters of a config. Only one subtype may be specified per config. See the
            /// subtype definitions for a description of each config subtype.
            /// Required: Yes
            /// Type: ConfigData
            /// Update requires: No interruption
            /// </summary>
            public ConfigData ConfigData { get; set; }

        }

        public string Type { get; } = "AWS::GroundStation::Config";

        public ConfigProperties Properties { get; } = new ConfigProperties();

    }

    public static class ConfigAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Type = new ResourceAttribute<Union<string, IntrinsicFunction>>("Type");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
