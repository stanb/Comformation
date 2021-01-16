using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel PropertyType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-propertytype.html
    /// </summary>
    public class PropertyType
    {

        /// <summary>
        /// TypeName
        /// The type of property type, which can be one of Attribute, Measurement, Metric, or Transform.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TypeName")]
        public Union<string, IntrinsicFunction> TypeName { get; set; }

        /// <summary>
        /// Attribute
        /// Specifies an asset attribute property. An attribute generally contains static information, such as
        /// the serial number of an IIoT wind turbine.
        /// This is required if the TypeName is Attribute and has a DefaultValue.
        /// Required: No
        /// Type: Attribute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attribute")]
        public Attribute Attribute { get; set; }

        /// <summary>
        /// Transform
        /// Specifies an asset transform property. A transform contains a mathematical expression that maps a
        /// property&#39;s data points from one form to another, such as a unit conversion from Celsius to
        /// Fahrenheit.
        /// This is required if the TypeName is Transform.
        /// Required: No
        /// Type: Transform
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Transform")]
        public Transform Transform { get; set; }

        /// <summary>
        /// Metric
        /// Specifies an asset metric property. A metric contains a mathematical expression that uses aggregate
        /// functions to process all input data points over a time interval and output a single data point, such
        /// as to calculate the average hourly temperature.
        /// This is required if the TypeName is Metric.
        /// Required: No
        /// Type: Metric
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metric")]
        public Metric Metric { get; set; }

    }
}
