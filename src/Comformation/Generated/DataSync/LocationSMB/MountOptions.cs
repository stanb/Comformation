using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationSMB
{
    /// <summary>
    /// AWS::DataSync::LocationSMB MountOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationsmb-mountoptions.html
    /// </summary>
    public class MountOptions
    {

        /// <summary>
        /// Version
        /// The specific SMB version that you want DataSync to use to mount your SMB share. If you don&#39;t specify
        /// a version, DataSync defaults to AUTOMATIC. That is, DataSync automatically selects a version based
        /// on negotiation with the SMB server.
        /// Required: No
        /// Type: String
        /// Allowed values: AUTOMATIC | SMB2 | SMB3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
