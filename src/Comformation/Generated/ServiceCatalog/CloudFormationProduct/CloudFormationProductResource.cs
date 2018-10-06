using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProduct
{
    /// <summary>
    /// AWS::ServiceCatalog::CloudFormationProduct
    /// Creates the specified product for AWS Service Catalog. For more information, see CreateProduct in the AWS
    /// Service Catalog Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html
    /// </summary>
    public class CloudFormationProductResource : ResourceBase
    {
        public class CloudFormationProductProperties
        {
            /// <summary>
            /// Owner
            /// The owner of the product.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Owner { get; set; }

            /// <summary>
            /// SupportDescription
            /// The support information about the product.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SupportDescription { get; set; }

            /// <summary>
            /// Description
            /// The description of the product.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Distributor
            /// The distributor of the product.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Distributor { get; set; }

            /// <summary>
            /// SupportEmail
            /// The contact email for product support.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SupportEmail { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// SupportUrl
            /// The contact URL for product support.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SupportUrl { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the product.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ProvisioningArtifactParameters
            /// The configuration of the provisioning artifact (also known as a version) for a product.
            /// Required: Yes
            /// Type: List of AWS Service Catalog CloudFormationProduct ProvisioningArtifactProperties property
            /// types
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
