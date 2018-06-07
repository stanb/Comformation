using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProvisionedProduct
{
    /// <summary>
    /// AWS::ServiceCatalog::CloudFormationProvisionedProduct
    /// Provisions the specified product for AWS Service Catalog. For more information, see ProvisionProduct in the
    /// AWS Service Catalog Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-pathid
            /// </summary>
			public Union<string, IntrinsicFunction> PathId { get; set; }

            /// <summary>
            /// ProvisioningParameters
            /// Parameters specified by the administrator that are required for provisioning the product.
            /// Required: No
            /// Type: List of AWS Service Catalog CloudFormationProvisionedProduct ProvisioningParameter property
            /// types
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-provisioningparameters
            /// </summary>
			public Union<List<ProvisioningParameter>, IntrinsicFunction> ProvisioningParameters { get; set; }

            /// <summary>
            /// ProductName
            /// The product name. This name must be unique for the user. You must specify either the name or the ID
            /// of the product, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-productname
            /// </summary>
			public Union<string, IntrinsicFunction> ProductName { get; set; }

            /// <summary>
            /// ProvisioningArtifactName
            /// The name of the provisioning artifact. This name must be unique for the product. You must specify
            /// either the name or the ID of the provisioning artifact, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-provisioningartifactname
            /// </summary>
			public Union<string, IntrinsicFunction> ProvisioningArtifactName { get; set; }

            /// <summary>
            /// NotificationArns
            /// The SNS topic ARNs for stack-related events.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-notificationarns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> NotificationArns { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-acceptlanguage
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// ProductId
            /// The product identifier. You must specify either the ID or the name of the product, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-productid
            /// </summary>
			public Union<string, IntrinsicFunction> ProductId { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of property types
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// ProvisionedProductName
            /// A user-friendly name for the provisioned product. This name must be unique for the AWS account and
            /// cannot be updated after the product is provisioned.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-provisionedproductname
            /// </summary>
			public Union<string, IntrinsicFunction> ProvisionedProductName { get; set; }

            /// <summary>
            /// ProvisioningArtifactId
            /// The identifier of the provisioning artifact. You must specify either the ID or the name of the
            /// provisioning artifact, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationprovisionedproduct.html#cfn-servicecatalog-cloudformationprovisionedproduct-provisioningartifactid
            /// </summary>
			public Union<string, IntrinsicFunction> ProvisioningArtifactId { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::CloudFormationProvisionedProduct";
        
        public CloudFormationProvisionedProductProperties Properties { get; } = new CloudFormationProvisionedProductProperties();
    }

	public static class CloudFormationProvisionedProductAttributes
	{
        public static readonly ResourceAttribute<string> CloudformationStackArn = new ResourceAttribute<string>("CloudformationStackArn");
        public static readonly ResourceAttribute<string> RecordId = new ResourceAttribute<string>("RecordId");
	}
}
