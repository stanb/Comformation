using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet GeoSpatialColumnGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-geospatialcolumngroup.html
    /// </summary>
    public class GeoSpatialColumnGroup
    {

        /// <summary>
        /// Columns
        /// Columns in this hierarchy.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 16
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Columns")]
        public List<Union<string, IntrinsicFunction>> Columns { get; set; }

        /// <summary>
        /// CountryCode
        /// Country code.
        /// Required: No
        /// Type: String
        /// Allowed values: US
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CountryCode")]
        public Union<string, IntrinsicFunction> CountryCode { get; set; }

        /// <summary>
        /// Name
        /// A display name for the hierarchy.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
