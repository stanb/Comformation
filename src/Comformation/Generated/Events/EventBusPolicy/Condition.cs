using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.EventBusPolicy
{
    /// <summary>
    /// Amazon CloudWatch Events EventBusPolicy Condition
    /// The Condition property type enables you to grant event bus permissions to all the AWS accounts in an
    /// organization.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-eventbuspolicy-condition.html
    /// </summary>
    public class Condition
    {

        /// <summary>
        /// Type
        /// Currently, Type must be StringEquals
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// Specifies the ID of the AWS organization to which you want to grant permission.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// Currently, Key must be aws:PrincipalOrgID
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
