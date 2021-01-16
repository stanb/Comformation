using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Portal
{
    /// <summary>
    /// AWS::IoTSiteWise::Portal PortalStatus
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-portal-portalstatus.html
    /// </summary>
    public class PortalStatus
    {

        /// <summary>
        /// error
        /// Contains associated error information, if any.
        /// Required: No
        /// Type: MonitorErrorDetails
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("error")]
        public MonitorErrorDetails error { get; set; }

        /// <summary>
        /// state
        /// The current state of the portal.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("state")]
        public Union<string, IntrinsicFunction> state { get; set; }

    }
}
