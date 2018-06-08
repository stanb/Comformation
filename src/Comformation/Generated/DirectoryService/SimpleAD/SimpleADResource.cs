using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.SimpleAD
{
    /// <summary>
    /// AWS::DirectoryService::SimpleAD
    /// The AWS::DirectoryService::SimpleAD resource creates an AWS Directory Service Simple Active Directory (Simple
    /// AD) in AWS so that your directory users and groups can access the AWS Management Console and AWS applications
    /// using their existing credentials. Simple AD is a Microsoft Active Directory–compatible directory. For more
    /// information, see What Is AWS Directory Service? in the AWS Directory Service Administration Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html
    /// </summary>
    public class SimpleADResource : ResourceBase
    {
        public class SimpleADProperties
        {
            /// <summary>
            /// CreateAlias
            /// A unique alias to assign to the directory. AWS Directory Service uses the alias to construct the
            /// access URL for the directory, such as http://alias. awsapps. com. By default, AWS CloudFormation
            /// does not create an alias.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> CreateAlias { get; set; }

            /// <summary>
            /// Description
            /// A description of the directory.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnableSso
            /// Whether to enable single sign-on for a directory. If you don't specify a value, AWS CloudFormation
            /// disables single sign-on by default.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableSso { get; set; }

            /// <summary>
            /// Name
            /// The fully qualified name for the directory, such as corp. example. com.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Password
            /// The password for the directory administrator. AWS Directory Service creates a directory
            /// administrator account with the user name Administrator and this password.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            /// ShortName
            /// The NetBIOS name of the on-premises directory, such as CORP.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ShortName { get; set; }

            /// <summary>
            /// Size
            /// The size of the directory. For valid values, see CreateDirectory in the AWS Directory Service API
            /// Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Size { get; set; }

            /// <summary>
            /// VpcSettings
            /// Specifies the VPC settings of the directory server.
            /// Required: Yes
            /// Type: AWS Directory Service SimpleAD VpcSettings
            /// Update requires: Replacement
            /// </summary>
			public Union<VpcSettings, IntrinsicFunction> VpcSettings { get; set; }

        }
    
        public string Type { get; } = "AWS::DirectoryService::SimpleAD";
        
        public SimpleADProperties Properties { get; } = new SimpleADProperties();
    }

	public static class SimpleADAttributes
	{
        public static readonly ResourceAttribute<string> Alias = new ResourceAttribute<string>("Alias");
        public static readonly ResourceAttribute<List<string>> DnsIpAddresses = new ResourceAttribute<List<string>>("DnsIpAddresses");
	}
}
