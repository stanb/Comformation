using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverRule
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverRule
    /// The 	AWS::Route53Resolver::ResolverRule resource provides detailed information about a resolver rule, which
    /// specifies 	how to route DNS queries out of a VPC for Amazon Route&#160;53 Resolver. For more information, see
    /// 	ResolverRule in the Amazon Route&#160;53 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html
    /// </summary>
    public class ResolverRuleResource : ResourceBase
    {
        public class ResolverRuleProperties
        {
            /// <summary>
            /// ResolverEndpointId
            /// 	
            /// The ID of the outbound endpoint that the rule is associated with.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResolverEndpointId { get; set; }

            /// <summary>
            /// DomainName
            /// 	
            /// DNS queries for this domain name are forwarded to the IP addresses that are specified in TargetIps.
            /// 		If a query matches multiple resolver rules (example. com and www. example. com), the query is
            /// routed 		using the resolver rule that contains the most specific domain name (www. example. com).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// RuleType
            /// 	
            /// When you want to forward DNS queries for specified domain name to resolvers on your network, specify
            /// FORWARD.
            /// 	
            /// When you have a forwarding rule to forward DNS queries for a domain to your network and you want
            /// Resolver to process queries for 		a subdomain of that domain, choose SYSTEM.
            /// 	
            /// For example, to forward DNS queries for example. com to resolvers on your network, you create a rule
            /// and specify FORWARD 		for RuleType. To then have Resolver process queries for apex. example. com,
            /// you create a rule and specify 		SYSTEM for RuleType.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RuleType { get; set; }

            /// <summary>
            /// TargetIps
            /// 	
            /// When a DNS query matches the name that you specify in DomainName, the outbound endpoint forwards the
            /// query 		to the IP addresses that you specify here, typically the IP addresses for DNS resolvers on
            /// your network. 		Specify IPv4 addresses. IPv6 is not supported.
            /// Required: No
            /// Type: List of TargetAddress property types
            /// Update requires: No interruption
            /// </summary>
			public List<TargetAddress> TargetIps { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// A list of the tag keys and values that you want to associate with the rule.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// 	
            /// A friendly name that lets you easily find a rule in the Resolver dashboard in the Route&#160;53 console.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::ResolverRule";

        public ResolverRuleProperties Properties { get; } = new ResolverRuleProperties();

    }

	public static class ResolverRuleAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResolverEndpointId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResolverEndpointId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResolverRuleId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResolverRuleId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TargetIps = new ResourceAttribute<Union<string, IntrinsicFunction>>("TargetIps");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
