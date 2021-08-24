using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.ResourceSet
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::ResourceSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-resourceset.html
    /// </summary>
    public class ResourceSetResource : ResourceBase
    {
        public class ResourceSetProperties
        {
            /// <summary>
            /// ResourceSetName
            /// The name of the resource set to create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceSetName { get; set; }

            /// <summary>
            /// Resources
            /// A list of resource objects in the resource set.
            /// Required: Yes
            /// Type: List of Resource
            /// Update requires: No interruption
            /// </summary>
            public List<Resource> Resources { get; set; }

            /// <summary>
            /// ResourceSetType
            /// The resource type of the resources in the resource set. Enter one of the following values for
            /// resource type:
            /// AWS::AutoScaling::AutoScalingGroup, 		AWS::CloudWatch::Alarm, 		AWS::EC2::CustomerGateway,
            /// 		AWS::DynamoDB::Table, 		AWS::EC2::Volume, 		AWS::ElasticLoadBalancing::LoadBalancer,
            /// 		AWS::ElasticLoadBalancingV2::LoadBalancer, 		AWS::MSK::Cluster, 		AWS::RDS::DBCluster,
            /// 		AWS::Route53::HealthCheck, 		AWS::SQS::Queue, 		AWS::SNS::Topic, 		AWS::SNS::Subscription,
            /// 		AWS::EC2::VPC, 		AWS::EC2::VPNConnection, 		AWS::EC2::VPNGateway,
            /// AWS::Route53RecoveryReadiness::DNSTargetResource.
            /// Note that AWS::Route53RecoveryReadiness::DNSTargetResource is only used for this setting and it
            /// isn&#39;t an actual AWS CloudFormation resource type.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceSetType { get; set; }

            /// <summary>
            /// Tags
            /// A tag to associate with the parameters for a resource set.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Route53RecoveryReadiness::ResourceSet";

        public ResourceSetProperties Properties { get; } = new ResourceSetProperties();

    }

    public static class ResourceSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceSetArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceSetArn");
    }
}
