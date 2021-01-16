using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProduct
{
    /// <summary>
    /// AWS::ServiceCatalog::CloudFormationProduct
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html
    /// </summary>
    public class CloudFormationProductResource : ResourceBase
    {
        public class CloudFormationProductProperties
        {
            /// <summary>
            /// ReplaceProvisioningArtifacts
            /// This property is turned off by default. If turned off, you can update provisioning artifacts or
            /// product attributes (such as description, distributor, name, owner, and more) and the associated
            /// provisioning artifacts will retain the same unique identifier. Provisioning artifacts are matched
            /// within the CloudFormationProduct resource, and only those that have been updated will be changed.
            /// Provisioning artifacts are matched by a combinaton of provisioning artifact template URL and name.
            /// If turned on, provisioning artifacts will be given a new unique identifier when you update the
            /// product or provisioning artifacts.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ReplaceProvisioningArtifacts { get; set; }

            /// <summary>
            /// Owner
            /// The owner of the product.
            /// Required: Yes
            /// Type: String
            /// Maximum: 8191
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Owner { get; set; }

            /// <summary>
            /// SupportDescription
            /// The support information about the product.
            /// Required: No
            /// Type: String
            /// Maximum: 8191
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SupportDescription { get; set; }

            /// <summary>
            /// Description
            /// The description of the product.
            /// Required: No
            /// Type: String
            /// Maximum: 8191
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Distributor
            /// The distributor of the product.
            /// Required: No
            /// Type: String
            /// Maximum: 8191
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Distributor { get; set; }

            /// <summary>
            /// SupportEmail
            /// The contact email for product support.
            /// Required: No
            /// Type: String
            /// Maximum: 254
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SupportEmail { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// en - English (default) jp - Japanese zh - Chinese
            /// Required: No
            /// Type: String
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// SupportUrl
            /// The contact URL for product support.
            /// ^https?:\/\// / is the pattern used to validate SupportUrl.
            /// Required: No
            /// Type: String
            /// Maximum: 2083
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SupportUrl { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 20
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the product.
            /// Required: Yes
            /// Type: String
            /// Maximum: 8191
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ProvisioningArtifactParameters
            /// The configuration of the provisioning artifact (also known as a version).
            /// Required: Yes
            /// Type: List of ProvisioningArtifactProperties
            /// Update requires: No interruption
            /// </summary>
            public List<ProvisioningArtifactProperties> ProvisioningArtifactParameters { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::CloudFormationProduct";

        public CloudFormationProductProperties Properties { get; } = new CloudFormationProductProperties();

    }

    public static class CloudFormationProductAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProductName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProductName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProvisioningArtifactIds = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProvisioningArtifactIds");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProvisioningArtifactNames = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProvisioningArtifactNames");
    }
}
