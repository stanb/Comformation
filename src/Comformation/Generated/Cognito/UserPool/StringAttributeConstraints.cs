using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool StringAttributeConstraints
    /// The StringAttributeConstraints property type defines the string attribute constraints of an Amazon Cognito
    /// User Pool. StringAttributeConstraints is a subproperty of the Amazon Cognito UserPool SchemaAttribute property
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-stringattributeconstraints.html
    /// </summary>
    public class StringAttributeConstraints
    {

        /// <summary>
        /// MinLength
        /// The minimum value of an attribute that is of the string data type.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("MinLength")]
        public Union<string, IntrinsicFunction> MinLength { get; set; }

        /// <summary>
        /// MaxLength
        /// The maximum value of an attribute that is of the string data type.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("MaxLength")]
        public Union<string, IntrinsicFunction> MaxLength { get; set; }

    }
}
