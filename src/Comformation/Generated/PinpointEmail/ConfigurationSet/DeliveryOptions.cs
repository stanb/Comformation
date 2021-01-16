using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSet
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSet DeliveryOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-deliveryoptions.html
    /// </summary>
    public class DeliveryOptions
    {

        /// <summary>
        /// SendingPoolName
        /// The name of the dedicated IP pool that you want to associate with the configuration set.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SendingPoolName")]
        public Union<string, IntrinsicFunction> SendingPoolName { get; set; }

    }
}
