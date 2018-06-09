using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS OpsWorks Stack ElasticIp
    /// ElasticIps is a property of the AWS::OpsWorks::Stack resource that registers an Elastic IP address with an AWS
    /// OpsWorks stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-elasticip.html
    /// </summary>
    public class ElasticIp
    {

        /// <summary>
        /// Ip
        /// The Elastic IP address.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Ip")]
        public Union<string, IntrinsicFunction> Ip { get; set; }

        /// <summary>
        /// Name
        /// A name for the Elastic IP address.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
