using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool SchemaAttribute
    /// SchemaAttribute is a property of the AWS::Cognito::UserPool resource that defines the schema attributes of an
    /// Amazon Cognito user pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html
    /// </summary>
    public class SchemaAttribute
    {

        /// <summary>
        /// DeveloperOnlyAttribute
        /// Specifies whether the attribute type is developer only.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeveloperOnlyAttribute")]
        public Union<bool, IntrinsicFunction> DeveloperOnlyAttribute { get; set; }

        /// <summary>
        /// Mutable
        /// Specifies whether the value of the attribute can be changed.
        /// For any user pool attribute that&#39;s mapped to an identity provider attribute, you must set this
        /// parameter to true. Amazon Cognito updates mapped attributes when users sign in to your application
        /// through an identity provider. If an attribute is immutable, Amazon Cognito throws an error when it
        /// attempts to update the attribute. For more information, see Specifying Identity Provider Attribute
        /// Mappings for Your User Pool.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mutable")]
        public Union<bool, IntrinsicFunction> Mutable { get; set; }

        /// <summary>
        /// AttributeDataType
        /// The attribute data type.
        /// Required: No
        /// Type: String
        /// Allowed Values: Boolean | DateTime | Number | String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeDataType")]
        public Union<string, IntrinsicFunction> AttributeDataType { get; set; }

        /// <summary>
        /// StringAttributeConstraints
        /// Specifies the constraints for an attribute of the string type.
        /// Required: No
        /// Type: StringAttributeConstraints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StringAttributeConstraints")]
        public StringAttributeConstraints StringAttributeConstraints { get; set; }

        /// <summary>
        /// Required
        /// Specifies whether a user pool attribute is required. If the attribute is required and the user does
        /// not provide a value, registration or sign-in will fail.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Required")]
        public Union<bool, IntrinsicFunction> Required { get; set; }

        /// <summary>
        /// NumberAttributeConstraints
        /// Specifies the constraints for an attribute of the number type.
        /// Required: No
        /// Type: NumberAttributeConstraints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumberAttributeConstraints")]
        public NumberAttributeConstraints NumberAttributeConstraints { get; set; }

        /// <summary>
        /// Name
        /// A schema attribute of the name type.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 20
        /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
