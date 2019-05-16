using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// AWS::Cognito::IdentityPoolRoleAttachment MappingRule
    /// Defines how to map a claim to a role ARN.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-mappingrule.html
    /// </summary>
    public class MappingRule
    {

        /// <summary>
        /// MatchType
        /// The match condition that specifies how closely the claim value in the IdP token must match Value.
        /// Valid values are: Equals, Contains, StartsWith, and NotEqual.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchType")]
        public Union<string, IntrinsicFunction> MatchType { get; set; }

        /// <summary>
        /// Value
        /// A brief string that the claim must match, for example, &quot;paid&quot; or &quot;yes. &quot;
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Claim
        /// The claim name that must be present in the token, for example, &quot;isAdmin&quot; or &quot;paid. &quot;
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Claim")]
        public Union<string, IntrinsicFunction> Claim { get; set; }

        /// <summary>
        /// RoleARN
        /// The Amazon Resource Name (ARN) of the role.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
