using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup
    /// The AWS::CodeDeploy::DeploymentGroup resource creates an AWS CodeDeploy deployment group that specifies which
    /// instances your application revisions are deployed to, along with other deployment options. For more
    /// information, see CreateDeploymentGroup in the CodeDeploy API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentgroup.html
    /// </summary>
    public class DeploymentGroupResource : ResourceBase
    {
        public class DeploymentGroupProperties
        {
            /// <summary>
            /// AlarmConfiguration
            /// Information about the Amazon CloudWatch alarms that are associated with the deployment group.
            /// Required: No
            /// Type: AlarmConfiguration
            /// Update requires: No interruption
            /// </summary>
			public AlarmConfiguration AlarmConfiguration { get; set; }

            /// <summary>
            /// ApplicationName
            /// The name of an existing CodeDeploy application to associate this deployment group with.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// AutoRollbackConfiguration
            /// Information about the automatic rollback configuration that is associated with the deployment group.
            /// If you specify this property, don&#39;t specify the Deployment property.
            /// Required: No
            /// Type: AutoRollbackConfiguration
            /// Update requires: No interruption
            /// </summary>
			public AutoRollbackConfiguration AutoRollbackConfiguration { get; set; }

            /// <summary>
            /// AutoScalingGroups
            /// A list of associated Auto Scaling groups that CodeDeploy automatically deploys revisions to when new
            /// instances are created. Duplicates are not allowed.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AutoScalingGroups { get; set; }

            /// <summary>
            /// Deployment
            /// The application revision to deploy to this deployment group. If you specify this property, your
            /// target application revision is deployed as soon as the provisioning process is complete. If you
            /// specify this property, don&#39;t specify the AutoRollbackConfiguration property.
            /// Required: No
            /// Type: Deployment
            /// Update requires: No interruption
            /// </summary>
			public Deployment Deployment { get; set; }

            /// <summary>
            /// DeploymentConfigName
            /// A deployment configuration name or a predefined configuration name. With predefined configurations,
            /// you can deploy application revisions to one instance at a time, half of the instances at a time, or
            /// all the instances at once. For more information and valid values, see Working with Deployment
            /// Configurations in the AWS CodeDeploy User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentConfigName { get; set; }

            /// <summary>
            /// DeploymentGroupName
            /// A name for the deployment group. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the deployment group name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentGroupName { get; set; }

            /// <summary>
            /// DeploymentStyle
            /// Attributes that determine the type of deployment to run and whether to route deployment traffic
            /// behind a load balancer.
            /// If you specify this property with a blue/green deployment type, don&#39;t specify the AutoScalingGroups,
            /// LoadBalancerInfo, or Deployment properties.
            /// Note For blue/green deployments, AWS CloudFormation supports deployments on Lambda compute platforms
            /// only.
            /// Required: No
            /// Type: DeploymentStyle
            /// Update requires: No interruption
            /// </summary>
			public DeploymentStyle DeploymentStyle { get; set; }

            /// <summary>
            /// Ec2TagFilters
            /// The EC2 tags that are already applied to EC2 instances that you want to include in the deployment
            /// group. CodeDeploy includes all EC2 instances identified by any of the tags you specify in this
            /// deployment group. Duplicates are not allowed.
            /// You can specify EC2TagFilters or Ec2TagSet, but not both.
            /// Required: No
            /// Type: List of EC2TagFilter
            /// Update requires: No interruption
            /// </summary>
			public List<EC2TagFilter> Ec2TagFilters { get; set; }

            /// <summary>
            /// Ec2TagSet
            /// Information about groups of tags applied to EC2 instances. The deployment group includes only EC2
            /// instances identified by all the tag groups. Cannot be used in the same call as ec2TagFilter.
            /// Required: No
            /// Type: EC2TagSet
            /// Update requires: No interruption
            /// </summary>
			public EC2TagSet Ec2TagSet { get; set; }

            /// <summary>
            /// LoadBalancerInfo
            /// Information about the load balancer to use in a deployment. For more information, see Integrating
            /// CodeDeploy with Elastic Load Balancing in the AWS CodeDeploy User Guide.
            /// Required: No
            /// Type: LoadBalancerInfo
            /// Update requires: No interruption
            /// </summary>
			public LoadBalancerInfo LoadBalancerInfo { get; set; }

            /// <summary>
            /// OnPremisesInstanceTagFilters
            /// The on-premises instance tags already applied to on-premises instances that you want to include in
            /// the deployment group. CodeDeploy includes all on-premises instances identified by any of the tags
            /// you specify in this deployment group. To register on-premises instances with CodeDeploy, see Working
            /// with On-Premises Instances for CodeDeploy in the AWS CodeDeploy User Guide. Duplicates are not
            /// allowed.
            /// You can specify OnPremisesInstanceTagFilters or OnPremisesInstanceTagSet, but not both.
            /// Required: No
            /// Type: List of TagFilter
            /// Update requires: No interruption
            /// </summary>
			public List<TagFilter> OnPremisesInstanceTagFilters { get; set; }

            /// <summary>
            /// OnPremisesTagSet
            /// Information about groups of tags applied to on-premises instances. The deployment group includes
            /// only on-premises instances identified by all the tag groups.
            /// You can specify OnPremisesInstanceTagFilters or OnPremisesInstanceTagSet, but not both.
            /// Required: No
            /// Type: OnPremisesTagSet
            /// Update requires: No interruption
            /// </summary>
			public OnPremisesTagSet OnPremisesTagSet { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// A service role Amazon Resource Name (ARN) that grants CodeDeploy permission to make calls to AWS
            /// services on your behalf. For more information, see Create a Service Role for AWS CodeDeploy in the
            /// AWS CodeDeploy User Guide.
            /// Note In some cases, you might need to add a dependency on the service role&#39;s policy. For more
            /// information, see IAM role policy in DependsOn Attribute.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

            /// <summary>
            /// TriggerConfigurations
            /// Information about triggers associated with the deployment group. Duplicates are not allowed
            /// Required: No
            /// Type: List of TriggerConfig
            /// Update requires: No interruption
            /// </summary>
			public List<TriggerConfig> TriggerConfigurations { get; set; }

        }

        public string Type { get; } = "AWS::CodeDeploy::DeploymentGroup";

        public DeploymentGroupProperties Properties { get; } = new DeploymentGroupProperties();

    }
}
