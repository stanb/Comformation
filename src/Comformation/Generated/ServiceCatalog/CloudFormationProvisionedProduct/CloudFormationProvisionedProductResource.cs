using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProvisionedProduct
{
    /// <summary>
    /// AWS::ServiceCatalog::CloudFormationProvisionedProduct
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html
    /// </summary>
    public class CloudFormationProvisionedProductResource : ResourceBase
    {
        public class CloudFormationProvisionedProductProperties
        {
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
            /// NotificationArns
            /// Passed to AWS CloudFormation. The SNS topic ARNs to which to publish stack-related events.
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> NotificationArns { get; set; }

            /// <summary>
            /// PathId
            /// The path identifier of the product. This value is optional if the product has a default path, and
            /// required if the product has more than one path. To list the paths for a product, use
            /// ListLaunchPaths.
            /// Note You must provide the name or ID, but not both.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PathId { get; set; }

            /// <summary>
            /// PathName
            /// The name of the path. This value is optional if the product has a default path, and required if the
            /// product has more than one path. To list the paths for a product, use ListLaunchPaths.
            /// Note You must provide the name or ID, but not both.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PathName { get; set; }

            /// <summary>
            /// ProductId
            /// The product identifier.
            /// Note You must specify either the ID or the name of the product, but not both.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProductId { get; set; }

            /// <summary>
            /// ProductName
            /// A user-friendly name for the provisioned product. This value must be unique for the AWS account and
            /// cannot be updated after the product is provisioned.
            /// Each time a stack is created or updated, if ProductName is provided it will successfully resolve to
            /// ProductId as long as only one product exists in the account or Region with that ProductName.
            /// Note You must specify either the name or the ID of the product, but not both.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9][a-zA-Z0-9. _-]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProductName { get; set; }

            /// <summary>
            /// ProvisionedProductName
            /// A user-friendly name for the provisioned product. This value must be unique for the AWS account and
            /// cannot be updated after the product is provisioned.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9][a-zA-Z0-9. _-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProvisionedProductName { get; set; }

            /// <summary>
            /// ProvisioningArtifactId
            /// The identifier of the provisioning artifact (also known as a version).
            /// Note You must specify either the ID or the name of the provisioning artifact, but not both.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProvisioningArtifactId { get; set; }

            /// <summary>
            /// ProvisioningArtifactName
            /// The name of the provisioning artifact (also known as a version) for the product. This name must be
            /// unique for the product.
            /// Note You must specify either the name or the ID of the provisioning artifact, but not both.
            /// Required: Conditional
            /// Type: String
            /// Maximum: 8192
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProvisioningArtifactName { get; set; }

            /// <summary>
            /// ProvisioningParameters
            /// Parameters specified by the administrator that are required for provisioning the product.
            /// Required: No
            /// Type: List of ProvisioningParameter
            /// Update requires: No interruption
            /// </summary>
            public List<ProvisioningParameter> ProvisioningParameters { get; set; }

            /// <summary>
            /// ProvisioningPreferences
            /// StackSet preferences that are required for provisioning the product or updating a provisioned
            /// product.
            /// Required: No
            /// Type: ProvisioningPreferences
            /// Update requires: No interruption
            /// </summary>
            public ProvisioningPreferences ProvisioningPreferences { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Note Requires the provisioned product to have an ResourceUpdateConstraint resource with
            /// TagUpdatesOnProvisionedProduct set to ALLOWED to allow tag updates. If RESOURCE_UPDATE constraint is
            /// not present, tags updates are ignored.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::CloudFormationProvisionedProduct";

        public CloudFormationProvisionedProductProperties Properties { get; } = new CloudFormationProvisionedProductProperties();

    }

    public static class CloudFormationProvisionedProductAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProvisionedProductId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProvisionedProductId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RecordId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RecordId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CloudformationStackArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("CloudformationStackArn");
    }
}
