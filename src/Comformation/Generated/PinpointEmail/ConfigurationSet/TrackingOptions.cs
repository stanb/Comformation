using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSet
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSet TrackingOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-trackingoptions.html
    /// </summary>
    public class TrackingOptions
    {

        /// <summary>
        /// CustomRedirectDomain
        /// The domain that you want to use for tracking open and click events.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomRedirectDomain")]
        public Union<string, IntrinsicFunction> CustomRedirectDomain { get; set; }

    }
}
