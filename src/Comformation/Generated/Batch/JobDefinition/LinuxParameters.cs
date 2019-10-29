using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition LinuxParameters
    /// Linux-specific modifications that are applied to the container, such as details for device mappings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html
    /// </summary>
    public class LinuxParameters
    {

        /// <summary>
        /// Devices
        /// Any host devices to expose to the container. This parameter maps to Devices in the Create a
        /// container section of the Docker Remote API and the --device option to docker run.
        /// Required: No
        /// Type: List of Device
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Devices")]
        public List<Device> Devices { get; set; }

    }
}
