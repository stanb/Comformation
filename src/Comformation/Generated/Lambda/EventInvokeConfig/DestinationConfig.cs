using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventInvokeConfig
{
    /// <summary>
    /// AWS::Lambda::EventInvokeConfig DestinationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventinvokeconfig-destinationconfig.html
    /// </summary>
    public class DestinationConfig
    {

        /// <summary>
        /// OnSuccess
        /// The destination configuration for successful invocations.
        /// Required: No
        /// Type: OnSuccess
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnSuccess")]
        public OnSuccess OnSuccess { get; set; }

        /// <summary>
        /// OnFailure
        /// The destination configuration for failed invocations.
        /// Required: No
        /// Type: OnFailure
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnFailure")]
        public OnFailure OnFailure { get; set; }

    }
}
