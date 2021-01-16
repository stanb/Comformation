using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Gateway
{
    /// <summary>
    /// AWS::IoTSiteWise::Gateway GatewayCapabilitySummary
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewaycapabilitysummary.html
    /// </summary>
    public class GatewayCapabilitySummary
    {

        /// <summary>
        /// CapabilityNamespace
        /// The namespace of the capability configuration. For example, if you configure OPC-UA sources from the
        /// AWS IoT SiteWise console, your OPC-UA capability configuration has the namespace
        /// iotsitewise:opcuacollector:version, where version is a number such as 1.
        /// The maximum length is 512 characters with the pattern ^[a-zA-Z]+:[a-zA-Z]+:[0-9]+$.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapabilityNamespace")]
        public Union<string, IntrinsicFunction> CapabilityNamespace { get; set; }

        /// <summary>
        /// CapabilityConfiguration
        /// The JSON document that defines the configuration for the gateway capability. For more information,
        /// see Configuring data sources (CLI) in the AWS IoT SiteWise User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapabilityConfiguration")]
        public Union<string, IntrinsicFunction> CapabilityConfiguration { get; set; }

    }
}
