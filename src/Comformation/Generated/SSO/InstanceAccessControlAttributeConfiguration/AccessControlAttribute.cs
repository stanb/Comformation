using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSO.InstanceAccessControlAttributeConfiguration
{
    /// <summary>
    /// AWS::SSO::InstanceAccessControlAttributeConfiguration AccessControlAttribute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute.html
    /// </summary>
    public class AccessControlAttribute
    {

        /// <summary>
        /// Key
        /// The name of the attribute associated with your identities in your identity source. This is used to
        /// map a specified attribute in your identity source with an attribute in AWS SSO.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: [\p{L}\p{Z}\p{N}_. :\/=+\-@]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value used for mapping a specified attribute to an identity source.
        /// Required: Yes
        /// Type: AccessControlAttributeValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public AccessControlAttributeValue Value { get; set; }

    }
}
