using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index JsonTokenTypeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jsontokentypeconfiguration.html
    /// </summary>
    public class JsonTokenTypeConfiguration
    {

        /// <summary>
        /// UserNameAttributeField
        /// The user name attribute field.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserNameAttributeField")]
        public Union<string, IntrinsicFunction> UserNameAttributeField { get; set; }

        /// <summary>
        /// GroupAttributeField
        /// The group attribute field.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupAttributeField")]
        public Union<string, IntrinsicFunction> GroupAttributeField { get; set; }

    }
}
