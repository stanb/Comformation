using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Fleet
{
    /// <summary>
    /// AWS::AppStream::Fleet DomainJoinInfo
    /// The name of the directory and organizational unit (OU) to use to join a fleet to a Microsoft Active Directory
    /// domain.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-fleet-domainjoininfo.html
    /// </summary>
    public class DomainJoinInfo
    {

        /// <summary>
        /// OrganizationalUnitDistinguishedName
        /// The distinguished name of the organizational unit for computer accounts.
        /// Required: No
        /// Type: String
        /// Maximum: 2000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrganizationalUnitDistinguishedName")]
        public Union<string, IntrinsicFunction> OrganizationalUnitDistinguishedName { get; set; }

        /// <summary>
        /// DirectoryName
        /// The fully qualified name of the directory (for example, corp. example. com).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DirectoryName")]
        public Union<string, IntrinsicFunction> DirectoryName { get; set; }

    }
}
