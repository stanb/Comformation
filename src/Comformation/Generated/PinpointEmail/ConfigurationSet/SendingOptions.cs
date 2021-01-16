using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSet
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSet SendingOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-sendingoptions.html
    /// </summary>
    public class SendingOptions
    {

        /// <summary>
        /// SendingEnabled
        /// If true, email sending is enabled for the configuration set. If false, email sending is disabled for
        /// the configuration set.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SendingEnabled")]
        public Union<bool, IntrinsicFunction> SendingEnabled { get; set; }

    }
}
