using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.DomainName
{
    /// <summary>
    /// AWS::ApiGatewayV2::DomainName
    /// The AWS::ApiGatewayV2::DomainName resource specifies a custom domain name for your API in Amazon API Gateway
    /// (API Gateway).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-domainname.html
    /// </summary>
    public class DomainNameResource : ResourceBase
    {
        public class DomainNameProperties
        {
            /// <summary>
            /// DomainName
            /// The custom domain name for your API in Amazon API Gateway. Uppercase letters are not supported.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// DomainNameConfigurations
            /// The domain name configurations.
            /// Required: No
            /// Type: List of DomainNameConfiguration
            /// Update requires: No interruption
            /// </summary>
			public List<DomainNameConfiguration> DomainNameConfigurations { get; set; }

            /// <summary>
            /// Tags
            /// The collection of tags associated with a domain name.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::DomainName";

        public DomainNameProperties Properties { get; } = new DomainNameProperties();

    }

	public static class DomainNameAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegionalHostedZoneId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegionalHostedZoneId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegionalDomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegionalDomainName");
	}
}
