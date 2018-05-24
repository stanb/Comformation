using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html
    /// </summary>
    public class InstanceResource : ResourceBase
    {
        public class InstanceProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-additionalinfo
            /// </summary>
			public Union<string, IntrinsicFunction> AdditionalInfo { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-affinity
            /// </summary>
			public Union<string, IntrinsicFunction> Affinity { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-availabilityzone
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-blockdevicemappings
            /// </summary>
			public Union<List<BlockDeviceMapping>, IntrinsicFunction> BlockDeviceMappings { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-creditspecification
            /// </summary>
			public Union<CreditSpecification, IntrinsicFunction> CreditSpecification { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-disableapitermination
            /// </summary>
			public Union<bool?, IntrinsicFunction> DisableApiTermination { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-ebsoptimized
            /// </summary>
			public Union<bool?, IntrinsicFunction> EbsOptimized { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-elasticgpuspecifications
            /// </summary>
			public Union<List<ElasticGpuSpecification>, IntrinsicFunction> ElasticGpuSpecifications { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-hostid
            /// </summary>
			public Union<string, IntrinsicFunction> HostId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-iaminstanceprofile
            /// </summary>
			public Union<string, IntrinsicFunction> IamInstanceProfile { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-imageid
            /// </summary>
			public Union<string, IntrinsicFunction> ImageId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-instanceinitiatedshutdownbehavior
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceInitiatedShutdownBehavior { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-instancetype
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-ipv6addresscount
            /// </summary>
			public Union<int?, IntrinsicFunction> Ipv6AddressCount { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-ipv6addresses
            /// </summary>
			public Union<List<InstanceIpv6Address>, IntrinsicFunction> Ipv6Addresses { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-kernelid
            /// </summary>
			public Union<string, IntrinsicFunction> KernelId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-keyname
            /// </summary>
			public Union<string, IntrinsicFunction> KeyName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-monitoring
            /// </summary>
			public Union<bool?, IntrinsicFunction> Monitoring { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-networkinterfaces
            /// </summary>
			public Union<List<NetworkInterface>, IntrinsicFunction> NetworkInterfaces { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-placementgroupname
            /// </summary>
			public Union<string, IntrinsicFunction> PlacementGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-privateipaddress
            /// </summary>
			public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-ramdiskid
            /// </summary>
			public Union<string, IntrinsicFunction> RamdiskId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-securitygroupids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-securitygroups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-sourcedestcheck
            /// </summary>
			public Union<bool?, IntrinsicFunction> SourceDestCheck { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-ssmassociations
            /// </summary>
			public Union<List<SsmAssociation>, IntrinsicFunction> SsmAssociations { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-tenancy
            /// </summary>
			public Union<string, IntrinsicFunction> Tenancy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-userdata
            /// </summary>
			public Union<string, IntrinsicFunction> UserData { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html#cfn-ec2-instance-volumes
            /// </summary>
			public Union<List<Volume>, IntrinsicFunction> Volumes { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::Instance";
        
        public InstanceProperties Properties { get; } = new InstanceProperties();
    }

	public static class InstanceAttributes
	{
        public static readonly ResourceAttribute<string> AvailabilityZone = new ResourceAttribute<string>("AvailabilityZone");
        public static readonly ResourceAttribute<string> PrivateDnsName = new ResourceAttribute<string>("PrivateDnsName");
        public static readonly ResourceAttribute<string> PrivateIp = new ResourceAttribute<string>("PrivateIp");
        public static readonly ResourceAttribute<string> PublicDnsName = new ResourceAttribute<string>("PublicDnsName");
        public static readonly ResourceAttribute<string> PublicIp = new ResourceAttribute<string>("PublicIp");
	}
}
