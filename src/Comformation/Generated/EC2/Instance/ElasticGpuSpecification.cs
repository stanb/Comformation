using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon EC2 Instance ElasticGpuSpecification
    /// The ElasticGpuSpecification property is part of the AWS::EC2::Instance resource that specifies the type of
    /// Elastic GPU. An Elastic GPU is a GPU resource that you can attach to your Amazon EC2 instance to accelerate
    /// the graphics performance of your applications. For more information, see Amazon EC2 Elastic GPUs in the Amazon
    /// EC2 User Guide for Windows Instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticgpuspecification.html
    /// </summary>
    public class ElasticGpuSpecification
    {

        /// <summary>
        /// Type
        /// The type of Elastic GPU.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
