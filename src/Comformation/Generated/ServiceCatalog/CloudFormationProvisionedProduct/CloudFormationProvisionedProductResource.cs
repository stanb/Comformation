using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProvisionedProduct
{
    /// <summary>
    /// AWS::ServiceCatalog::CloudFormationProvisionedProduct
    /// Provisions the specified product for AWS Service Catalog. For more information, see ProvisionProduct in the
    /// AWS Service Catalog Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html
    /// </summary>
    public class CloudFormationProvisionedProductResource : ResourceBase
    {
        public class CloudFormationProvisionedProductProperties
        {
            /// <summary>
            /// PathId
            /// The path identifier of the product.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PathId { get; set; }

            /// <summary>
            /// ProvisioningParameters
            /// Parameters specified by the administrator that are required for provisioning the product.
            /// Required: No
            /// Type: List of AWS Service Catalog CloudFormationProvisionedProduct ProvisioningParameter property
            /// types
            /// Update requires: No interruption
            /// </summary>
			public List<ProvisioningParameter> ProvisioningParameters { get; set; }

            /// <summary>
            /// ProductName
            /// The product name. This name must be unique for the user. You must specify either the name or the ID
            /// of the product, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProductName { get; set; }

            /// <summary>
            /// ProvisioningArtifactName
            /// The name of the provisioning artifact (also known as a version) for the product. This name must be
            /// unique for the product. You must specify either the name or the ID of the provisioning artifact, but
            /// not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ProvisioningArtifactName { get; set; }

            /// <summary>
            /// NotificationArns
            /// The SNS topic ARNs for stack-related events.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> NotificationArns { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// ProductId
            /// The product identifier. You must specify either the ID or the name of the product, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProductId { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// ProvisionedProductName
            /// A user-friendly name for the provisioned product. This name must be unique for the AWS account and
            /// cannot be updated after the product is provisioned.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProvisionedProductName { get; set; }

            /// <summary>
            /// ProvisioningArtifactId
            /// The identifier of the provisioning artifact (also known as a version) for the product. You must
            /// specify either the ID or the name of the provisioning artifact, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ProvisioningArtifactId { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::CloudFormationProvisionedProduct";
        
        public CloudFormationProvisionedProductProperties Properties { get; } = new CloudFormationProvisionedProductProperties();

    }

	public static class CloudFormationProvisionedProductAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CloudformationStackArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("CloudformationStackArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RecordId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RecordId");
	}
}
