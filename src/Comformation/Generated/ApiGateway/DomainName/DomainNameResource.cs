using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DomainName
{
    /// <summary>
    /// AWS::ApiGateway::DomainName
    /// The AWS::ApiGateway::DomainName resource specifies a custom domain name for your API in Amazon API Gateway
    /// (API Gateway).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html
    /// </summary>
    public class DomainNameResource : ResourceBase
    {
        public class DomainNameProperties
        {
            /// <summary>
            /// CertificateArn
            /// The reference to an AWS-managed certificate for use by the edge-optimized endpoint for this domain
            /// name. AWS Certificate Manager is the only supported source. For requirements and additional
            /// information about setting up certificates, see Get Certificates Ready in AWS Certificate Manager in
            /// the API Gateway Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateArn { get; set; }

            /// <summary>
            /// DomainName
            /// The custom domain name for your API in Amazon API Gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// EndpointConfiguration
            /// A list of the endpoint types of the domain name.
            /// Required: No
            /// Type: EndpointConfiguration
            /// Update requires: No interruption
            /// </summary>
			public EndpointConfiguration EndpointConfiguration { get; set; }

            /// <summary>
            /// RegionalCertificateArn
            /// The reference to an AWS-managed certificate for use by the regional endpoint for the domain name.
            /// AWS Certificate Manager is the only supported source.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RegionalCertificateArn { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::DomainName";

        public DomainNameProperties Properties { get; } = new DomainNameProperties();

    }

	public static class DomainNameAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DistributionDomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DistributionDomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DistributionHostedZoneId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DistributionHostedZoneId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegionalDomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegionalDomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegionalHostedZoneId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegionalHostedZoneId");
	}
}
