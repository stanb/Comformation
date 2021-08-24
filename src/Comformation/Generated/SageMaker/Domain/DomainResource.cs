using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Domain
{
    /// <summary>
    /// AWS::SageMaker::Domain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// AppNetworkAccessType
            /// Specifies the VPC used for non-EFS traffic. The default value is PublicInternetOnly.
            /// PublicInternetOnly - Non-EFS traffic is through a VPC managed by Amazon SageMaker, which allows
            /// direct internet access VpcOnly - All Studio traffic is through the specified VPC and subnets
            /// Valid Values: PublicInternetOnly | VpcOnly
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AppNetworkAccessType { get; set; }

            /// <summary>
            /// AuthMode
            /// The mode of authentication that members use to access the domain.
            /// Valid Values: SSO | IAM
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AuthMode { get; set; }

            /// <summary>
            /// DefaultUserSettings
            /// The default user settings.
            /// Required: Yes
            /// Type: UserSettings
            /// Update requires: No interruption
            /// </summary>
            public UserSettings DefaultUserSettings { get; set; }

            /// <summary>
            /// DomainName
            /// The domain name.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// KmsKeyId
            /// SageMaker uses AWS KMS to encrypt the EFS volume attached to the domain with an AWS managed customer
            /// master key (CMK) by default. For more control, specify a customer managed CMK.
            /// Length Constraints: Maximum length of 2048.
            /// Pattern: . *
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// SubnetIds
            /// The VPC subnets that Studio uses for communication.
            /// Length Constraints: Maximum length of 32.
            /// Array members: Minimum number of 1 item. Maximum number of 16 items.
            /// Pattern: [-0-9a-zA-Z]+
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// Tags to associated with the Domain. Each tag consists of a key and an optional value. Tag keys must
            /// be unique per resource. Tags are searchable using the Search API.
            /// Tags that you specify for the Domain are also added to all Apps that are launched in the Domain.
            /// Array members: Minimum number of 0 items. Maximum number of 50 items.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.
            /// Length Constraints: Maximum length of 32.
            /// Pattern: [-0-9a-zA-Z]+
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Domain";

        public DomainProperties Properties { get; } = new DomainProperties();

    }

    public static class DomainAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Url = new ResourceAttribute<Union<string, IntrinsicFunction>>("Url");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> HomeEfsFileSystemId = new ResourceAttribute<Union<string, IntrinsicFunction>>("HomeEfsFileSystemId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SingleSignOnManagedApplicationInstanceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("SingleSignOnManagedApplicationInstanceId");
    }
}
