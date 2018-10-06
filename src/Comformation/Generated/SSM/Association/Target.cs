using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS Systems Manager Association Targets
    /// Targets is a property of the AWS::SSM::Association resource that specifies the targets for an SSM document in
    /// Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-targets.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// Key
        /// The name of the criteria that EC2 instances must meet. For valid keys, see the Target data type in
        /// the AWS Systems Manager API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Values
        /// The value of the criteria. Systems Manager runs targeted commands on EC2 instances that match the
        /// criteria. For more information, see the Target data type in the AWS Systems Manager API Reference.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
