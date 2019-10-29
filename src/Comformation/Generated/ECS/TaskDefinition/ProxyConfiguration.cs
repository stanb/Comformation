using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition ProxyConfiguration
    /// The ProxyConfiguration property specifies the details for the App Mesh proxy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-proxyconfiguration.html
    /// </summary>
    public class ProxyConfiguration
    {

        /// <summary>
        /// ContainerName
        /// The name of the container that will serve as the App Mesh proxy.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerName")]
        public Union<string, IntrinsicFunction> ContainerName { get; set; }

        /// <summary>
        /// ProxyConfigurationProperties
        /// The set of network configuration parameters to provide the Container Network Interface (CNI) plugin,
        /// specified as key-value pairs.
        /// IgnoredUID - (Required) The user ID (UID) of the proxy container as defined by the user parameter in
        /// a container definition. This is used to ensure the proxy ignores its own traffic. If IgnoredGID is
        /// specified, this field can be empty. IgnoredGID - (Required) The group ID (GID) of the proxy
        /// container as defined by the user parameter in a container definition. This is used to ensure the
        /// proxy ignores its own traffic. If IgnoredUID is specified, this field can be empty. AppPorts -
        /// (Required) The list of ports that the application uses. Network traffic to these ports is forwarded
        /// to the ProxyIngressPort and ProxyEgressPort. ProxyIngressPort - (Required) Specifies the port that
        /// incoming traffic to the AppPorts is directed to. ProxyEgressPort - (Required) Specifies the port
        /// that outgoing traffic from the AppPorts is directed to. EgressIgnoredPorts - (Required) The egress
        /// traffic going to the specified ports is ignored and not redirected to the ProxyEgressPort. It can be
        /// an empty list. EgressIgnoredIPs - (Required) The egress traffic going to the specified IP addresses
        /// is ignored and not redirected to the ProxyEgressPort. It can be an empty list.
        /// Required: No
        /// Type: List of KeyValuePair
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ProxyConfigurationProperties")]
        public List<KeyValuePair> ProxyConfigurationProperties { get; set; }

        /// <summary>
        /// Type
        /// The proxy type. The only supported value is APPMESH.
        /// Required: No
        /// Type: String
        /// Allowed Values: APPMESH
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
