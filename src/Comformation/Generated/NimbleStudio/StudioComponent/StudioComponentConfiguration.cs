using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent StudioComponentConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studiocomponent-studiocomponentconfiguration.html
    /// </summary>
    public class StudioComponentConfiguration
    {

        /// <summary>
        /// ActiveDirectoryConfiguration
        /// The configuration for a Microsoft Active Directory (Microsoft AD) studio resource.
        /// Required: No
        /// Type: ActiveDirectoryConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActiveDirectoryConfiguration")]
        public ActiveDirectoryConfiguration ActiveDirectoryConfiguration { get; set; }

        /// <summary>
        /// ComputeFarmConfiguration
        /// The configuration for a render farm that is associated with a studio resource.
        /// Required: No
        /// Type: ComputeFarmConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeFarmConfiguration")]
        public ComputeFarmConfiguration ComputeFarmConfiguration { get; set; }

        /// <summary>
        /// LicenseServiceConfiguration
        /// The configuration for a license service that is associated with a studio resource.
        /// Required: No
        /// Type: LicenseServiceConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LicenseServiceConfiguration")]
        public LicenseServiceConfiguration LicenseServiceConfiguration { get; set; }

        /// <summary>
        /// SharedFileSystemConfiguration
        /// The configuration for a shared file storage system that is associated with a studio resource.
        /// Required: No
        /// Type: SharedFileSystemConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SharedFileSystemConfiguration")]
        public SharedFileSystemConfiguration SharedFileSystemConfiguration { get; set; }

    }
}
