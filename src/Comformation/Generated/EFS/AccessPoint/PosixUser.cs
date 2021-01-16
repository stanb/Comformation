using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.AccessPoint
{
    /// <summary>
    /// AWS::EFS::AccessPoint PosixUser
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-posixuser.html
    /// </summary>
    public class PosixUser
    {

        /// <summary>
        /// Uid
        /// The POSIX user ID used for all file system operations using this access point.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Uid")]
        public Union<string, IntrinsicFunction> Uid { get; set; }

        /// <summary>
        /// Gid
        /// The POSIX group ID used for all file system operations using this access point.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Gid")]
        public Union<string, IntrinsicFunction> Gid { get; set; }

        /// <summary>
        /// SecondaryGids
        /// Secondary POSIX group IDs used for all file system operations using this access point.
        /// Required: No
        /// Type: List of String
        /// Maximum: 16
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecondaryGids")]
        public List<Union<string, IntrinsicFunction>> SecondaryGids { get; set; }

    }
}
