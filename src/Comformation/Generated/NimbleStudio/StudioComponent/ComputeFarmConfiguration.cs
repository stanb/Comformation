using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent ComputeFarmConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studiocomponent-computefarmconfiguration.html
    /// </summary>
    public class ComputeFarmConfiguration
    {

        /// <summary>
        /// ActiveDirectoryUser
        /// The name of an Active Directory user that is used on ComputeFarm worker instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActiveDirectoryUser")]
        public Union<string, IntrinsicFunction> ActiveDirectoryUser { get; set; }

        /// <summary>
        /// Endpoint
        /// The endpoint of the ComputeFarm that is accessed by the studio component resource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

    }
}
