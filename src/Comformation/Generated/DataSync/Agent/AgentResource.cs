using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.Agent
{
    /// <summary>
    /// AWS::DataSync::Agent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-agent.html
    /// </summary>
    public class AgentResource : ResourceBase
    {
        public class AgentProperties
        {
            /// <summary>
            /// AgentName
            /// The name you configured for your agent. This value is a text reference that is used to identify the
            /// agent in the console.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[a-zA-Z0-9\s+=. _:@/-]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AgentName { get; set; }

            /// <summary>
            /// ActivationKey
            /// Your agent activation key. You can get the activation key either by sending an HTTP GET request with
            /// redirects that enable you to get the agent IP address (port 80). Alternatively, you can get it from
            /// the AWS DataSync console.
            /// The redirect URL returned in the response provides you the activation key for your agent in the
            /// query string parameter activationKey. It might also include other activation-related parameters;
            /// however, these are merely defaults. The arguments you pass to this API call determine the actual
            /// configuration of your agent.
            /// For more information, see Activating an Agent in the AWS DataSync User Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 29
            /// Pattern: [A-Z0-9]{5}(-[A-Z0-9]{5}){4}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ActivationKey { get; set; }

            /// <summary>
            /// SecurityGroupArns
            /// The ARNs of the security groups used to protect your data transfer task subnets. See
            /// CreateAgentRequest$SubnetArns.
            /// Required: No
            /// Type: List of String
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupArns { get; set; }

            /// <summary>
            /// SubnetArns
            /// The Amazon Resource Names (ARNs) of the subnets in which DataSync will create elastic network
            /// interfaces for each data transfer task. The agent that runs a task must be private. When you start a
            /// task that is associated with an agent created in a VPC, or one that has access to an IP address in a
            /// VPC, then the task is also private. In this case, DataSync creates four network interfaces for each
            /// task in your subnet. For a data transfer to work, the agent must be able to route to all these four
            /// network interfaces.
            /// Required: No
            /// Type: List of String
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetArns { get; set; }

            /// <summary>
            /// VpcEndpointId
            /// The ID of the VPC (virtual private cloud) endpoint that the agent has access to. This is the
            /// client-side VPC endpoint, also called a PrivateLink. If you don&#39;t have a PrivateLink VPC endpoint,
            /// see Creating a VPC Endpoint Service Configuration in the Amazon VPC User Guide.
            /// For more information about activating your agent in a private network based on Amazon VPC, see Using
            /// AWS DataSync in a Virtual Private Cloudin the AWS DataSync User Guide.
            /// VPC endpoint ID looks like this: vpce-01234d5aff67890e1.
            /// Required: No
            /// Type: String
            /// Pattern: ^vpce-[0-9a-f]{17}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VpcEndpointId { get; set; }

            /// <summary>
            /// Tags
            /// The key-value pair that represents the tag that you want to associate with the agent. The value can
            /// be an empty string. This value helps you manage, filter, and search for your agents.
            /// Note Valid characters for key and value are letters, spaces, and numbers representable in UTF-8
            /// format, and the following special characters: + - = . _ : / @.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataSync::Agent";

        public AgentProperties Properties { get; } = new AgentProperties();

    }

    public static class AgentAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EndpointType = new ResourceAttribute<Union<string, IntrinsicFunction>>("EndpointType");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AgentArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AgentArn");
    }
}
