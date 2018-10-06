using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon EC2 Instance SsmAssociations
    /// SsmAssociations is a property of the AWS::EC2::Instance resource that specifies the SSM document and parameter
    /// values in AWS Systems Manager to associate with an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ssmassociations.html
    /// </summary>
    public class SsmAssociation
    {

        /// <summary>
        /// AssociationParameters
        /// The input parameter values to use with the associated SSM document.
        /// Required: No
        /// Type: List of Amazon EC2 Instance SsmAssociations AssociationParameters
        /// </summary>
        [JsonProperty("AssociationParameters")]
        public List<AssociationParameter> AssociationParameters { get; set; }

        /// <summary>
        /// DocumentName
        /// The name of an SSM document to associate with the instance.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DocumentName")]
        public Union<string, IntrinsicFunction> DocumentName { get; set; }

    }
}
