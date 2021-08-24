using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.Studio
{
    /// <summary>
    /// AWS::NimbleStudio::Studio
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html
    /// </summary>
    public class StudioResource : ResourceBase
    {
        public class StudioProperties
        {
            /// <summary>
            /// AdminRoleArn
            /// The IAM role that studio admins assume when logging in to the Nimble Studio portal.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AdminRoleArn { get; set; }

            /// <summary>
            /// DisplayName
            /// A friendly name for the studio.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// StudioName
            /// The name of the studio, as included in the URL when accessing it in the Nimble Studio portal.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StudioName { get; set; }

            /// <summary>
            /// UserRoleArn
            /// The IAM role that studio users assume when logging in to the Nimble Studio portal.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> UserRoleArn { get; set; }

            /// <summary>
            /// StudioEncryptionConfiguration
            /// Configuration of the encryption method that is used for the studio.
            /// Required: No
            /// Type: StudioEncryptionConfiguration
            /// Update requires: No interruption
            /// </summary>
            public StudioEncryptionConfiguration StudioEncryptionConfiguration { get; set; }

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

        public string Type { get; } = "AWS::NimbleStudio::Studio";

        public StudioProperties Properties { get; } = new StudioProperties();

    }

    public static class StudioAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> HomeRegion = new ResourceAttribute<Union<string, IntrinsicFunction>>("HomeRegion");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SsoClientId = new ResourceAttribute<Union<string, IntrinsicFunction>>("SsoClientId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StudioId = new ResourceAttribute<Union<string, IntrinsicFunction>>("StudioId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StudioUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("StudioUrl");
    }
}
