using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Gateway
{
    /// <summary>
    /// AWS::IoTSiteWise::Gateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html
    /// </summary>
    public class GatewayResource : ResourceBase
    {
        public class GatewayProperties
        {
            /// <summary>
            /// GatewayName
            /// A unique, friendly name for the gateway.
            /// The maximum length is 256 characters with the pattern [^\u0000-\u001F\u007F]+.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GatewayName { get; set; }

            /// <summary>
            /// GatewayPlatform
            /// The gateway&#39;s platform. You can only specify one platform in a gateway.
            /// Required: Yes
            /// Type: GatewayPlatform
            /// Update requires: Replacement
            /// </summary>
            public GatewayPlatform GatewayPlatform { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs that contain metadata for the gateway. For more information, see Tagging
            /// your AWS IoT SiteWise resources in the AWS IoT SiteWise User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// GatewayCapabilitySummaries
            /// A list of gateway capability summaries that each contain a namespace and status. Each gateway
            /// capability defines data sources for the gateway. To retrieve a capability configuration&#39;s
            /// definition, use DescribeGatewayCapabilityConfiguration.
            /// Required: No
            /// Type: List of GatewayCapabilitySummary
            /// Update requires: No interruption
            /// </summary>
            public List<GatewayCapabilitySummary> GatewayCapabilitySummaries { get; set; }

        }

        public string Type { get; } = "AWS::IoTSiteWise::Gateway";

        public GatewayProperties Properties { get; } = new GatewayProperties();

    }

    public static class GatewayAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GatewayId = new ResourceAttribute<Union<string, IntrinsicFunction>>("GatewayId");
    }
}
