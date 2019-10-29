using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool StringAttributeConstraints
    /// The StringAttributeConstraints property type defines the string attribute constraints of an Amazon Cognito
    /// user pool. StringAttributeConstraints is a subproperty of the SchemaAttribute property type.
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
