using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet ColumnGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columngroup.html
    /// </summary>
    public class ColumnGroup
    {

        /// <summary>
        /// GeoSpatialColumnGroup
        /// Geospatial column group that denotes a hierarchy.
        /// Required: No
        /// Type: GeoSpatialColumnGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GeoSpatialColumnGroup")]
        public GeoSpatialColumnGroup GeoSpatialColumnGroup { get; set; }

    }
}
