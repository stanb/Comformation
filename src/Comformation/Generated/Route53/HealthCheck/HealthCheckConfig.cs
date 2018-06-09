using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// Route&#160;53 HealthCheck HealthCheckConfig
    /// The HealthCheckConfig property is part of the AWS::Route53::HealthCheck resource that describes a health check
    /// that Amazon Route&#160;53 uses before responding to a DNS query. For more information, see HealthCheckConfig in the
    /// Amazon Route&#160;53 API Reference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthcheck-healthcheckconfig.html
    /// </summary>
    public class HealthCheckConfig
    {

        /// <summary>
        /// AlarmIdentifier
        /// Identifies the CloudWatch alarm that you want Route&#160;53 health checkers to use to determine whether
        /// this health check is healthy.
        /// Type: Amazon Route&#160;53 HealthCheck AlarmIdentifier
        /// Required: No
        /// </summary>
        [JsonProperty("AlarmIdentifier")]
        public Union<AlarmIdentifier, IntrinsicFunction> AlarmIdentifier { get; set; }

        /// <summary>
        /// ChildHealthChecks
        /// (CALCULATED Health Checks Only) A complex type that contains one ChildHealthCheck element for each
        /// health check that you want to associate with a CALCULATED health check.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("ChildHealthChecks")]
        public Union<List<string>, IntrinsicFunction> ChildHealthChecks { get; set; }

        /// <summary>
        /// EnableSNI
        /// Specifies whether you want Route&#160;53 to send the value of FullyQualifiedDomainName to the endpoint in
        /// the client_hello message during TLS negotiation. This allows the endpoint to respond to HTTPS health
        /// check requests with the applicable SSL/TLS certificate. For more information, see http://docs. aws.
        /// amazon. com/Route53/latest/APIReference/API_HealthCheckConfig. html.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("EnableSNI")]
        public Union<bool, IntrinsicFunction> EnableSNI { get; set; }

        /// <summary>
        /// FailureThreshold
        /// The number of consecutive health checks that an endpoint must pass or fail for Route&#160;53 to change
        /// the current status of the endpoint from unhealthy to healthy or healthy to unhealthy. For more
        /// information, see How Amazon Route&#160;53 Determines Whether an Endpoint Is Healthy in the Amazon
        /// Route&#160;53 Developer Guide.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public Union<int, IntrinsicFunction> FailureThreshold { get; set; }

        /// <summary>
        /// FullyQualifiedDomainName
        /// If you specified the IPAddress property, the value that you want Route&#160;53 to pass in the host header
        /// in all health checks except for TCP health checks. If you don&#39;t specify an IP address, the domain
        /// that Route&#160;53 sends a DNS request to. Route&#160;53 uses the IP address that the DNS returns to check the
        /// health of the endpoint.
        /// Required: Conditional
        /// Type: String
        /// </summary>
        [JsonProperty("FullyQualifiedDomainName")]
        public Union<string, IntrinsicFunction> FullyQualifiedDomainName { get; set; }

        /// <summary>
        /// HealthThreshold
        /// The number of child health checks that are associated with a CALCULATED health that Route&#160;53 must
        /// consider healthy for the CALCULATED health check to be considered healthy.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("HealthThreshold")]
        public Union<int, IntrinsicFunction> HealthThreshold { get; set; }

        /// <summary>
        /// IPAddress
        /// The IPv4 IP address of the endpoint on which you want Route&#160;53 to perform health checks. If you
        /// don&#39;t specify an IP address, Route&#160;53 sends a DNS request to resolve the domain name that you
        /// specify in the FullyQualifiedDomainName property.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("IPAddress")]
        public Union<string, IntrinsicFunction> IPAddress { get; set; }

        /// <summary>
        /// InsufficientDataHealthStatus
        /// When Amazon CloudWatch has insufficient data about the metric to determine the alarm state, the
        /// status that you want Route&#160;53 to assign to the health check (Healthy, Unhealthy, or
        /// LastKnownStatus).
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("InsufficientDataHealthStatus")]
        public Union<string, IntrinsicFunction> InsufficientDataHealthStatus { get; set; }

        /// <summary>
        /// Inverted
        /// Specifies whether you want Route&#160;53 to invert the status of a health check, for example, to consider
        /// a health check unhealthy when it otherwise would be considered healthy.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Inverted")]
        public Union<bool, IntrinsicFunction> Inverted { get; set; }

        /// <summary>
        /// MeasureLatency
        /// Specifies whether you want Route&#160;53 to measure the latency between health checkers in multiple AWS
        /// regions and your endpoint and display CloudWatch latency graphs on the Health Checks page in the
        /// Route&#160;53 console.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MeasureLatency")]
        public Union<bool, IntrinsicFunction> MeasureLatency { get; set; }

        /// <summary>
        /// Port
        /// The port on the endpoint on which you want Route&#160;53 to perform health checks.
        /// Required: Conditional. Required when you specify TCP for the Type property.
        /// Type: Integer
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// Regions
        /// The regions from which you want Amazon Route 53 health checkers to check the specified endpoint.
        /// Duplicates are not allowed. For valid values and more information, see HealthCheckConfig in the
        /// Amazon Route&#160;53 API Reference.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regions")]
        public Union<List<string>, IntrinsicFunction> Regions { get; set; }

        /// <summary>
        /// RequestInterval
        /// The number of seconds between the time that Route&#160;53 gets a response from your endpoint and the time
        /// that it sends the next health check request. Each Route&#160;53 health checker makes requests at this
        /// interval. For valid values, see the RequestInterval element in the Amazon Route&#160;53 API Reference.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RequestInterval")]
        public Union<int, IntrinsicFunction> RequestInterval { get; set; }

        /// <summary>
        /// ResourcePath
        /// The path that you want Route&#160;53 to request when performing health checks. The path can be any value
        /// for which your endpoint returns an HTTP status code of 2xx or 3xx when the endpoint is healthy, such
        /// as /docs/route53-health-check. html.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ResourcePath")]
        public Union<string, IntrinsicFunction> ResourcePath { get; set; }

        /// <summary>
        /// SearchString
        /// If the value of the Type property is HTTP_STR_MATCH or HTTPS_STR_MATCH, the string that you want
        /// Route&#160;53 to search for in the response body from the specified resource. If the string appears in
        /// the response body, Route&#160;53 considers the resource healthy.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SearchString")]
        public Union<string, IntrinsicFunction> SearchString { get; set; }

        /// <summary>
        /// Type
        /// The type of health check that you want to create. This indicates how Route&#160;53 determines whether an
        /// endpoint is healthy. You can specify HTTP, HTTPS, HTTP_STR_MATCH, HTTPS_STR_MATCH, or TCP. For
        /// information about the different types, see the Type element in the Amazon Route&#160;53 API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
