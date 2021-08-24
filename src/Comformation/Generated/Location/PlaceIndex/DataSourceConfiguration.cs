using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.PlaceIndex
{
    /// <summary>
    /// AWS::Location::PlaceIndex DataSourceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-placeindex-datasourceconfiguration.html
    /// </summary>
    public class DataSourceConfiguration
    {

        /// <summary>
        /// IntendedUse
        /// Specifies how the results of an operation will be stored by the caller.
        /// Valid values include:
        /// SingleUse specifies that the results won&#39;t be stored. Storage specifies that the result can be
        /// cached or stored in a database. Important Place index resources using HERE as a data provider can&#39;t
        /// be configured to store results for locations in Japan when choosing Storage for the IntendedUse
        /// parameter.
        /// Default value: SingleUse
        /// Required: No
        /// Type: String
        /// Allowed values: SingleUse | Storage
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IntendedUse")]
        public Union<string, IntrinsicFunction> IntendedUse { get; set; }

    }
}
