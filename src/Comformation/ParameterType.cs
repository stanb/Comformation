using Newtonsoft.Json;

namespace Comformation
{
    /// <summary>
    /// TODO: Add support for SSM Parameter Types
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/parameters-section-structure.html#aws-ssm-parameter-types
    /// </summary>
    [JsonConverter(typeof(ToStringJsonConverter))]
    public class ParameterType
    {
        private readonly string _type;

        private ParameterType(string type)
        {
            _type = type;
        }

        public override string ToString()
        {
            return _type;
        }
        
        /// <summary>
        /// String
        /// A literal string. For example, users could specify "MyUserName".
        /// </summary>
        public static readonly ParameterType String = new ParameterType("String");
        
        /// <summary>
        /// Number
        /// An integer or float. AWS CloudFormation validates the parameter value as a number; however, when you use the parameter elsewhere in your template (for example, by using the Ref intrinsic function), the parameter value becomes a string.
        /// For example, users could specify "8888".
        /// </summary>
        public static readonly ParameterType Number = new ParameterType("Number");

        /// <summary>
        /// List&lt;Number&gt;
        /// An array of integers or floats that are separated by commas. AWS CloudFormation validates the parameter value as numbers; however, when you use the parameter elsewhere in your template (for example, by using the Ref intrinsic function), the parameter value becomes a list of strings.
        /// For example, users could specify "80,20", and a Ref would result in ["80","20"].
        /// </summary>
        public static readonly ParameterType NumberList = new ParameterType("List<Number>");
        
        /// <summary>
        /// CommaDelimitedList
        /// An array of literal strings that are separated by commas. The total number of strings should be one more than the total number of commas. Also, each member string is space trimmed.
        /// For example, users could specify "test,dev,prod", and a Ref would result in ["test","dev","prod"].
        /// </summary>
        public static readonly ParameterType CommaDelimitedList = new ParameterType("CommaDelimitedList");
        
        /// <summary>
        /// AWS::EC2::AvailabilityZone::Name
        /// An Availability Zone, such as us-west-2a.
        /// </summary>
        public static readonly ParameterType AvailabilityZoneName = new ParameterType("AWS::EC2::AvailabilityZone::Name");
        
        /// <summary>
        /// AWS::EC2::Image::Id
        /// An Amazon EC2 image ID, such as ami-ff527ecf. Note that the AWS CloudFormation console doesn't show a drop-down list of values for this parameter type.
        /// </summary>
        public static readonly ParameterType ImageId = new ParameterType("AWS::EC2::Image::Id");
        
        /// <summary>
        /// AWS::EC2::Instance::Id
        /// An Amazon EC2 instance ID, such as i-1e731a32.
        /// </summary>
        public static readonly ParameterType InstanceId = new ParameterType("AWS::EC2::Instance::Id");
        
        /// <summary>
        /// AWS::EC2::KeyPair::KeyName
        /// An Amazon EC2 key pair name.
        /// </summary>
        public static readonly ParameterType KeyPairKeyName = new ParameterType("AWS::EC2::KeyPair::KeyName");
        
        /// <summary>
        /// AWS::EC2::SecurityGroup::GroupName
        /// An EC2-Classic or default VPC security group name, such as my-sg-abc.
        /// </summary>
        public static readonly ParameterType SecurityGroupGroupName = new ParameterType("AWS::EC2::SecurityGroup::GroupName");
        
        /// <summary>
        /// AWS::EC2::SecurityGroup::Id
        /// A security group ID, such as sg-a123fd85.
        /// </summary>
        public static readonly ParameterType SecurityGroupId = new ParameterType("AWS::EC2::SecurityGroup::Id");
        
        /// <summary>
        /// AWS::EC2::Subnet::Id
        /// A subnet ID, such as subnet-123a351e.
        /// </summary>
        public static readonly ParameterType SubnetId = new ParameterType("AWS::EC2::Subnet::Id");
        
