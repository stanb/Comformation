using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index UserTokenConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-usertokenconfiguration.html
    /// </summary>
    public class UserTokenConfiguration
    {

        /// <summary>
        /// JwtTokenTypeConfiguration
        /// Information about the JWT token type configuration.
        /// Required: No
        /// Type: JwtTokenTypeConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JwtTokenTypeConfiguration")]
        public JwtTokenTypeConfiguration JwtTokenTypeConfiguration { get; set; }

        /// <summary>
        /// JsonTokenTypeConfiguration
        /// Information about the JSON token type configuration.
        /// Required: No
        /// Type: JsonTokenTypeConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonTokenTypeConfiguration")]
        public JsonTokenTypeConfiguration JsonTokenTypeConfiguration { get; set; }

    }
}
