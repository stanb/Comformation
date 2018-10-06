using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS Lambda Function VpcConfig
    /// VpcConfig is a property of the AWS::Lambda::Function resource that enables your AWS Lambda (Lambda) function
    /// to access resources in a VPC. For more information, see Configuring a Lambda Function to Access Resources in
    /// an Amazon VPC in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// SecurityGroupIds
        /// A list of one or more security groups IDs in the VPC that includes the resources to which your
        /// Lambda function requires access.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// A list of one or more subnet IDs in the VPC that includes the resources to which your Lambda
        /// function requires access.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
