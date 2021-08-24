using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.Detector
{
    /// <summary>
    /// AWS::FraudDetector::Detector EventVariable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-frauddetector-detector-eventvariable.html
    /// </summary>
    public class EventVariable
    {

        /// <summary>
        /// Arn
        /// The event variable ARN.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// Inline
        /// Indicates whether the resource is defined within this CloudFormation template and impacts the
        /// create, update, and delete behavior of the stack. If the value is true, CloudFormation will
        /// create/update/delete the resource when creating/updating/deleting the stack. If the value is false,
        /// CloudFormation will validate that the object exists and then use it within the resource without
        /// making changes to the object.
        /// For example, when creating AWS::FraudDetector::Detector you must define at least two variables. You
        /// can set Inline=true for these variables and CloudFormation will create/update/delete the variables
        /// as part of stack operations. However, if you set Inline=false, CloudFormation will associate the
        /// variables to your detector but not execute any changes to the variables.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Inline")]
        public Union<bool, IntrinsicFunction> Inline { get; set; }

        /// <summary>
        /// Name
        /// The name of the event variable.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// DataSource
        /// The data source of the event variable.
        /// Valid values: EVENT | EXTERNAL_MODEL_SCORE
        /// When defining a variable within a detector, you can only use the EVENT value for DataSource when the
        /// Inline property is set to true. If the Inline property is set false, you can use either EVENT or
        /// MODEL_SCORE for DataSource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSource")]
        public Union<string, IntrinsicFunction> DataSource { get; set; }

        /// <summary>
        /// DataType
        /// The data type of the event variable.
        /// Valid values: STRING | INTEGER | BOOLEAN | FLOAT
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataType")]
        public Union<string, IntrinsicFunction> DataType { get; set; }

        /// <summary>
        /// DefaultValue
        /// The default value of the event variable.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultValue")]
        public Union<string, IntrinsicFunction> DefaultValue { get; set; }

        /// <summary>
        /// VariableType
        /// The type of event variable. For more information, see Variable types.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VariableType")]
        public Union<string, IntrinsicFunction> VariableType { get; set; }

        /// <summary>
        /// Description
        /// The description of the event variable.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Tags
        /// An array of key-value pairs to apply to this resource.
        /// For more information, see Tag.
        /// Required: No
        /// Type: List of Tag
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// CreatedTime
        /// Timestamp for when the event variable was created.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreatedTime")]
        public Union<string, IntrinsicFunction> CreatedTime { get; set; }

        /// <summary>
        /// LastUpdatedTime
        /// Timestamp for when the event variable was last updated.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LastUpdatedTime")]
        public Union<string, IntrinsicFunction> LastUpdatedTime { get; set; }

    }
}
