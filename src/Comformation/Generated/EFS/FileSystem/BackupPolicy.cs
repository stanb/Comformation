using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.FileSystem
{
    /// <summary>
    /// AWS::EFS::FileSystem BackupPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-backuppolicy.html
    /// </summary>
    public class BackupPolicy
    {

        /// <summary>
        /// Status
        /// Set the backup policy status for the file system.
        /// ENABLED - Turns automatic backups on for the file system. DISABLED - Turns automatic backups off for
        /// the file system.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DISABLED | DISABLING | ENABLED | ENABLING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
