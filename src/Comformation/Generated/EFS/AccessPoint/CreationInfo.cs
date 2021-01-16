using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.AccessPoint
{
    /// <summary>
    /// AWS::EFS::AccessPoint CreationInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-creationinfo.html
    /// </summary>
    public class CreationInfo
    {

        /// <summary>
        /// OwnerUid
        /// Specifies the POSIX user ID to apply to the RootDirectory. Accepts values from 0 to 2^32
        /// (4294967295).
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OwnerUid")]
        public Union<string, IntrinsicFunction> OwnerUid { get; set; }

        /// <summary>
        /// OwnerGid
        /// Specifies the POSIX group ID to apply to the RootDirectory. Accepts values from 0 to 2^32
        /// (4294967295).
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OwnerGid")]
        public Union<string, IntrinsicFunction> OwnerGid { get; set; }

        /// <summary>
        /// Permissions
        /// Specifies the POSIX permissions to apply to the RootDirectory, in the format of an octal number
        /// representing the file&#39;s mode bits.
        /// Required: Yes
        /// Type: String
        /// Pattern: ^[0-7]{3,4}$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Permissions")]
        public Union<string, IntrinsicFunction> Permissions { get; set; }

    }
}
