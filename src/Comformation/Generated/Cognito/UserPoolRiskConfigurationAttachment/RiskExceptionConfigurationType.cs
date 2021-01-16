using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment RiskExceptionConfigurationType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-riskexceptionconfigurationtype.html
    /// </summary>
    public class RiskExceptionConfigurationType
    {

        /// <summary>
        /// BlockedIPRangeList
        /// Overrides the risk decision to always block the pre-authentication requests. The IP range is in CIDR
        /// notation: a compact representation of an IP address and its associated routing prefix.
        /// Required: No
        /// Type: List of String
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockedIPRangeList")]
        public List<Union<string, IntrinsicFunction>> BlockedIPRangeList { get; set; }

        /// <summary>
        /// SkippedIPRangeList
        /// Risk detection is not performed on the IP addresses in the range list. The IP range is in CIDR
        /// notation.
        /// Required: No
        /// Type: List of String
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkippedIPRangeList")]
        public List<Union<string, IntrinsicFunction>> SkippedIPRangeList { get; set; }

    }
}
