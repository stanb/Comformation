using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent ActiveDirectoryComputerAttribute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studiocomponent-activedirectorycomputerattribute.html
    /// </summary>
    public class ActiveDirectoryComputerAttribute
    {

        /// <summary>
        /// Name
        /// The name for the LDAP attribute.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value for the LDAP attribute.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
