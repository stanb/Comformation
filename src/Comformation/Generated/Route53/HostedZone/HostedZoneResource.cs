using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone
    /// The AWS::Route53::HostedZone resource is a Route 53 resource type that contains information about 			how you
    /// want to route traffic for a domain (example. com) and its subdomains (acme. example. com, zenith. example.
    /// com):
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html
    /// </summary>
    public class HostedZoneResource : ResourceBase
    {
        public class HostedZoneProperties
        {
            /// <summary>
            /// HostedZoneConfig
            /// 		
            /// (Optional) A complex type that contains the following optional values:
            /// 		
            /// 			 			 		 For public and private hosted zones, an optional comment For private hosted zones, an
            /// optional PrivateZone element
            /// 		
            /// If you don&#39;t specify a comment or the PrivateZone element, omit HostedZoneConfig and 			the other
            /// elements.
            /// 	
            /// Required: No
            /// Type: HostedZoneConfig
            /// Update requires: No interruption
            /// </summary>
			public HostedZoneConfig HostedZoneConfig { get; set; }

            /// <summary>
            /// HostedZoneTags
            /// 		
            /// Adds, edits, or deletes tags for a health check or a hosted zone.
            /// 		
            /// For information about using tags for cost allocation, see 			Using Cost Allocation Tags 			in the
            /// AWS Billing and Cost Management User Guide.
            /// 		 		 	
            /// Required: No
            /// Type: List of HostedZoneTag
            /// Update requires: No interruption
            /// </summary>
			public List<HostedZoneTag> HostedZoneTags { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The name of the domain. Specify a fully qualified domain name, for example, www. example. com.
            /// 			The trailing dot is optional; Amazon Route 53 assumes that the domain name is fully qualified.
            /// This means that Route 53 treats 			www. example. com (without a trailing dot) and www. example. com.
            /// (with a trailing dot) as identical.
            /// 		
            /// If you&#39;re creating a public hosted zone, this is the name you have registered with your DNS
            /// registrar. If your domain name 			is registered with a registrar other than Route 53, change the
            /// name servers for your domain to the set of NameServers that 			CreateHostedZone returns in
            /// DelegationSet.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// QueryLoggingConfig
            /// 		
            /// Creates a configuration for DNS query logging. After you create a query logging configuration,
            /// Amazon Route 53 begins to publish 			log data to an Amazon CloudWatch Logs log group.
            /// 		
            /// DNS query logs contain information about the queries that Route 53 receives for a specified public
            /// hosted zone, such as the following:
            /// 		
            /// 			 			 			 			 		 Route 53 edge location that responded to the DNS query Domain or subdomain that
            /// was requested DNS record type, such as A or AAAA DNS response code, such as NoError or ServFail
            /// 		 		
            /// 			 			 			 			 			 			 			 			 			 			 			 		 				 Log Group and Resource Policy 				 Before you
            /// create a query logging configuration, perform the following operations. 					 Note If you create a
            /// query logging configuration using the Route 53 console, Route 53 performs these operations
            /// automatically. 					 						 						 					 Create a CloudWatch Logs log group, and make note of the
            /// ARN, which you specify when you create a 							query logging configuration. Note the following:
            /// 							 								 								 								 							 You must create the log group in the us-east-1 region.
            /// You must use the same AWS account to create the log group and the hosted zone that you want to
            /// 									configure query logging for. When you create log groups for query logging, we recommend
            /// that you use a consistent prefix, for example: 									 /aws/route53/hosted zone name 									 In
            /// the next step, you&#39;ll create a resource policy, which controls access to one or more log groups and
            /// the associated 										AWS resources, such as Route 53 hosted zones. There&#39;s a limit on the number
            /// of resource policies that you can create, so 										we recommend that you use a consistent prefix
            /// so you can use the same resource policy for all the log groups that you create 										for query
            /// logging. 								 						 Create a CloudWatch Logs resource policy, and give it the permissions that
            /// Route 53 needs to create log streams and to 							send query logs to log streams. For the value of
            /// Resource, specify the ARN for the log group that you created 							in the previous step. To use the
            /// same resource policy for all the CloudWatch Logs log groups that you created for query logging
            /// configurations, 							replace the hosted zone name with *, for example: 							
            /// arn:aws:logs:us-east-1:123412341234:log-group:/aws/route53/* 							 Note You can&#39;t use the
            /// CloudWatch console to create or edit a resource policy. You must use the CloudWatch API, one of the
            /// AWS SDKs, 								or the AWS CLI. 						 				 			 				 Log Streams and Edge Locations 				 When
            /// Route 53 finishes creating the configuration for DNS query logging, it does the following: 					
            /// 						 						 					 Creates a log stream for an edge location the first time that the edge location
            /// responds to DNS queries for the 							specified hosted zone. That log stream is used to log all
            /// queries that Route 53 responds to for that edge location. Begins to send query logs to the
            /// applicable log stream. 					 The name of each log stream is in the following format: 					 hosted
            /// zone ID/edge location code 					 The edge location code is a three-letter code and an arbitrarily
            /// assigned number, for example, DFW3. The three-letter code 						typically corresponds with the
            /// International Air Transport Association airport code for an airport near the edge location.
            /// 						(These abbreviations might change in the future. ) For a list of edge locations, see &quot;The
            /// Route 53 Global Network&quot; on the 						Route 53 Product Details page. 				 			 				 Queries That Are
            /// Logged 				 Query logs contain only the queries that DNS resolvers forward to Route 53. If a DNS
            /// resolver has already cached 					the response to a query (such as the IP address for a load balancer
            /// for example. com), the resolver will continue to return 					the cached response. It doesn&#39;t forward
            /// another query to Route 53 until the TTL for the corresponding resource record set expires.
            /// 					Depending on how many DNS queries are submitted for a resource record set, and depending on the
            /// TTL for that resource record set, 					query logs might contain information about only one query out
            /// of every several thousand queries that are submitted to DNS. 					For more information about how DNS
            /// works, see 					Routing Internet Traffic to Your Website or Web Application 					in the Amazon Route
            /// 53 Developer Guide. 				 			 				 Log File Format 				 For a list of the values in each query log
            /// and the format of each value, see 					Logging DNS Queries in the 					Amazon Route 53 Developer
            /// Guide. 				 			 				 Pricing 				 For information about charges for query logs, see 					Amazon
            /// CloudWatch Pricing. 			 				 How to Stop Logging 				 If you want Route 53 to stop sending query
            /// logs to CloudWatch Logs, delete the query logging configuration. For more information, see
            /// 					DeleteQueryLoggingConfig. 				 			
            /// 		 	
            /// Required: No
            /// Type: QueryLoggingConfig
            /// Update requires: No interruption
            /// </summary>
			public QueryLoggingConfig QueryLoggingConfig { get; set; }

            /// <summary>
            /// VPCs
            /// 		
            /// A complex type that contains information about the VPCs that are associated with the specified
            /// hosted zone.
            /// 	
            /// Required: No
            /// Type: List of VPC
            /// </summary>
			public List<VPC> VPCs { get; set; }

        }

        public string Type { get; } = "AWS::Route53::HostedZone";

        public HostedZoneProperties Properties { get; } = new HostedZoneProperties();

    }

	public static class HostedZoneAttributes
	{
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> NameServers = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("NameServers");
	}
}
