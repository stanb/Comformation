using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.LaunchProfile
{
    /// <summary>
    /// AWS::NimbleStudio::LaunchProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-launchprofile.html
    /// </summary>
    public class LaunchProfileResource : ResourceBase
    {
        public class LaunchProfileProperties
        {
            /// <summary>
            /// Description
            /// A human-readable description of the launch profile.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// A friendly name for the launch profile.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Ec2SubnetIds
            /// Unique identifiers for a collection of EC2 subnets.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Ec2SubnetIds { get; set; }

            /// <summary>
            /// StreamConfiguration
            /// A configuration for a streaming session.
            /// Required: Yes
            /// Type: StreamConfiguration
            /// Update requires: No interruption
            /// </summary>
            public StreamConfiguration StreamConfiguration { get; set; }

            /// <summary>
            /// StudioComponentIds
            /// Unique identifiers for a collection of studio components that can be used with this launch profile.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> StudioComponentIds { get; set; }

            /// <summary>
            /// LaunchProfileProtocolVersions
            /// The version number of the protocol that is used by the launch profile. The only valid version is
            /// &quot;2021-03-31&quot;.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> LaunchProfileProtocolVersions { get; set; }

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
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::NimbleStudio::LaunchProfile";

        public LaunchProfileProperties Properties { get; } = new LaunchProfileProperties();

    }

    public static class LaunchProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LaunchProfileId = new ResourceAttribute<Union<string, IntrinsicFunction>>("LaunchProfileId");
    }
}
