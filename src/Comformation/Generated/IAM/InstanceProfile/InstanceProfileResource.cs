using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.InstanceProfile
{
    /// <summary>
    /// AWS::IAM::InstanceProfile
    /// Creates a new instance profile. For information about instance profiles, go to About Instance Profiles.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html
    /// </summary>
    public class InstanceProfileResource : ResourceBase
    {
        public class InstanceProfileProperties
        {
            /// <summary>
            /// InstanceProfileName
            /// The name of the instance profile to create.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceProfileName { get; set; }

            /// <summary>
            /// Path
            /// The path to the instance profile. For more information about paths, see IAM Identifiers in the IAM
            /// User Guide.
            /// This parameter is optional. If it is not included, it defaults to a slash (/).
            /// This parameter allows (through its regex pattern) a string of characters consisting of either a
            /// forward slash (/) by itself or a string that must begin and end with forward slashes. In addition,
            /// it can contain any ASCII character from the ! (\u0021) through the DEL character (\u007F), including
            /// most punctuation characters, digits, and upper and lowercased letters.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: (\u002F)|(\u002F[\u0021-\u007F]+\u002F)
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// Roles
            /// The role associated with the instance profile.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Roles { get; set; }

        }

        public string Type { get; } = "AWS::IAM::InstanceProfile";

        public InstanceProfileProperties Properties { get; } = new InstanceProfileProperties();

    }

	public static class InstanceProfileAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
