using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance ElasticGpuSpecification
    /// Specifies the type of Elastic GPU. An Elastic GPU is a GPU resource that you can attach to 			your Amazon EC2
    /// instance to accelerate the graphics performance of your applications. For more 			information, see 				Amazon
    /// EC2 Elastic GPUs in the Amazon EC2 User Guide for Windows Instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticgpuspecification.html
    /// </summary>
    public class ElasticGpuSpecification
    {

        /// <summary>
        /// Type
        /// The type of Elastic Graphics accelerator. For more information about the values to specify for Type,
        /// see Elastic Graphics Basics, specifically the Elastic Graphics accelerator column, in the Amazon
        /// Elastic Compute Cloud User Guide for Windows Instances.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
