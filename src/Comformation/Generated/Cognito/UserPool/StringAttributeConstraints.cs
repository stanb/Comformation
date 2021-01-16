using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool StringAttributeConstraints
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-stringattributeconstraints.html
    /// </summary>
    public class StringAttributeConstraints
    {

        /// <summary>
        /// MinLength
        /// The minimum length.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinLength")]
        public Union<string, IntrinsicFunction> MinLength { get; set; }

        /// <summary>
        /// MaxLength
        /// The maximum length.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxLength")]
        public Union<string, IntrinsicFunction> MaxLength { get; set; }

    }
}
