using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS::Batch::ComputeEnvironment ComputeResources
    /// Details of the compute resources managed by the compute environment. This parameter is required for managed
    /// compute environments. For more information, see Compute Environments in the AWS Batch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html
    /// </summary>
    public class ComputeResources
    {

        /// <summary>
        /// SpotIamFleetRole
        /// The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a SPOT compute
        /// environment. This role is required if the allocation strategy set to BEST_FIT or if the allocation
        /// strategy is not specified. For more information, see Amazon EC2 Spot Fleet Role in the AWS Batch
        /// User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpotIamFleetRole")]
        public Union<string, IntrinsicFunction> SpotIamFleetRole { get; set; }

        /// <summary>
        /// MaxvCpus
        /// The maximum number of Amazon EC2 vCPUs that an environment can reach.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxvCpus")]
        public Union<int, IntrinsicFunction> MaxvCpus { get; set; }

        /// <summary>
        /// BidPercentage
        /// The maximum percentage that a Spot Instance price can be when compared with the On-Demand price for
        /// that instance type before instances are launched. For example, if your maximum percentage is 20%,
        /// then the Spot price must be below 20% of the current On-Demand price for that Amazon EC2 instance.
        /// You always pay the lowest (market) price and never more than your maximum percentage. If you leave
        /// this field empty, the default value is 100% of the On-Demand price.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BidPercentage")]
        public Union<int, IntrinsicFunction> BidPercentage { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// The Amazon EC2 security groups associated with instances launched in the compute environment. One or
        /// more security groups must be specified, either in securityGroupIds or using a launch template
        /// referenced in launchTemplate. If security groups are specified using both securityGroupIds and
        /// launchTemplate, the values in securityGroupIds will be used.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// Subnets
        /// The VPC subnets into which the compute resources are launched. For more information, see VPCs and
        /// Subnets in the Amazon VPC User Guide.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

        /// <summary>
        /// Type
        /// The type of compute environment: EC2 or SPOT.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: EC2 | SPOT
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// AllocationStrategy
        /// The allocation strategy to use for the compute resource in case not enough instances of the best
        /// fitting instance type can be allocated. This could be due to availability of the instance type in
        /// the region or Amazon EC2 service limits. If this is not specified, the default is BEST_FIT, which
        /// will use only the best fitting instance type, waiting for additional capacity if it&#39;s not available.
        /// This allocation strategy keeps costs lower but can limit scaling. If you are using Spot Fleets with
        /// BEST_FIT then the Spot Fleet IAM Role must be specified. BEST_FIT_PROGRESSIVE will select additional
        /// instance types that are large enough to meet the requirements of the jobs in the queue, with a
        /// preference for instance types with a lower cost per vCPU. SPOT_CAPACITY_OPTIMIZED is only available
        /// for Spot Instance compute resources and will select additional instance types that are large enough
        /// to meet the requirements of the jobs in the queue, with a preference for instance types that are
        /// less likely to be interrupted. For more information, see Allocation Strategies in the AWS Batch User
        /// Guide.
        /// Required: No
        /// Type: String
        /// Allowed Values: BEST_FIT | BEST_FIT_PROGRESSIVE | SPOT_CAPACITY_OPTIMIZED
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// MinvCpus
        /// The minimum number of Amazon EC2 vCPUs that an environment should maintain (even if the compute
        /// environment is DISABLED).
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
        /// The Amazon ECS instance profile applied to Amazon EC2 instances in a compute environment. You can
        /// specify the short name or full Amazon Resource Name (ARN) of an instance profile. For example,
        /// ecsInstanceRole or arn:aws:iam::&amp;lt;aws_account_id&amp;gt;:instance-profile/ecsInstanceRole . For more
        /// information, see Amazon ECS Instance Role in the AWS Batch User Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceRole")]
        public Union<string, IntrinsicFunction> InstanceRole { get; set; }

        /// <summary>
        /// InstanceTypes
        /// The instances types that may be launched. You can specify instance families to launch any instance
        /// type within those families (for example, c5 or p3), or you can specify specific sizes within a
        /// family (such as c5. 8xlarge). You can also choose optimal to pick instance types (from the C, M, and
        /// R instance families) on the fly that match the demand of your job queues.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public List<Union<string, IntrinsicFunction>> InstanceTypes { get; set; }

        /// <summary>
        /// Ec2KeyPair
        /// The Amazon EC2 key pair that is used for instances launched in the compute environment.
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
        /// Key-value pair tags to be applied to resources that are launched in the compute environment. For AWS
        /// Batch, these take the form of &quot;String1&quot;: &quot;String2&quot;, where String1 is the tag key and String2 is the
        /// tag value—for example, { &quot;Name&quot;: &quot;AWS Batch Instance - C4OnDemand&quot; }.
        /// Required: No
        /// Type: Json
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tags")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        /// <summary>
        /// DesiredvCpus
        /// The desired number of Amazon EC2 vCPUS in the compute environment.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DesiredvCpus")]
        public Union<int, IntrinsicFunction> DesiredvCpus { get; set; }

    }
}
