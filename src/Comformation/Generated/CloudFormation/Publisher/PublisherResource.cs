using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.Publisher
{
    /// <summary>
    /// AWS::CloudFormation::Publisher
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publisher.html
    /// </summary>
    public class PublisherResource : ResourceBase
    {
        public class PublisherProperties
        {
            /// <summary>
            /// AcceptTermsAndConditions
            /// Whether you accept the Terms and Conditions for publishing extensions in the CloudFormation
            /// registry. You must accept the terms and conditions in order to register to publish public extensions
            /// to the CloudFormation registry.
            /// The default is false.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> AcceptTermsAndConditions { get; set; }

            /// <summary>
            /// ConnectionArn
            /// If you are using a Bitbucket or GitHub account for identity verification, the Amazon Resource Name
            /// (ARN) for your connection to that account.
            /// For more information, see Registering your account to publish CloudFormation extensions in the
            /// CloudFormation CLI User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: arn:aws(-[\w]+)*:. +:. +:[0-9]{12}:. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionArn { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::Publisher";

        public PublisherProperties Properties { get; } = new PublisherProperties();

    }

    public static class PublisherAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PublisherId = new ResourceAttribute<Union<string, IntrinsicFunction>>("PublisherId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PublisherStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("PublisherStatus");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PublisherProfile = new ResourceAttribute<Union<string, IntrinsicFunction>>("PublisherProfile");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IdentityProvider = new ResourceAttribute<Union<string, IntrinsicFunction>>("IdentityProvider");
    }
}
