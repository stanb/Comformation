using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.Variable
{
    /// <summary>
    /// AWS::FraudDetector::Variable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-frauddetector-variable.html
    /// </summary>
    public class VariableResource : ResourceBase
    {
        public class VariableProperties
        {
            /// <summary>
            /// Name
            /// The name of the variable.
            /// Pattern: ^[0-9a-z_-]+$
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// DataSource
            /// The data source of the variable.
            /// Valid values: EVENT | EXTERNAL_MODEL_SCORE
            /// When defining a variable within a detector, you can only use the EVENT value for DataSource when the
            /// Inline property is set to true. If the Inline property is set false, you can use either EVENT or
            /// MODEL_SCORE for DataSource.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DataSource { get; set; }

            /// <summary>
            /// DataType
            /// The data type of the variable.
            /// Valid data types: STRING | INTEGER | BOOLEAN | FLOAT
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DataType { get; set; }

            /// <summary>
            /// DefaultValue
            /// The default value of the variable.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultValue { get; set; }

            /// <summary>
            /// Description
            /// The description of the variable.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VariableType
            /// The type of the variable. For more information see Variable types.
            /// Valid Values: AUTH_CODE | AVS | BILLING_ADDRESS_L1 | BILLING_ADDRESS_L2 | BILLING_CITY |
            /// BILLING_COUNTRY | BILLING_NAME | BILLING_PHONE | BILLING_STATE | BILLING_ZIP | CARD_BIN |
            /// CATEGORICAL | CURRENCY_CODE | EMAIL_ADDRESS | FINGERPRINT | FRAUD_LABEL | FREE_FORM_TEXT |
            /// IP_ADDRESS | NUMERIC | ORDER_ID | PAYMENT_TYPE | PHONE_NUMBER | PRICE | PRODUCT_CATEGORY |
            /// SHIPPING_ADDRESS_L1 | SHIPPING_ADDRESS_L2 | SHIPPING_CITY | SHIPPING_COUNTRY | SHIPPING_NAME |
            /// SHIPPING_PHONE | SHIPPING_STATE | SHIPPING_ZIP | USERAGENT
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VariableType { get; set; }

        }

        public string Type { get; } = "AWS::FraudDetector::Variable";

        public VariableProperties Properties { get; } = new VariableProperties();

    }

    public static class VariableAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
    }
}
