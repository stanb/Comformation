using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode FileAccessLog
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-fileaccesslog.html
    /// </summary>
    public class FileAccessLog
    {

        /// <summary>
        /// Path
        /// The file path to write access logs to. You can use /dev/stdout to send access logs to standard out
        /// and configure your Envoy container to use a log driver, such as awslogs, to export the access logs
        /// to a log storage service such as Amazon CloudWatch Logs. You can also specify a path in the Envoy
        /// container&#39;s file system to write the files to disk.
        /// Note The Envoy process must have write permissions to the path that you specify here. Otherwise,
        /// Envoy fails to bootstrap properly.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

    }
}
