using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode AwsCloudMapServiceDiscovery
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html
    /// </summary>
    public class AwsCloudMapServiceDiscovery
    {

        /// <summary>
        /// NamespaceName
        /// The name of the AWS Cloud Map namespace to use.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NamespaceName")]
        public Union<string, IntrinsicFunction> NamespaceName { get; set; }

        /// <summary>
        /// ServiceName
        /// The name of the AWS Cloud Map service to use.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

        /// <summary>
        /// Attributes
        /// A string map that contains attributes with values that you can use to filter instances by any custom
        /// attribute that you specified when you registered the instance. Only instances that match all of the
        /// specified key/value pairs will be returned.
        /// Required: No
        /// Type: List of AwsCloudMapInstanceAttribute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public List<AwsCloudMapInstanceAttribute> Attributes { get; set; }

    }
}
