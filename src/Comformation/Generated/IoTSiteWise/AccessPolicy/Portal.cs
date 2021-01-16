using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AccessPolicy
{
    /// <summary>
    /// AWS::IoTSiteWise::AccessPolicy Portal
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-portal.html
    /// </summary>
    public class Portal
    {

        /// <summary>
        /// id
        /// The ID of the portal.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("id")]
        public Union<string, IntrinsicFunction> id { get; set; }

    }
}
