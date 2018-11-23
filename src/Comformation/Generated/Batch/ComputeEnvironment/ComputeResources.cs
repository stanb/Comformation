using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS Batch ComputeEnvironment ComputeResources
    /// The ComputeResources property type specifies details of the compute resources managed by the compute
    /// environment. This parameter is required for managed compute environments. For more information, see Compute
    /// Environments in the AWS Batch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html
    /// </summary>
    public class ComputeResources
    {

        /// <summary>
        /// SpotIamFleetRole
        /// The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a SPOT compute
        /// environment.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpotIamFleetRole")]
        public Union<string, IntrinsicFunction> SpotIamFleetRole { get; set; }

        /// <summary>
        /// MaxvCpus
        /// The maximum number of EC2 vCPUs that an environment can reach.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxvCpus")]
        public Union<int, IntrinsicFunction> MaxvCpus { get; set; }

        /// <summary>
        /// BidPercentage
        /// The minimum percentage that a Spot Instance price must be when compared with the On-Demand price for
        /// that instance type before instances are launched. For example, if your bid percentage is 20%, then
        /// the Spot price must be below 20% of the current On-Demand price for that EC2 instance.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BidPercentage")]
        public Union<int, IntrinsicFunction> BidPercentage { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// The EC2 security group that is associated with instances launched in the compute environment.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// Subnets
        /// The VPC subnets into which the compute resources are launched.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

        /// <summary>
        /// Type
        /// The type of compute environment: EC2 or SPOT.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// MinvCpus
        /// The minimum number of EC2 vCPUs that an environment should maintain.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinvCpus")]
        public Union<int, IntrinsicFunction> MinvCpus { get; set; }

        /// <summary>
        /// LaunchTemplate
        /// The launch template to use for your compute resources. Any other compute resource parameters that
        /// you specify in a CreateComputeEnvironment API operation override the same parameters in the launch
        /// template. You must specify either the launch template ID or launch template name in the request, but
        /// not both. For more information, see Launch Template Support in the AWS Batch User Guide.
        /// Required: No
        /// Type: LaunchTemplateSpecification
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplate")]
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// ImageId
        /// The Amazon Machine Image (AMI) ID used for instances launched in the compute environment.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImageId")]
        public Union<string, IntrinsicFunction> ImageId { get; set; }

        /// <summary>
        /// InstanceRole
        /// The Amazon ECS instance profile applied to Amazon EC2 instances in a compute environment.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceRole")]
        public Union<string, IntrinsicFunction> InstanceRole { get; set; }

        /// <summary>
        /// InstanceTypes
        /// The instances types that may launched.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public List<Union<string, IntrinsicFunction>> InstanceTypes { get; set; }

        /// <summary>
        /// Ec2KeyPair
        /// The EC2 key pair that is used for instances launched in the compute environment.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ec2KeyPair")]
        public Union<string, IntrinsicFunction> Ec2KeyPair { get; set; }

        /// <summary>
        /// PlacementGroup
        /// The Amazon EC2 placement group to associate with your compute resources. If you intend to submit
        /// multi-node parallel jobs to your compute environment, you should consider creating a cluster
        /// placement group and associate it with your compute resources. This keeps your multi-node parallel
        /// job on a logical grouping of instances within a single Availability Zone with high network flow
        /// potential. For more information, see Placement Groups in the Amazon EC2 User Guide for Linux
        /// Instances.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PlacementGroup")]
        public Union<string, IntrinsicFunction> PlacementGroup { get; set; }

        /// <summary>
        /// Tags
        /// Key-value pair tags to be applied to instances that are launched in the compute environment. For AWS
        /// Batch, these take the form of &quot;String1&quot;: &quot;String2&quot;, where String1 is the tag key and String2 is the
        /// tag value—for example, { &quot;Name&quot;: &quot;AWS Batch Instance - C4OnDemand&quot; }.
        /// Required: No
        /// Type: JSON object
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tags")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        /// <summary>
        /// DesiredvCpus
        /// The desired number of EC2 vCPUS in the compute environment.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DesiredvCpus")]
        public Union<int, IntrinsicFunction> DesiredvCpus { get; set; }

    }
}
