using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolUser
{
    /// <summary>
    /// AWS::Cognito::UserPoolUser AttributeType
    /// AttributeType is a property of the AWS::Cognito::UserPoolUser resource that defines name-value pairs for a
    /// user in an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooluser-attributetype.html
    /// </summary>
    public class AttributeType
    {

        /// <summary>
        /// Value
        /// The value of the attribute.
        /// Required: No
        /// Type: String
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name of the attribute.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 32
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
