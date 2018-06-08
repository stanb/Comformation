using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool NumberAttributeConstraints
    /// The NumberAttributeConstraints property type defines the number attribute constraints of an Amazon Cognito
    /// User Pool. NumberAttributeConstraints is a subproperty of the Amazon Cognito UserPool SchemaAttribute property
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-numberattributeconstraints.html
    /// </summary>
    public class NumberAttributeConstraints
    {

        /// <summary>
        /// MinValue
        /// The minimum value of an attribute that is of the number data type.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("MinValue")]
        public Union<string, IntrinsicFunction> MinValue { get; set; }

        /// <summary>
        /// MaxValue
        /// The maximum value of an attribute that is of the number data type.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("MaxValue")]
        public Union<string, IntrinsicFunction> MaxValue { get; set; }

    }
}
