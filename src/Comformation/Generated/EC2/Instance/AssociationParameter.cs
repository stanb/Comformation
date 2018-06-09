using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon EC2 Instance SsmAssociations AssociationParameters
    /// AssociationParameters is a property of the Amazon EC2 Instance SsmAssociations property that specifies input
    /// parameter values for an SSM document in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ssmassociations-associationparameters.html
    /// </summary>
    public class AssociationParameter
    {

        /// <summary>
        /// Key
        /// The name of an input parameter that is in the associated SSM document.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value of an input parameter.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Value")]
        public Union<List<string>, IntrinsicFunction> Value { get; set; }

    }
}
