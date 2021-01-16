using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Portal
{
    /// <summary>
    /// AWS::IoTSiteWise::Portal MonitorErrorDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-portal-monitorerrordetails.html
    /// </summary>
    public class MonitorErrorDetails
    {

        /// <summary>
        /// code
        /// The error code.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("code")]
        public Union<string, IntrinsicFunction> code { get; set; }

        /// <summary>
        /// message
        /// The error message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("message")]
        public Union<string, IntrinsicFunction> message { get; set; }

    }
}
