using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool SchemaAttribute
    /// SchemaAttribute is a property of the AWS::Cognito::UserPool resource that defines the schema attributes of an
    /// Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html
    /// </summary>
    public class SchemaAttribute
    {

        /// <summary>
        /// DeveloperOnlyAttribute
        /// Specifies whether the attribute type is developer only.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("DeveloperOnlyAttribute")]
        public Union<bool, IntrinsicFunction> DeveloperOnlyAttribute { get; set; }

        /// <summary>
        /// Mutable
        /// Specifies whether the attribute can be changed after it has been created. True means mutable and
        /// False means immutable.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("Mutable")]
        public Union<bool, IntrinsicFunction> Mutable { get; set; }

        /// <summary>
        /// AttributeDataType
        /// The attribute data type. Can be one of the following: String, Number, DateTime, or Boolean.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("AttributeDataType")]
        public Union<string, IntrinsicFunction> AttributeDataType { get; set; }

        /// <summary>
        /// StringAttributeConstraints
        /// Specifies the constraints for an attribute of the string type.
        /// Type: Amazon Cognito UserPool StringAttributeConstraints
        /// Required: No
        /// </summary>
        [JsonProperty("StringAttributeConstraints")]
        public Union<StringAttributeConstraints, IntrinsicFunction> StringAttributeConstraints { get; set; }

        /// <summary>
        /// Required
        /// Specifies whether a user pool attribute is required. If the attribute is required and the user does
        /// not provide a value, registration or sign-in fails.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("Required")]
        public Union<bool, IntrinsicFunction> Required { get; set; }

        /// <summary>
        /// NumberAttributeConstraints
        /// Specifies the constraints for an attribute of the number type.
        /// Type: Amazon Cognito UserPool NumberAttributeConstraints
        /// Required: No
        /// </summary>
        [JsonProperty("NumberAttributeConstraints")]
        public Union<NumberAttributeConstraints, IntrinsicFunction> NumberAttributeConstraints { get; set; }

        /// <summary>
        /// Name
        /// A schema attribute of the name type.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
