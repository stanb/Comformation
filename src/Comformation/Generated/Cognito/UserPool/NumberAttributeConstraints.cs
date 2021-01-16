using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool NumberAttributeConstraints
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-numberattributeconstraints.html
    /// </summary>
    public class NumberAttributeConstraints
    {

        /// <summary>
        /// MinValue
        /// The minimum value of an attribute that is of the number data type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinValue")]
        public Union<string, IntrinsicFunction> MinValue { get; set; }

        /// <summary>
        /// MaxValue
        /// The maximum value of an attribute that is of the number data type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxValue")]
        public Union<string, IntrinsicFunction> MaxValue { get; set; }

    }
}
