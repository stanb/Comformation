using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataPipeline.Pipeline
{
    /// <summary>
    /// AWS Data Pipeline Pipeline Field
    /// Key-value pairs that describe the properties of a data pipeline object.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelineobjects-fields.html
    /// </summary>
    public class Field
    {

        /// <summary>
        /// Key
        /// Specifies the name of a field for a particular object. To view fields for a data pipeline object,
        /// see Pipeline Object Reference in the AWS Data Pipeline Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// RefValue
        /// A field value that you specify as an identifier of another object in the same pipeline definition.
        /// Note You can specify the field value as either a string value (StringValue) or a reference to
        /// another object (RefValue), but not both.
        /// Required: Conditional if the key that you are using requires it.
        /// Type: String
        /// </summary>
        [JsonProperty("RefValue")]
        public Union<string, IntrinsicFunction> RefValue { get; set; }

        /// <summary>
        /// StringValue
        /// A field value that you specify as a string. To view valid values for a particular field, see
        /// Pipeline Object Reference in the AWS Data Pipeline Developer Guide.
        /// Note You can specify the field value as either a string value (StringValue) or a reference to
        /// another object (RefValue), but not both.
        /// Required: Conditional if the key that you are using requires it.
        /// Type: String
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
