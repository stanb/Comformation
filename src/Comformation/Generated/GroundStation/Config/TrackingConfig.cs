using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config TrackingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-trackingconfig.html
    /// </summary>
    public class TrackingConfig
    {

        /// <summary>
        /// Autotrack
        /// Specifies whether or not to use autotrack. REMOVED specifies that program track should only be used
        /// during the contact. PREFERRED specifies that autotracking is preferred during the contact but
        /// fallback to program track if the signal is lost. REQUIRED specifies that autotracking is required
        /// during the contact and not to use program track if the signal is lost.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Autotrack")]
        public Union<string, IntrinsicFunction> Autotrack { get; set; }

    }
}
