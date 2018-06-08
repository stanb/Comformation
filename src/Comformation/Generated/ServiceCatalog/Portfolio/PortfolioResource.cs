using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.Portfolio
{
    /// <summary>
    /// AWS::ServiceCatalog::Portfolio
    /// Creates a portfolio for AWS Service Catalog. For more information, see CreatePortfolio in the AWS Service
    /// Catalog Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolio.html
    /// </summary>
    public class PortfolioResource : ResourceBase
    {
        public class PortfolioProperties
        {
            /// <summary>
            /// ProviderName
            /// The name of the portfolio provider.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ProviderName { get; set; }

            /// <summary>
            /// Description
            /// The description of the portfolio.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DisplayName
            /// The name to use for display purposes.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::Portfolio";
        
        public PortfolioProperties Properties { get; } = new PortfolioProperties();
    }

	public static class PortfolioAttributes
	{
        public static readonly ResourceAttribute<string> PortfolioName = new ResourceAttribute<string>("PortfolioName");
	}
}
