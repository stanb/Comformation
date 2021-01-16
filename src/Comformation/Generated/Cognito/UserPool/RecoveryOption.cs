using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool RecoveryOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-recoveryoption.html
    /// </summary>
    public class RecoveryOption
    {

        /// <summary>
        /// Priority
        /// A positive integer specifying priority of a method with 1 being the highest priority.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// Name
        /// Specifies the recovery method for a user.
        /// Required: No
        /// Type: String
        /// Allowed values: admin_only | verified_email | verified_phone_number
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
