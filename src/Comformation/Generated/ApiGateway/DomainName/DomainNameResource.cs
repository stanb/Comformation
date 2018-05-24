using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DomainName
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html
    /// </summary>
    public class DomainNameResource : ResourceBase
    {
        public class DomainNameProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-certificatearn
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-domainname
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-endpointconfiguration
            /// </summary>
			public Union<EndpointConfiguration, IntrinsicFunction> EndpointConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-regionalcertificatearn
            /// </summary>
			public Union<string, IntrinsicFunction> RegionalCertificateArn { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::DomainName";
        
        public DomainNameProperties Properties { get; } = new DomainNameProperties();
    }

	public static class DomainNameAttributes
	{
        public static readonly ResourceAttribute<string> DistributionDomainName = new ResourceAttribute<string>("DistributionDomainName");
        public static readonly ResourceAttribute<string> DistributionHostedZoneId = new ResourceAttribute<string>("DistributionHostedZoneId");
        public static readonly ResourceAttribute<string> RegionalDomainName = new ResourceAttribute<string>("RegionalDomainName");
        public static readonly ResourceAttribute<string> RegionalHostedZoneId = new ResourceAttribute<string>("RegionalHostedZoneId");
	}
}
