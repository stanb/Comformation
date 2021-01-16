using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool AccountRecoverySetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-accountrecoverysetting.html
    /// </summary>
    public class AccountRecoverySetting
    {

        /// <summary>
        /// RecoveryMechanisms
        /// The list of RecoveryOptionTypes.
        /// Required: No
        /// Type: List of RecoveryOption
        /// Maximum: 2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecoveryMechanisms")]
        public List<RecoveryOption> RecoveryMechanisms { get; set; }

    }
}
