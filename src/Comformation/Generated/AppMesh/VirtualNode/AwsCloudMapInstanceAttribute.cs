using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode AwsCloudMapInstanceAttribute
    /// An object that represents the AWS Cloud Map attribute information for your virtual node.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapinstanceattribute.html
    /// </summary>
    public class AwsCloudMapInstanceAttribute
    {

        /// <summary>
        /// Value
        /// The value of an AWS Cloud Map service instance attribute key. Any AWS Cloud Map service instance
        /// that contains the specified key and value is returned.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// The name of an AWS Cloud Map service instance attribute key. Any AWS Cloud Map service instance that
        /// contains the specified key and value is returned.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
