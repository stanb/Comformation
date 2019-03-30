using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS AppMesh VirtualNode Logging
    /// An object representing the logging information for a virtual node.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-logging.html
    /// </summary>
    public class Logging
    {

        /// <summary>
        /// AccessLog
        /// The access log configuration for a virtual node.
        /// Required: No
        /// Type: AccessLog
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessLog")]
        public AccessLog AccessLog { get; set; }

    }
}
