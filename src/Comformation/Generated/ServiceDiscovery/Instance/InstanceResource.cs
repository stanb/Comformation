using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Instance
{
    /// <summary>
    /// AWS::ServiceDiscovery::Instance
    /// A complex type that contains information about an instance that AWS Cloud Map creates when you submit a
    /// RegisterInstance request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html
    /// </summary>
    public class InstanceResource : ResourceBase
    {
        public class InstanceProperties
        {
            /// <summary>
            /// InstanceAttributes
            /// 		
            /// A string map that contains the following information for the service that you specify in ServiceId:
            /// 		
            /// 			 			 		 The attributes that apply to the records that are defined in the service. For each
            /// attribute, the applicable value.
            /// 		 		
            /// Supported attribute keys include the following:
            /// 		 		
            /// AWS_ALIAS_DNS_NAME
            /// 		
            /// 		
            /// If you want AWS Cloud Map to create a Route 53 alias record that routes traffic to an Elastic Load
            /// Balancing load balancer, specify the DNS name 			that is associated with the load balancer. For
            /// information about how to get the DNS name, see &quot;DNSName&quot; in the topic 			AliasTarget.
            /// 		
            /// Note the following:
            /// 		
            /// 			 			 			 			 			 		 The configuration for the service that is specified by ServiceId must include
            /// settings for an A record, 				an AAAA record, or both. In the service that is specified by
            /// ServiceId, the value of RoutingPolicy must be 				WEIGHTED. If the service that is specified by
            /// ServiceId includes HealthCheckConfig settings, 				AWS Cloud Map will create the health check, but
            /// it won&#39;t associate the health check with the alias record. Auto naming currently doesn&#39;t support
            /// creating alias records that route traffic to AWS resources other than 				ELB load balancers. If you
            /// specify a value for AWS_ALIAS_DNS_NAME, don&#39;t specify values for any of the 				AWS_INSTANCE
            /// attributes.
            /// 		 		
            /// AWS_INSTANCE_CNAME
            /// 		
            /// If the service configuration includes a CNAME record, the domain name that you want Route 53 to
            /// return in response to 			DNS queries, for example, example. com.
            /// 		
            /// This value is required if the service specified by ServiceId includes settings for an CNAME record.
            /// 		 		 		
            /// AWS_INSTANCE_IPV4
            /// 		
            /// If the service configuration includes an A record, the IPv4 address that you want Route 53 to return
            /// in response to DNS queries, 			for example, 192. 0. 2. 44.
            /// 		
            /// This value is required if the service specified by ServiceId includes settings for an A record.
            /// 			If the service includes settings for an SRV record, you must specify a value for
            /// AWS_INSTANCE_IPV4, AWS_INSTANCE_IPV6, 			or both.
            /// 		 		
            /// AWS_INSTANCE_IPV6
            /// 		
            /// If the service configuration includes an AAAA record, the IPv6 address that you want Route 53 to
            /// return in response to DNS queries, 			for example, 2001:0db8:85a3:0000:0000:abcd:0001:2345.
            /// 		
            /// This value is required if the service specified by ServiceId includes settings for an AAAA record.
            /// 			If the service includes settings for an SRV record, you must specify a value for
            /// AWS_INSTANCE_IPV4, AWS_INSTANCE_IPV6, 			or both.
            /// 		 		
            /// AWS_INSTANCE_PORT
            /// 		
            /// If the service includes an SRV record, the value that you want Route 53 to return for the port.
            /// 		
            /// If the service includes HealthCheckConfig, the port on the endpoint that you want Route 53 to send
            /// requests to.
            /// 		
            /// This value is required if you specified settings for an SRV record or a Route 53 health check when
            /// you created the service.
            /// 	
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> InstanceAttributes { get; set; }

            /// <summary>
            /// InstanceId
            /// 		
            /// An identifier that you want to associate with the instance. Note the following:
            /// 		
            /// 			 			 			 			 		 If the service that is specified by ServiceId includes settings for an SRV
            /// record, the value of InstanceId 				is automatically included as part of the value for the SRV
            /// record. For more information, see 				DnsRecord &amp;gt; Type. You can use this value to update an
            /// existing instance. To register a new instance, you must specify a value that is unique among
            /// instances that you register 				by using the same service. If you specify an existing InstanceId and
            /// ServiceId, AWS Cloud Map updates the existing DNS records. 				If there&#39;s also an existing health
            /// check, AWS Cloud Map deletes the old health check and creates a new one. 				 Note The health check
            /// isn&#39;t deleted immediately, so it will still appear for a while if you submit a ListHealthChecks
            /// 				request, for example.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// ServiceId
            /// 		
            /// The ID of the service that you want to use for settings for the instance.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceId { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::Instance";

        public InstanceProperties Properties { get; } = new InstanceProperties();

    }
}
