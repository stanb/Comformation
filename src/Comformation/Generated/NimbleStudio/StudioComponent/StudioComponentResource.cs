using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studiocomponent.html
    /// </summary>
    public class StudioComponentResource : ResourceBase
    {
        public class StudioComponentProperties
        {
            /// <summary>
            /// Configuration
            /// The configuration of the studio component, based on component type.
            /// Required: No
            /// Type: StudioComponentConfiguration
            /// Update requires: No interruption
            /// </summary>
            public StudioComponentConfiguration Configuration { get; set; }

            /// <summary>
            /// Description
            /// A human-readable description for the studio component resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// InitializationScripts
            /// Initialization scripts for studio components.
            /// Required: No
            /// Type: List of StudioComponentInitializationScript
            /// Update requires: No interruption
            /// </summary>
            public List<StudioComponentInitializationScript> InitializationScripts { get; set; }

            /// <summary>
            /// Name
            /// A friendly name for the studio component resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ScriptParameters
            /// Parameters for the studio component scripts.
            /// Required: No
            /// Type: List of ScriptParameterKeyValue
            /// Update requires: No interruption
            /// </summary>
            public List<ScriptParameterKeyValue> ScriptParameters { get; set; }

            /// <summary>
            /// Ec2SecurityGroupIds
            /// The EC2 security groups that control access to the studio component.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Ec2SecurityGroupIds { get; set; }

            /// <summary>
            /// StudioId
            /// The unique identifier for a studio resource. In Nimble Studio, all other resources are contained in
            /// a studio resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StudioId { get; set; }

            /// <summary>
            /// Subtype
            /// The specific subtype of a studio component.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Subtype { get; set; }

            /// <summary>
            /// Type
            /// The type of the studio component.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::NimbleStudio::StudioComponent";

        public StudioComponentProperties Properties { get; } = new StudioComponentProperties();

    }

    public static class StudioComponentAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StudioComponentId = new ResourceAttribute<Union<string, IntrinsicFunction>>("StudioComponentId");
    }
}
