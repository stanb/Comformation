using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.AccessPoint
{
    /// <summary>
    /// AWS::EFS::AccessPoint RootDirectory
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-rootdirectory.html
    /// </summary>
    public class RootDirectory
    {

        /// <summary>
        /// Path
        /// Specifies the path on the EFS file system to expose as the root directory to NFS clients using the
        /// access point to access the EFS file system. A path can have up to four subdirectories. If the
        /// specified path does not exist, you are required to provide the CreationInfo.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^(\/|(\/(?!\. )+[^$#&amp;lt;&amp;gt;;`|&amp;amp;?{}^*/\n]+){1,4})$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// CreationInfo
        /// (Optional) Specifies the POSIX IDs and permissions to apply to the access point&#39;s RootDirectory. If
        /// the RootDirectory &amp;gt; Path specified does not exist, EFS creates the root directory using the
        /// CreationInfo settings when a client connects to an access point. When specifying the CreationInfo,
        /// you must provide values for all properties.
        /// Important If you do not provide CreationInfo and the specified RootDirectory &amp;gt; Path does not
        /// exist, attempts to mount the file system using the access point will fail.
        /// Required: No
        /// Type: CreationInfo
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CreationInfo")]
        public CreationInfo CreationInfo { get; set; }

    }
}
