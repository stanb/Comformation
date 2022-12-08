using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.SAMLProvider
{
    /// <summary>
    /// AWS::IAM::SAMLProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-samlprovider.html
    /// </summary>
    public class SAMLProviderResource : ResourceBase
    {
        public class SAMLProviderProperties
        {
            /// <summary>
            /// Name
            /// The name of the provider to create.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w. _-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SamlMetadataDocument
            /// An XML document generated by an identity provider (IdP) that supports SAML 2. 0. The document
            /// includes the issuer&#39;s name, expiration information, and keys that can be used to validate the SAML
            /// authentication response (assertions) that are received from the IdP. You must generate the metadata
            /// document using the identity management software that is used as your organization&#39;s IdP.
            /// For more information, see About SAML 2. 0-based federation in the IAM User Guide
            /// Required: Yes
            /// Type: String
            /// Minimum: 1000
            /// Maximum: 10000000
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SamlMetadataDocument { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags that you want to attach to the new IAM SAML provider. Each tag consists of a key name
            /// and an associated value. For more information about tagging, see Tagging IAM resources in the IAM
            /// User Guide.
            /// Note If any one of the tags is invalid or if you exceed the allowed maximum number of tags, then the
            /// entire request fails and the resource is not created.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IAM::SAMLProvider";

        public SAMLProviderProperties Properties { get; } = new SAMLProviderProperties();

    }

    public static class SAMLProviderAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}