using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSet
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSet TrackingOptions
    /// An object that defines the tracking options for a configuration set. When you use Amazon Pinpoint to send an
    /// email, it contains an invisible image that&#39;s used to track when recipients open your email. If your email
    /// contains links, those links are changed slightly in order to track when recipients click them.
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
