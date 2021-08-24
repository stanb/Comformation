using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.OIDCProvider
{
    /// <summary>
    /// AWS::IAM::OIDCProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-oidcprovider.html
    /// </summary>
    public class OIDCProviderResource : ResourceBase
    {
        public class OIDCProviderProperties
        {
            /// <summary>
            /// ClientIdList
            /// A list of client IDs (also known as audiences) that are associated with the specified IAM OIDC
            /// provider resource object. For more information, see CreateOpenIDConnectProvider.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ClientIdList { get; set; }

            /// <summary>
            /// Url
            /// The URL that the IAM OIDC provider resource object is associated with. For more information, see
            /// CreateOpenIDConnectProvider.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Url { get; set; }

            /// <summary>
            /// ThumbprintList
            /// A list of certificate thumbprints that are associated with the specified IAM OIDC provider resource
            /// object. For more information, see CreateOpenIDConnectProvider.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ThumbprintList { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags that are attached to the specified IAM OIDC provider. The returned list of tags is
            /// sorted by tag key. For more information about tagging, see Tagging IAM resources in the IAM User
            /// Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IAM::OIDCProvider";

        public OIDCProviderProperties Properties { get; } = new OIDCProviderProperties();

    }

    public static class OIDCProviderAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
