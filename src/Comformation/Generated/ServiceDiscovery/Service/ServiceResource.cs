using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html
    /// </summary>
    public class ServiceResource : ResourceBase
    {
        public class ServiceProperties
        {
            /// <summary>
            /// Description
            /// The description of the service.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// HealthCheckCustomConfig
            /// A complex type that contains information about an optional custom health check.
            /// Important If you specify a health check configuration, you can specify either
            /// HealthCheckCustomConfig or HealthCheckConfig but not both.
            /// Required: No
            /// Type: HealthCheckCustomConfig
            /// Update requires: Replacement
            /// </summary>
            public HealthCheckCustomConfig HealthCheckCustomConfig { get; set; }

            /// <summary>
            /// DnsConfig
            /// A complex type that contains information about the Route&#160;53 DNS records that you want AWS Cloud Map
            /// to create when you register an instance.
            /// Required: No
            /// Type: DnsConfig
            /// Update requires: No interruption
            /// </summary>
            public DnsConfig DnsConfig { get; set; }

            /// <summary>
            /// NamespaceId
            /// The ID of the namespace that was used to create the service.
            /// Important You must specify a value for NamespaceId either for the service properties or for
            /// DnsConfig. Don&#39;t specify a value in both places.
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NamespaceId { get; set; }

            /// <summary>
            /// HealthCheckConfig
            /// Public DNS and HTTP namespaces only. A complex type that contains settings for an optional health
            /// check. If you specify settings for a health check, AWS Cloud Map associates the health check with
            /// the records that you specify in DnsConfig.
            /// For information about the charges for health checks, see Amazon Route&#160;53 Pricing.
            /// Required: No
            /// Type: HealthCheckConfig
            /// Update requires: No interruption
            /// </summary>
            public HealthCheckConfig HealthCheckConfig { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the service. Each tag consists of a key and an optional value, both of which you
            /// define. Tag keys can have a maximum character length of 128 characters, and tag values can have a
            /// maximum length of 256 characters.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: Updates are not supported.
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the service.
            /// Required: No
            /// Type: String
            /// Pattern: ((?=^. {1,127}$)^([a-zA-Z0-9_][a-zA-Z0-9-_]{0,61}[a-zA-Z0-9_]|[a-zA-Z0-9])(\.
            /// ([a-zA-Z0-9_][a-zA-Z0-9-_]{0,61}[a-zA-Z0-9_]|[a-zA-Z0-9]))*$)|(^\. $)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::Service";

        public ServiceProperties Properties { get; } = new ServiceProperties();

    }

    public static class ServiceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
