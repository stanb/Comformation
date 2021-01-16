using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationNFS
{
    /// <summary>
    /// AWS::DataSync::LocationNFS MountOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationnfs-mountoptions.html
    /// </summary>
    public class MountOptions
    {

        /// <summary>
        /// Version
        /// The specific NFS version that you want DataSync to use to mount your NFS share. If the server
        /// refuses to use the version specified, the sync will fail. If you don&#39;t specify a version, DataSync
        /// defaults to AUTOMATIC. That is, DataSync automatically selects a version based on negotiation with
        /// the NFS server.
        /// You can specify the following NFS versions:
        /// NFSv3 - stateless protocol version that allows for asynchronous writes on the server. NFSv4. 0 -
        /// stateful, firewall-friendly protocol version that supports delegations and pseudo filesystems.
        /// NFSv4. 1 - stateful protocol version that supports sessions, directory delegations, and parallel
        /// data processing. Version 4. 1 also includes all features available in version 4. 0.
        /// Required: No
        /// Type: String
        /// Allowed values: AUTOMATIC | NFS3 | NFS4_0 | NFS4_1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
