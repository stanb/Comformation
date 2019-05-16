using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.EventBusPolicy
{
    /// <summary>
    /// AWS::Events::EventBusPolicy Condition
    /// A JSON string which you can use to limit the event bus permissions you are granting to only accounts that
    /// fulfill the condition. Currently, the only supported condition is membership in a certain AWS organization.
    /// The string must contain Type, Key, and Value fields. The Value field specifies the ID of the AWS organization.
    /// Following is an example value for Condition:
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-eventbuspolicy-condition.html
    /// </summary>
    public class Condition
    {

        /// <summary>
        /// Type
        /// Specifies the type of condition. Currently the only supported value is StringEquals.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// Specifies the value for the key. Currently, this must be the ID of the organization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// Specifies the key for the condition. Currently the only supported key is aws:PrincipalOrgID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
