using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent ActiveDirectoryConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studiocomponent-activedirectoryconfiguration.html
    /// </summary>
    public class ActiveDirectoryConfiguration
    {

        /// <summary>
        /// ComputerAttributes
        /// A collection of custom attributes for an Active Directory computer.
        /// Required: No
        /// Type: List of ActiveDirectoryComputerAttribute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputerAttributes")]
        public List<ActiveDirectoryComputerAttribute> ComputerAttributes { get; set; }

        /// <summary>
        /// DirectoryId
        /// The directory ID of the AWS Directory Service for Microsoft Active Directory to access using this
        /// studio component.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DirectoryId")]
        public Union<string, IntrinsicFunction> DirectoryId { get; set; }

        /// <summary>
        /// OrganizationalUnitDistinguishedName
        /// The distinguished name (DN) and organizational unit (OU) of an Active Directory computer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrganizationalUnitDistinguishedName")]
        public Union<string, IntrinsicFunction> OrganizationalUnitDistinguishedName { get; set; }

    }
}
