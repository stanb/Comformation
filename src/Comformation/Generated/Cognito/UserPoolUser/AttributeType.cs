using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolUser
{
    /// <summary>
    /// Amazon Cognito UserPoolUser AttributeType
    /// AttributeType is a property of the AWS::Cognito::UserPoolUser resource that defines name-value pairs for a
    /// user in an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooluser-attributetype.html
    /// </summary>
    public class AttributeType
    {

        /// <summary>
        /// Value
        /// The value of the attribute.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name of the attribute.
        /// Type: String
        /// Required: Yes
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
