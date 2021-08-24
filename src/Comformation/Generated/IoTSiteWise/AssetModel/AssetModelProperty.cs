using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel AssetModelProperty
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-assetmodelproperty.html
    /// </summary>
    public class AssetModelProperty
    {

        /// <summary>
        /// LogicalId
        /// The LogicalID of the asset model property.
        /// The maximum length is 256 characters, with the pattern [^\\u0000-\\u001F\\u007F]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogicalId")]
        public Union<string, IntrinsicFunction> LogicalId { get; set; }

        /// <summary>
        /// Name
        /// The name of the asset model property.
        /// The maximum length is 256 characters with the pattern [^\u0000-\u001F\u007F]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// DataType
        /// The data type of the asset model property. The value can be STRING, INTEGER, DOUBLE, BOOLEAN, or
        /// STRUCT.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataType")]
        public Union<string, IntrinsicFunction> DataType { get; set; }

        /// <summary>
        /// DataTypeSpec
        /// The data type of the structure for this property. This parameter exists on properties that have the
        /// STRUCT data type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataTypeSpec")]
        public Union<string, IntrinsicFunction> DataTypeSpec { get; set; }

        /// <summary>
        /// Unit
        /// The unit of the asset model property, such as Newtons or RPM.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

        /// <summary>
        /// Type
        /// Contains a property type, which can be one of attribute, measurement, metric, or transform.
        /// Required: Yes
        /// Type: PropertyType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public PropertyType Type { get; set; }

    }
}
