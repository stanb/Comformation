using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Gateway
{
    /// <summary>
    /// AWS::IoTSiteWise::Gateway Greengrass
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-greengrass.html
    /// </summary>
    public class Greengrass
    {

        /// <summary>
        /// GroupArn
        /// The ARN of the Greengrass group. For more information about how to find a group&#39;s ARN, see
        /// ListGroups and GetGroup in the AWS IoT Greengrass API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroupArn")]
        public Union<string, IntrinsicFunction> GroupArn { get; set; }

    }
}
