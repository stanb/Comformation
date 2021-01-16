using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html
    /// </summary>
    public class IndexResource : ResourceBase
    {
        public class IndexProperties
        {
            /// <summary>
            /// Description
            /// A description of the index.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ServerSideEncryptionConfiguration
            /// The identifier of the AWS KMS customer managed key (CMK) to use to encrypt data indexed by Amazon
            /// Kendra. Amazon Kendra doesn&#39;t support asymmetric CMKs.
            /// Required: No
            /// Type: ServerSideEncryptionConfiguration
            /// Update requires: Replacement
            /// </summary>
            public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the index.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1000
            /// Pattern: [a-zA-Z0-9][a-zA-Z0-9_-]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoleArn
            /// An IAM role that gives Amazon Kendra permissions to access your Amazon CloudWatch logs and metrics.
            /// This is also the role used when you use the BatchPutDocument operation to index documents from an
            /// Amazon S3 bucket.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Edition
            /// Indicates whether the index is a enterprise edition index or a developer edition index. Valid values
            /// are DEVELOPER_EDITION and ENTERPRISE_EDITION.
            /// Required: Yes
            /// Type: String
            /// Allowed values: DEVELOPER_EDITION | ENTERPRISE_EDITION
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Edition { get; set; }

            /// <summary>
            /// DocumentMetadataConfigurations
            /// Specifies the properties of an index field. You can add either a custom or a built-in field. You can
            /// add and remove built-in fields at any time. When a built-in field is removed it&#39;s configuration
            /// reverts to the default for the field. Custom fields can&#39;t be removed from an index after they are
            /// added.
            /// Required: No
            /// Type: List of DocumentMetadataConfiguration
            /// Update requires: No interruption
            /// </summary>
            public List<DocumentMetadataConfiguration> DocumentMetadataConfigurations { get; set; }

            /// <summary>
            /// CapacityUnits
            /// Specifies capacity units configured for your index. You can add and remove capacity units to tune an
            /// index to your requirements. You can set capacity units only for Enterprise edition indexes.
            /// Required: No
            /// Type: CapacityUnitsConfiguration
            /// Update requires: No interruption
            /// </summary>
            public CapacityUnitsConfiguration CapacityUnits { get; set; }

            /// <summary>
            /// UserContextPolicy
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> UserContextPolicy { get; set; }

            /// <summary>
            /// UserTokenConfigurations
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of UserTokenConfiguration
            /// Update requires: No interruption
            /// </summary>
            public List<UserTokenConfiguration> UserTokenConfigurations { get; set; }

        }

        public string Type { get; } = "AWS::Kendra::Index";

        public IndexProperties Properties { get; } = new IndexProperties();

    }

    public static class IndexAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
