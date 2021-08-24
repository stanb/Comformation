using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSO.InstanceAccessControlAttributeConfiguration
{
    /// <summary>
    /// AWS::SSO::InstanceAccessControlAttributeConfiguration AccessControlAttributeValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributevalue.html
    /// </summary>
    public class AccessControlAttributeValue
    {

        /// <summary>
        /// Source
        /// The identity source to use when mapping a specified attribute to AWS SSO.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public List<Union<string, IntrinsicFunction>> Source { get; set; }

    }
}
