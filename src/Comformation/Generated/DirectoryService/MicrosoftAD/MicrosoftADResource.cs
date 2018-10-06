using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.MicrosoftAD
{
    /// <summary>
    /// AWS::DirectoryService::MicrosoftAD
    /// The AWS::DirectoryService::MicrosoftAD resource creates a Microsoft Active Directory in AWS so that your
    /// directory users and groups can access the AWS Management Console and AWS applications using their existing
    /// credentials. For more information, see What Is AWS Directory Service? in the AWS Directory Service
    /// Administration Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html
    /// </summary>
    public class MicrosoftADResource : ResourceBase
    {
        public class MicrosoftADProperties
        {
            /// <summary>
            /// CreateAlias
            /// A unique alias to assign to the Microsoft Active Directory in AWS. AWS Directory Service uses the
            /// alias to construct the access URL for the directory, such as http://alias. awsapps. com. By default,
            /// AWS CloudFormation does not create an alias.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> CreateAlias { get; set; }

            /// <summary>
            /// Edition
            /// The AWS Microsoft AD edition. Valid values include Standard and Enterprise. The default is
            /// Enterprise.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Edition { get; set; }

            /// <summary>
            /// EnableSso
            /// Whether to enable single sign-on for a Microsoft Active Directory in AWS. Single sign-on allows
            /// users in your directory to access certain AWS services from a computer joined to the directory
            /// without having to enter their credentials separately. If you don&#39;t specify a value, AWS
            /// CloudFormation disables single sign-on by default.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableSso { get; set; }

            /// <summary>
            /// Name
            /// The fully qualified name for the Microsoft Active Directory in AWS, such as corp. example. com. The
            /// name doesn&#39;t need to be publicly resolvable; it will resolve inside your VPC only.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Password
            /// The password for the default administrative user, Admin.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            /// ShortName
            /// The NetBIOS name for your domain, such as CORP. If you don&#39;t specify a value, AWS Directory Service
            /// uses the first part of your directory DNS server name. For example, if your directory DNS server
            /// name is corp. example. com, AWS Directory Service specifies CORP for the NetBIOS name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ShortName { get; set; }

            /// <summary>
            /// VpcSettings
            /// Specifies the VPC settings of the Microsoft Active Directory server in AWS.
            /// Required: Yes
            /// Type: AWS Directory Service MicrosoftAD VpcSettings
            /// Update requires: Replacement
            /// </summary>
			public VpcSettings VpcSettings { get; set; }

        }
    
        public string Type { get; } = "AWS::DirectoryService::MicrosoftAD";
        
        public MicrosoftADProperties Properties { get; } = new MicrosoftADProperties();

    }

	public static class MicrosoftADAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Alias = new ResourceAttribute<Union<string, IntrinsicFunction>>("Alias");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> DnsIpAddresses = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("DnsIpAddresses");
	}
}
