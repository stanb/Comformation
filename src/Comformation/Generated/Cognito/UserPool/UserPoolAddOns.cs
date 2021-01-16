using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool UserPoolAddOns
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-userpooladdons.html
    /// </summary>
    public class UserPoolAddOns
    {

        /// <summary>
        /// AdvancedSecurityMode
        /// The advanced security mode.
        /// Required: No
        /// Type: String
        /// Allowed values: AUDIT | ENFORCED | OFF
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdvancedSecurityMode")]
        public Union<string, IntrinsicFunction> AdvancedSecurityMode { get; set; }

    }
}
