using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverRule
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverRule
    /// For DNS queries that originate in your VPCs, specifies which resolver endpoint the queries pass through,
    /// 			one domain name that you want to forward to your network, and the IP addresses of the DNS resolvers in your
    /// network.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverrule.html
    /// </summary>
    public class ResolverRuleResource : ResourceBase
    {
        public class ResolverRuleProperties
        {
            /// <summary>
            /// ResolverEndpointId
            /// 		
            /// The ID of the endpoint that the rule is associated with.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResolverEndpointId { get; set; }

            /// <summary>
            /// DomainName
            /// 		
            /// DNS queries for this domain name are forwarded to the IP addresses that are specified in TargetIps.
            /// If a query matches 			multiple resolver rules (example. com and www. example. com), the query is
            /// routed using the resolver rule that contains the most specific domain name 			(www. example. com).
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// RuleType
            /// 		
            /// This value is always FORWARD. Other resolver rule types aren&#39;t supported.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed Values: FORWARD | RECURSIVE | SYSTEM
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RuleType { get; set; }

            /// <summary>
            /// TargetIps
            /// 		
            /// An array that contains the IP addresses and ports that an outbound endpoint forwards DNS queries to.
            /// Typically, 			these are the IP addresses of DNS resolvers on your network. Specify IPv4 addresses.
            /// IPv6 is not supported.
            /// 	
            /// Required: No
            /// Type: List of TargetAddress
            /// Update requires: No interruption
            /// </summary>
			public List<TargetAddress> TargetIps { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// A list of the tag keys and values that you want to associate with the endpoint.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The name for the resolver rule, which you specified when you created the resolver rule.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Pattern: (?!^[0-9]+$)([a-zA-Z0-9-_&#39; &#39;]+)
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
