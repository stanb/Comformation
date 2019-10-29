using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// AWS::Route53::HealthCheck HealthCheckConfig
    /// A complex type that contains information about the health check.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthcheck-healthcheckconfig.html
    /// </summary>
    public class HealthCheckConfig
    {

        /// <summary>
        /// AlarmIdentifier
        /// 		
        /// A complex type that identifies the CloudWatch alarm that you want Amazon Route 53 health checkers to
        /// use to determine whether 			the specified health check is healthy.
        /// 	
        /// Required: No
        /// Type: AlarmIdentifier
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmIdentifier")]
        public AlarmIdentifier AlarmIdentifier { get; set; }

        /// <summary>
        /// ChildHealthChecks
        /// 		
        /// (CALCULATED Health Checks Only) A complex type that contains one ChildHealthCheck element for each
        /// health check that 			you want to associate with a CALCULATED health check.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChildHealthChecks")]
        public List<Union<string, IntrinsicFunction>> ChildHealthChecks { get; set; }

        /// <summary>
        /// EnableSNI
        /// 		
        /// Specify whether you want Amazon Route 53 to send the value of FullyQualifiedDomainName to the
        /// endpoint in the client_hello 			message during TLS negotiation. This allows the endpoint to respond
        /// to HTTPS health check requests with the applicable 			SSL/TLS certificate.
        /// 		
        /// Some endpoints require that HTTPS requests include the host name in the client_hello message. If you
        /// don&#39;t 			enable SNI, the status of the health check will be SSL alert handshake_failure. A health
        /// check can also have that status for 			other reasons. If SNI is enabled and you&#39;re still getting the
        /// error, check the SSL/TLS configuration on your endpoint and confirm that 			your certificate is
        /// valid.
        /// 		
        /// The SSL/TLS certificate on your endpoint includes a domain name in the Common Name field and
        /// possibly several more in the 			Subject Alternative Names field. One of the domain names in the
        /// certificate should match the value that you specify for 			FullyQualifiedDomainName. If the endpoint
        /// responds to the client_hello message with a certificate that does not 			include the domain name
        /// that you specified in FullyQualifiedDomainName, a health checker will retry the handshake. In the
        /// 			second attempt, the health checker will omit FullyQualifiedDomainName from the client_hello
        /// message.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableSNI")]
        public Union<bool, IntrinsicFunction> EnableSNI { get; set; }

        /// <summary>
        /// FailureThreshold
        /// 		
        /// The number of consecutive health checks that an endpoint must pass or fail for Amazon Route 53 to
        /// change the current status of the endpoint 			from unhealthy to healthy or vice versa. For more
        /// information, see 			How Amazon Route 53 Determines Whether an Endpoint Is Healthy 			in the Amazon
        /// Route 53 Developer Guide.
        /// 		
        /// If you don&#39;t specify a value for FailureThreshold, the default value is three health checks.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public Union<int, IntrinsicFunction> FailureThreshold { get; set; }

        /// <summary>
        /// FullyQualifiedDomainName
        /// 		
        /// Amazon Route 53 behavior depends on whether you specify a value for IPAddress.
        /// 		 		
        /// 			If you specify a value for 			IPAddress:
        /// 		
        /// Amazon Route 53 sends health check requests to the specified IPv4 or IPv6 address and passes the
        /// value of FullyQualifiedDomainName 			in the Host header for all health checks except TCP health
        /// checks. This is typically the fully qualified DNS name of the endpoint 			on which you want Route 53
        /// to perform health checks.
        /// 		
        /// When Route 53 checks the health of an endpoint, here is how it constructs the Host header:
        /// 		
        /// 			 			 			 		 				 If you specify a value of 80 for Port and HTTP or HTTP_STR_MATCH for 					Type,
        /// Route 53 passes the value of FullyQualifiedDomainName to the endpoint in the Host header. 			 				
        /// If you specify a value of 443 for Port and HTTPS or HTTPS_STR_MATCH for 					Type, Route 53 passes
        /// the value of FullyQualifiedDomainName to the endpoint in the Host header. 			 				 If you specify
        /// another value for Port and any value except TCP for Type, Route 53 passes
        /// 					FullyQualifiedDomainName:Port to the endpoint in the Host header. 			
        /// 		
        /// If you don&#39;t specify a value for FullyQualifiedDomainName, Route 53 substitutes the value of
        /// IPAddress in the 			Host header in each of the preceding cases.
        /// 		 		
        /// 			If you don&#39;t specify a value for IPAddress 			:
        /// 		
        /// Route 53 sends a DNS request to the domain that you specify for FullyQualifiedDomainName at the
        /// interval that you specify for 			RequestInterval. Using an IPv4 address that DNS returns, Route 53
        /// then checks the health of the endpoint.
        /// 		
        /// Note If you don&#39;t specify a value for IPAddress, Route 53 uses only IPv4 to send health checks to
        /// the endpoint. If there&#39;s 				no record with a type of A for the name that you specify for
        /// FullyQualifiedDomainName, the health check fails with a 				&quot;DNS resolution failed&quot; error.
        /// 		
        /// If you want to check the health of multiple records that have the same name and type, such as
        /// multiple weighted records, and if you 			choose to specify the endpoint only by
        /// FullyQualifiedDomainName, we recommend that you create a separate health check 			for each endpoint.
        /// For example, create a health check for each HTTP server that is serving content for www. example.
        /// com. For the value of 			FullyQualifiedDomainName, specify the domain name of the server (such as
        /// us-east-2-www. example. com), not the name of the 			records (www. example. com).
        /// 		
        /// Important In this configuration, if you create a health check for which the value of
        /// FullyQualifiedDomainName matches the name of the 				records and you then associate the health check
        /// with those records, health check results will be unpredictable.
        /// 		
        /// In addition, if the value that you specify for Type is HTTP, HTTPS, HTTP_STR_MATCH, or
        /// 			HTTPS_STR_MATCH, Route 53 passes the value of FullyQualifiedDomainName in the Host header, as it
        /// does when you 			specify a value for IPAddress. If the value of Type is TCP, Route 53 doesn&#39;t pass a
        /// Host header.
        /// 	
        /// Required: No
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FullyQualifiedDomainName")]
        public Union<string, IntrinsicFunction> FullyQualifiedDomainName { get; set; }

        /// <summary>
        /// HealthThreshold
        /// 		
        /// The number of child health checks that are associated with a CALCULATED health check that Amazon
        /// Route 53 must consider healthy for the 			CALCULATED health check to be considered healthy. To
        /// specify the child health checks that you want to associate with a 			CALCULATED health check, use
        /// the 			ChildHealthChecks 			element.
        /// 		
        /// Note the following:
        /// 		
        /// 			 			 		 				 If you specify a number greater than the number of child health checks, Route 53
        /// always considers this health check to be unhealthy. 			 				 If you specify 0, Route 53 always
        /// considers this health check to be healthy. 			
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HealthThreshold")]
        public Union<int, IntrinsicFunction> HealthThreshold { get; set; }

        /// <summary>
        /// IPAddress
        /// 		
        /// The IPv4 or IPv6 IP address of the endpoint that you want Amazon Route 53 to perform health checks
        /// on. If you don&#39;t specify a value for 			IPAddress, Route 53 sends a DNS request to resolve the
        /// domain name that you specify in FullyQualifiedDomainName 			at the interval that you specify in
        /// RequestInterval. Using an IP address returned by DNS, Route 53 then checks the health 			of the
        /// endpoint.
        /// 		
        /// Use one of the following formats for the value of IPAddress:
        /// 		
        /// 			 			 		 IPv4 address: four values between 0 and 255, separated by periods (. ), 				for example,
        /// 192. 0. 2. 44. IPv6 address: eight groups of four hexadecimal values, separated by colons (:),
        /// 				for example, 2001:0db8:85a3:0000:0000:abcd:0001:2345. You can also shorten IPv6 addresses as
        /// described in RFC 5952, 				for example, 2001:db8:85a3::abcd:1:2345.
        /// 		
        /// If the endpoint is an EC2 instance, we recommend that you create an Elastic IP address, associate it
        /// with your EC2 instance, and 			specify the Elastic IP address for IPAddress. This ensures that the
        /// IP address of your instance will never change.
        /// 		
        /// For more information, see 			FullyQualifiedDomainName. 		
        /// 		
        /// Constraints: Route 53 can&#39;t check the health of endpoints for which the IP address is in local,
        /// private, non-routable, or 			multicast ranges. For more information about IP addresses for which you
        /// can&#39;t create health checks, see the following 			documents:
        /// 		
        /// 			 			 			 		 RFC 5735, Special Use IPv4 Addresses RFC 6598, IANA-Reserved IPv4 Prefix for Shared
        /// Address Space RFC 5156, Special-Use IPv6 Addresses
        /// 		
        /// When the value of Type is CALCULATED or CLOUDWATCH_METRIC, omit IPAddress.
        /// 	
        /// Required: No
        /// Type: String
        /// Maximum: 45
        /// Pattern: (^((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.
        /// ){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))$|^(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.
        /// ){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.
        /// ){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IPAddress")]
        public Union<string, IntrinsicFunction> IPAddress { get; set; }

        /// <summary>
        /// InsufficientDataHealthStatus
        /// 		
        /// When CloudWatch has insufficient data about the metric to determine the alarm state, the status that
        /// you want Amazon Route 53 to assign to the health check:
        /// 		
        /// 			 			 			 		 				 Healthy: Route 53 considers the health check to be healthy. 			 				 Unhealthy:
        /// Route 53 considers the health check to be unhealthy. 			 				 LastKnownStatus: Route 53 uses the
        /// status of the health check from the last time that CloudWatch had sufficient data 					to determine
        /// the alarm state. For new health checks that have no last known status, the default status for the
        /// health check is 					healthy. 			
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed Values: Healthy | LastKnownStatus | Unhealthy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InsufficientDataHealthStatus")]
        public Union<string, IntrinsicFunction> InsufficientDataHealthStatus { get; set; }

        /// <summary>
        /// Inverted
        /// 		
        /// Specify whether you want Amazon Route 53 to invert the status of a health check, for example, to
        /// consider a health check unhealthy when it 			otherwise would be considered healthy.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Inverted")]
        public Union<bool, IntrinsicFunction> Inverted { get; set; }

        /// <summary>
        /// MeasureLatency
        /// 		
        /// Specify whether you want Amazon Route 53 to measure the latency between health checkers in multiple
        /// AWS regions and your endpoint, and to 			display CloudWatch latency graphs on the Health Checks page
        /// in the Route 53 console.
        /// 		
        /// Important You can&#39;t change the value of MeasureLatency after you create a health check.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MeasureLatency")]
        public Union<bool, IntrinsicFunction> MeasureLatency { get; set; }

        /// <summary>
        /// Port
        /// 		
        /// The port on the endpoint that you want Amazon Route 53 to perform health checks on.
        /// 		
        /// Note Don&#39;t specify a value for Port when you specify a value for 				Type 				of CLOUDWATCH_METRIC
        /// or CALCULATED.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// Regions
        /// 		
        /// A complex type that contains one Region element for each region from which you want Amazon Route 53
        /// health checkers to check the 			specified endpoint.
        /// 		
        /// If you don&#39;t specify any regions, Route 53 health checkers automatically performs checks from all of
        /// the regions that are listed under 			Valid Values.
        /// 		
        /// If you update a health check to remove a region that has been performing health checks, Route 53
        /// will briefly continue to perform checks 			from that region to ensure that some health checkers are
        /// always checking the endpoint (for example, if you replace three regions with 			four different
        /// regions).
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regions")]
        public List<Union<string, IntrinsicFunction>> Regions { get; set; }

        /// <summary>
        /// RequestInterval
        /// 		
        /// The number of seconds between the time that Amazon Route 53 gets a response from your endpoint and
        /// the time that it sends the next 			health check request. Each Route 53 health checker makes requests
        /// at this interval.
        /// 		
        /// Important You can&#39;t change the value of RequestInterval after you create a health check.
        /// 		
        /// If you don&#39;t specify a value for RequestInterval, the default value is 30 seconds.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 10
        /// Maximum: 30
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RequestInterval")]
        public Union<int, IntrinsicFunction> RequestInterval { get; set; }

        /// <summary>
        /// ResourcePath
        /// 		
        /// The path, if any, that you want Amazon Route 53 to request when performing health checks. The path
        /// can be any value for which your endpoint 			will return an HTTP status code of 2xx or 3xx when the
        /// endpoint is healthy, for example, the file /docs/route53-health-check. html. 			You can also include
        /// query string parameters, for example, /welcome. html?language=jp&amp;amp;login=y. 		
        /// 	
        /// Required: No
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourcePath")]
        public Union<string, IntrinsicFunction> ResourcePath { get; set; }

        /// <summary>
        /// SearchString
        /// 		
        /// If the value of Type is HTTP_STR_MATCH or HTTP_STR_MATCH, the string that you want Amazon Route 53
        /// to search for in the 			response body from the specified resource. If the string appears in the
        /// response body, Route 53 considers the resource healthy.
        /// 		
        /// Route 53 considers case when searching for SearchString in the response body.
        /// 	
        /// Required: No
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SearchString")]
        public Union<string, IntrinsicFunction> SearchString { get; set; }

        /// <summary>
        /// Type
        /// 		
        /// The type of health check that you want to create, which indicates how Amazon Route 53 determines
        /// whether an endpoint is healthy.
        /// 		
        /// Important You can&#39;t change the value of Type after you create a health check.
        /// 		
        /// You can create the following types of health checks:
        /// 		
        /// 			 			 			 			 			 			 			 		 				 HTTP: Route 53 tries to establish a TCP connection. If
        /// successful, Route 53 submits an HTTP request 					and waits for an HTTP status code of 200 or
        /// greater and less than 400. 			 				 HTTPS: Route 53 tries to establish a TCP connection. If
        /// successful, Route 53 submits an HTTPS request 					and waits for an HTTP status code of 200 or
        /// greater and less than 400. 				 Important If you specify HTTPS for the value of Type, the endpoint
        /// must support TLS v1. 0 or later. 			 				 HTTP_STR_MATCH: Route 53 tries to establish a TCP
        /// connection. If successful, Route 53 submits an 					HTTP request and searches the first 5,120 bytes
        /// of the response body for the string that you specify in SearchString. 			 				 HTTPS_STR_MATCH:
        /// Route 53 tries to establish a TCP connection. If successful, Route 53 submits an 					HTTPS request
        /// and searches the first 5,120 bytes of the response body for the string that you specify in
        /// SearchString. 			 				 TCP: Route 53 tries to establish a TCP connection. 			 				
        /// CLOUDWATCH_METRIC: The health check is associated with a CloudWatch alarm. If the state of the alarm
        /// is 					OK, the health check is considered healthy. If the state is ALARM, the health check is
        /// considered unhealthy. 					If CloudWatch doesn&#39;t have sufficient data to determine whether the state
        /// is OK or ALARM, the health check status 					depends on the setting for
        /// InsufficientDataHealthStatus: Healthy, Unhealthy, or 					LastKnownStatus. 			 				 CALCULATED: For
        /// health checks that monitor the status of other health checks, Route 53 adds up 					the number of
        /// health checks that Route 53 health checkers consider to be healthy and compares that number with the
        /// value of 					HealthThreshold. 			
        /// 		
        /// For more information, see 			How Route 53 			Determines Whether an Endpoint Is Healthy in the Amazon
        /// Route 53 Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: CALCULATED | CLOUDWATCH_METRIC | HTTP | HTTP_STR_MATCH | HTTPS | HTTPS_STR_MATCH |
        /// TCP
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
