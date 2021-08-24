using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.Map
{
    /// <summary>
    /// AWS::Location::Map MapConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-map-mapconfiguration.html
    /// </summary>
    public class MapConfiguration
    {

        /// <summary>
        /// Style
        /// Specifies the map style selected from an available data provider.
        /// Valid styles: VectorEsriStreets, VectorEsriTopographic, VectorEsriNavigation,
        /// VectorEsriDarkGrayCanvas, VectorEsriLightGrayCanvas, VectorHereBerlin.
        /// Note When using HERE as your data provider, and selecting the Style VectorHereBerlin, you may not
        /// use HERE Maps for Asset Management. See the AWS Service Terms for Amazon Location Service.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[-. _\w]+$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Style")]
        public Union<string, IntrinsicFunction> Style { get; set; }

    }
}
