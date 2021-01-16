using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConvert.Preset
{
    /// <summary>
    /// AWS::MediaConvert::Preset
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-preset.html
    /// </summary>
    public class PresetResource : ResourceBase
    {
        public class PresetProperties
        {
            /// <summary>
            /// Category
            /// The new category for the preset, if you are changing it.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Category { get; set; }

            /// <summary>
            /// Description
            /// The new description for the preset, if you are changing it.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SettingsJson
            /// Specify, in JSON format, the transcoding job settings for this output preset. This specification
            /// must conform to the AWS Elemental MediaConvert job validation. For information about forming this
            /// specification, see the Remarks section later in this topic.
            /// For more information about MediaConvert output presets, see Working with AWS Elemental MediaConvert
            /// Output Presets in the AWS Elemental MediaConvert User Guide.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SettingsJson { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the preset that you are modifying.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::MediaConvert::Preset";

        public PresetProperties Properties { get; } = new PresetProperties();

    }

    public static class PresetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
