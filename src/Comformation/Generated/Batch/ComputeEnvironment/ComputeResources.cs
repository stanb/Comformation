using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS::Batch::ComputeEnvironment ComputeResources
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html
    /// </summary>
    public class ComputeResources
    {

        /// <summary>
        /// SpotIamFleetRole
        /// The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a SPOT compute
        /// environment. This role is required if the allocation strategy set to BEST_FIT or if the allocation
        /// strategy isn&#39;t specified. For more information, see Amazon EC2 Spot Fleet Role in the AWS Batch User
        /// Guide.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Important To tag your Spot Instances on creation, the Spot Fleet IAM role specified here must use
        /// the newer AmazonEC2SpotFleetTaggingRole managed policy. The previously recommended
        /// AmazonEC2SpotFleetRole managed policy doesn&#39;t have the required permissions to tag Spot Instances.
        /// For more information, see Spot Instances not tagged on creation in the AWS Batch User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpotIamFleetRole")]
        public Union<string, IntrinsicFunction> SpotIamFleetRole { get; set; }

        /// <summary>
        /// MaxvCpus
        /// The maximum number of Amazon EC2 vCPUs that an environment can reach.
        /// Note With both BEST_FIT_PROGRESSIVE and SPOT_CAPACITY_OPTIMIZED allocation strategies, AWS Batch
        /// might need to go above maxvCpus to meet your capacity requirements. In this event, AWS Batch will
        /// never go above maxvCpus by more than a single instance (e. g. , no more than a single instance from
        /// among those specified in your compute environment).
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxvCpus")]
        public Union<int, IntrinsicFunction> MaxvCpus { get; set; }

        /// <summary>
        /// Ec2Configuration
        /// Provides information used to select Amazon Machine Images (AMIs) for EC2 instances in the compute
        /// environment. If Ec2Configuration isn&#39;t specified, the default is ECS_AL1.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Required: No
        /// Type: List of Ec2ConfigurationObject
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ec2Configuration")]
        public List<Ec2ConfigurationObject> Ec2Configuration { get; set; }

        /// <summary>
        /// BidPercentage
        /// The maximum percentage that a Spot Instance price can be when compared with the On-Demand price for
        /// that instance type before instances are launched. For example, if your maximum percentage is 20%,
        /// then the Spot price must be less than 20% of the current On-Demand price for that Amazon EC2
        /// instance. You always pay the lowest (market) price and never more than your maximum percentage. If
        /// you leave this field empty, the default value is 100% of the On-Demand price.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
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
        /// referenced in launchTemplate. This parameter is required for jobs running on Fargate resources and
        /// must contain at least one security group. (Fargate does not support launch templates. ) If security
        /// groups are specified using both securityGroupIds and launchTemplate, the values in securityGroupIds
        /// will be used.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// Subnets
        /// The VPC subnets into which the compute resources are launched. These subnets must be within the same
        /// VPC. Fargate compute resources can contain up to 16 subnets. For more information, see VPCs and
        /// Subnets in the Amazon VPC User Guide.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

        /// <summary>
        /// Type
        /// The type of compute environment: EC2, SPOT, FARGATE, or FARGATE_SPOT. For more information, see
        /// Compute Environments in the AWS Batch User Guide.
        /// If you choose SPOT, you must also specify an Amazon EC2 Spot Fleet role with the spotIamFleetRole
        /// parameter. For more information, see Amazon EC2 Spot Fleet role in the AWS Batch User Guide.
        /// Required: Yes
        /// Type: String
        /// Allowed values: EC2 | FARGATE | FARGATE_SPOT | SPOT
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// AllocationStrategy
        /// The allocation strategy to use for the compute resource if not enough instances of the best fitting
        /// instance type can be allocated. This might be because of availability of the instance type in the
        /// Region or Amazon EC2 service limits. For more information, see Allocation Strategies in the AWS
        /// Batch User Guide.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// BEST_FIT (default) AWS Batch selects an instance type that best fits the needs of the jobs with a
        /// preference for the lowest-cost instance type. If additional instances of the selected instance type
        /// aren&#39;t available, AWS Batch will wait for the additional instances to be available. If there are not
        /// enough instances available, or if the user is hitting Amazon EC2 service limits then additional jobs
        /// aren&#39;t run until currently running jobs have completed. This allocation strategy keeps costs lower
        /// but can limit scaling. If you are using Spot Fleets with BEST_FIT then the Spot Fleet IAM Role must
        /// be specified. BEST_FIT_PROGRESSIVE AWS Batch will select additional instance types that are large
        /// enough to meet the requirements of the jobs in the queue, with a preference for instance types with
        /// a lower cost per unit vCPU. If additional instances of the previously selected instance types aren&#39;t
        /// available, AWS Batch will select new instance types. SPOT_CAPACITY_OPTIMIZED AWS Batch will select
        /// one or more instance types that are large enough to meet the requirements of the jobs in the queue,
        /// with a preference for instance types that are less likely to be interrupted. This allocation
        /// strategy is only available for Spot Instance compute resources.
        /// With both BEST_FIT_PROGRESSIVE and SPOT_CAPACITY_OPTIMIZED strategies, AWS Batch might need to go
        /// above maxvCpus to meet your capacity requirements. In this event, AWS Batch never exceeds maxvCpus
        /// by more than a single instance.
        /// Required: No
        /// Type: String
        /// Allowed values: BEST_FIT | BEST_FIT_PROGRESSIVE | SPOT_CAPACITY_OPTIMIZED
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// MinvCpus
        /// The minimum number of Amazon EC2 vCPUs that an environment should maintain (even if the compute
        /// environment is DISABLED).
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Required: No
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
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Required: No
        /// Type: LaunchTemplateSpecification
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplate")]
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// ImageId
        /// The Amazon Machine Image (AMI) ID used for instances launched in the compute environment. This
        /// parameter is overridden by the imageIdOverride member of the Ec2Configuration structure.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Note The AMI that you choose for a compute environment must match the architecture of the instance
        /// types that you intend to use for that compute environment. For example, if your compute environment
        /// uses A1 instance types, the compute resource AMI that you choose must support ARM instances. Amazon
        /// ECS vends both x86 and ARM versions of the Amazon ECS-optimized Amazon Linux 2 AMI. For more
        /// information, see Amazon ECS-optimized Amazon Linux 2 AMI in the Amazon Elastic Container Service
        /// Developer Guide.
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
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceRole")]
        public Union<string, IntrinsicFunction> InstanceRole { get; set; }

        /// <summary>
        /// InstanceTypes
        /// The instances types that can be launched. You can specify instance families to launch any instance
        /// type within those families (for example, c5 or p3), or you can specify specific sizes within a
        /// family (such as c5. 8xlarge). You can also choose optimal to select instance types (from the C4, M4,
        /// and R4 instance families) on the fly that match the demand of your job queues.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Note When you create a compute environment, the instance types that you select for the compute
        /// environment must share the same architecture. For example, you can&#39;t mix x86 and ARM instances in
        /// the same compute environment.
        /// Note Currently, optimal uses instance types from the C4, M4, and R4 instance families. In Regions
        /// that don&#39;t have instance types from those instance families, instance types from the C5, M5. and R5
        /// instance families are used.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public List<Union<string, IntrinsicFunction>> InstanceTypes { get; set; }

        /// <summary>
        /// Ec2KeyPair
        /// The Amazon EC2 key pair that&#39;s used for instances launched in the compute environment. You can use
        /// this key pair to log in to your instances with SSH.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
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
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PlacementGroup")]
        public Union<string, IntrinsicFunction> PlacementGroup { get; set; }

        /// <summary>
        /// Tags
        /// Key-value pair tags to be applied to EC2 resources that are launched in the compute environment. For
        /// AWS Batch, these take the form of &quot;String1&quot;: &quot;String2&quot;, where String1 is the tag key and String2 is
        /// the tag value−for example, { &quot;Name&quot;: &quot;AWS Batch Instance - C4OnDemand&quot; }. This is helpful for
        /// recognizing your AWS Batch instances in the Amazon EC2 console. These tags can&#39;t be updated or
        /// removed after the compute environment has been created; any changes require creating a new compute
        /// environment and removing the old compute environment. These tags are not seen when using the AWS
        /// Batch ListTagsForResource API operation.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Required: No
        /// Type: Json
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tags")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        /// <summary>
        /// DesiredvCpus
        /// The desired number of Amazon EC2 vCPUS in the compute environment. AWS Batch modifies this value
        /// between the minimum and maximum values, based on job queue demand.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources, and shouldn&#39;t be
        /// specified.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DesiredvCpus")]
        public Union<int, IntrinsicFunction> DesiredvCpus { get; set; }

    }
}
