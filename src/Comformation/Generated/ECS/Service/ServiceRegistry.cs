using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// Amazon Elastic Container Service Service ServiceRegistry
    /// The ServiceRegistry property type specifies details of the service registry.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceregistry.html
    /// </summary>
    public class ServiceRegistry
    {

        /// <summary>
        /// Port
        /// The port value used if your service discovery service specified an SRV record.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// RegistryArn
        /// The Amazon Resource Name (ARN) of the service registry. The currently supported service registry is
        /// Amazon Route 53 auto naming.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RegistryArn")]
        public Union<string, IntrinsicFunction> RegistryArn { get; set; }

    }
}
