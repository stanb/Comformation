using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Gateway
{
    /// <summary>
    /// AWS::IoTSiteWise::Gateway GatewayPlatform
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html
    /// </summary>
    public class GatewayPlatform
    {

        /// <summary>
        /// Greengrass
        /// A gateway that runs on AWS IoT Greengrass.
        /// Required: Yes
        /// Type: Greengrass
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Greengrass")]
        public Greengrass Greengrass { get; set; }

    }
}
