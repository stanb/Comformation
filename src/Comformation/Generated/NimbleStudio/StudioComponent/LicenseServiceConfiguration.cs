using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent LicenseServiceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studiocomponent-licenseserviceconfiguration.html
    /// </summary>
    public class LicenseServiceConfiguration
    {

        /// <summary>
        /// Endpoint
        /// The endpoint of the license service that is accessed by the studio component resource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

    }
}
