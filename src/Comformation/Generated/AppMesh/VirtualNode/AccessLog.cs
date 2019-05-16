using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode AccessLog
    /// An object representing the access logging information for a virtual node.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-accesslog.html
    /// </summary>
    public class AccessLog
    {

        /// <summary>
        /// File
        /// The file object to send virtual node access logs to.
        /// Required: No
        /// Type: FileAccessLog
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("File")]
        public FileAccessLog File { get; set; }

    }
}