        /// <summary>
        /// AWS::EC2::Volume::Id
        /// An Amazon EBS volume ID, such as vol-3cdd3f56.
        /// </summary>
        public static readonly ParameterType VolumeId = new ParameterType("AWS::EC2::Volume::Id");
        
        /// <summary>
        /// AWS::EC2::VPC::Id
        /// A VPC ID, such as vpc-a123baa3.
        /// </summary>
        public static readonly ParameterType VpcId = new ParameterType("AWS::EC2::VPC::Id");
        
        /// <summary>
        /// AWS::Route53::HostedZone::Id
        /// An Route 53 hosted zone ID, such as Z23YXV4OVPL04A.
        /// </summary>
        public static readonly ParameterType HostedZoneId = new ParameterType("AWS::Route53::HostedZone::Id");
        
        /// <summary>
        /// <![CDATA[List<AWS::EC2::AvailabilityZone::Name>]]>
        /// An array of Availability Zones for a region, such as us-west-2a, us-west-2b.
        /// </summary>
        public static readonly ParameterType AvailabilityZoneNameList = new ParameterType("List<AWS::EC2::AvailabilityZone::Name>");
        
        /// <summary>
        /// <![CDATA[List<AWS::EC2::Image::Id>]]>
        /// An array of Amazon EC2 image IDs, such as ami-ff527ecf, ami-e7527ed7. Note that the AWS CloudFormation console doesn't show a drop-down list of values for this parameter type.
        /// </summary>
        public static readonly ParameterType ImageIdList = new ParameterType("List<AWS::EC2::Image::Id>");

        /// <summary>
        /// <![CDATA[List<AWS::EC2::Instance::Id>]]>
        /// An array of Amazon EC2 instance IDs, such as i-1e731a32, i-1e731a34.
        /// </summary>
        public static readonly ParameterType InstanceIdList = new ParameterType("List<AWS::EC2::Instance::Id>");
        
        /// <summary>
        /// <![CDATA[List<AWS::EC2::SecurityGroup::GroupName>]]>
        /// An array of EC2-Classic or default VPC security group names, such as my-sg-abc, my-sg-def.
        /// </summary>
        public static readonly ParameterType SecurityGroupGroupNameList = new ParameterType("List<AWS::EC2::SecurityGroup::GroupName>");
        
        /// <summary>
        /// <![CDATA[List<AWS::EC2::SecurityGroup::Id>]]>
        /// An array of security group IDs, such as sg-a123fd85, sg-b456fd85.
        /// </summary>
        public static readonly ParameterType SecurityGroupIdList = new ParameterType("List<AWS::EC2::SecurityGroup::Id>");
        
        /// <summary>
        /// <![CDATA[List<AWS::EC2::Subnet::Id>]]>
        /// An array of subnet IDs, such as subnet-123a351e, subnet-456b351e.
        /// </summary>
        public static readonly ParameterType SubnetIdList = new ParameterType("List<AWS::EC2::Subnet::Id>");
        
        /// <summary>
        /// <![CDATA[List<AWS::EC2::Volume::Id>]]>
        /// An array of Amazon EBS volume IDs, such as vol-3cdd3f56, vol-4cdd3f56.
        /// </summary>
        public static readonly ParameterType VolumeIdList = new ParameterType("List<AWS::EC2::Volume::Id>");
        
        /// <summary>
        /// <![CDATA[List<AWS::EC2::VPC::Id>]]>
        /// An array of VPC IDs, such as vpc-a123baa3, vpc-b456baa3.
        /// </summary>
        public static readonly ParameterType VpcIdList = new ParameterType("List<AWS::EC2::VPC::Id>");
        
        /// <summary>
        /// <![CDATA[List<AWS::Route53::HostedZone::Id>]]>
        /// An array of Route 53 hosted zone IDs, such as Z23YXV4OVPL04A, Z23YXV4OVPL04B.
        /// </summary>
        public static readonly ParameterType HostedZoneIdList = new ParameterType("List<AWS::Route53::HostedZone::Id>");
    }
}