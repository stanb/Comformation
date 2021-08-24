using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IVS.RecordingConfiguration
{
    /// <summary>
    /// AWS::IVS::RecordingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-recordingconfiguration.html
    /// </summary>
    public class RecordingConfigurationResource : ResourceBase
    {
        public class RecordingConfigurationProperties
        {
            /// <summary>
            /// Name
            /// Recording-configuration name. The value does not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9-_]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// DestinationConfiguration
            /// A destination configuration contains information about where recorded video will be stored. See the
            /// DestinationConfiguration property type for more information.
            /// Required: Yes
            /// Type: DestinationConfiguration
            /// Update requires: Replacement
            /// </summary>
            public DestinationConfiguration DestinationConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IVS::RecordingConfiguration";

        public RecordingConfigurationProperties Properties { get; } = new RecordingConfigurationProperties();

    }

    public static class RecordingConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
    }
}
