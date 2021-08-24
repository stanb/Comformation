using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Connect.QuickConnect
{
    /// <summary>
    /// AWS::Connect::QuickConnect UserQuickConnectConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-userquickconnectconfig.html
    /// </summary>
    public class UserQuickConnectConfig
    {

        /// <summary>
        /// ContactFlowArn
        /// The Amazon Resource Name (ARN) of the contact flow.
        /// Required: Yes
        /// Type: String
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContactFlowArn")]
        public Union<string, IntrinsicFunction> ContactFlowArn { get; set; }

        /// <summary>
        /// UserArn
        /// The Amazon Resource Name (ARN) of the user.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserArn")]
        public Union<string, IntrinsicFunction> UserArn { get; set; }

    }
}
