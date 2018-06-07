using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.AcceptedPortfolioShare
{
    /// <summary>
    /// AWS::ServiceCatalog::AcceptedPortfolioShare
    /// Accepts an offer to share the specified portfolio for AWS Service Catalog. For more information, see
    /// AcceptPortfolioShare in the AWS Service Catalog Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-acceptedportfolioshare.html
    /// </summary>
    public class AcceptedPortfolioShareResource : ResourceBase
    {
        public class AcceptedPortfolioShareProperties
        {
            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-acceptedportfolioshare.html#cfn-servicecatalog-acceptedportfolioshare-acceptlanguage
            /// </summary>
			public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// PortfolioId
            /// The portfolio identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-acceptedportfolioshare.html#cfn-servicecatalog-acceptedportfolioshare-portfolioid
            /// </summary>
			public Union<string, IntrinsicFunction> PortfolioId { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::AcceptedPortfolioShare";
        
        public AcceptedPortfolioShareProperties Properties { get; } = new AcceptedPortfolioShareProperties();
    }
}
