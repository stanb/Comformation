using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Signer.SigningProfile
{
    /// <summary>
    /// AWS::Signer::SigningProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-signer-signingprofile.html
    /// </summary>
    public class SigningProfileResource : ResourceBase
    {
        public class SigningProfileProperties
        {
            /// <summary>
            /// SignatureValidityPeriod
            /// The validity period override for any signature generated using this signing profile. If unspecified,
            /// the default is 135 months.
            /// Required: No
            /// Type: SignatureValidityPeriod
            /// Update requires: Replacement
            /// </summary>
            public SignatureValidityPeriod SignatureValidityPeriod { get; set; }

            /// <summary>
            /// PlatformId
            /// 		
            /// The ID of a platform that is available for use by a signing profile.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PlatformId { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// A list of tags associated with the signing profile.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Signer::SigningProfile";

        public SigningProfileProperties Properties { get; } = new SigningProfileProperties();

    }

    public static class SigningProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProfileName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProfileName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProfileVersion = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProfileVersion");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProfileVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProfileVersionArn");
    }
}
