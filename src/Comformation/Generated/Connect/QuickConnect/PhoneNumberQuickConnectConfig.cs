using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Connect.QuickConnect
{
    /// <summary>
    /// AWS::Connect::QuickConnect PhoneNumberQuickConnectConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-phonenumberquickconnectconfig.html
    /// </summary>
    public class PhoneNumberQuickConnectConfig
    {

        /// <summary>
        /// PhoneNumber
        /// The phone number in E. 164 format.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public Union<string, IntrinsicFunction> PhoneNumber { get; set; }

    }
}
