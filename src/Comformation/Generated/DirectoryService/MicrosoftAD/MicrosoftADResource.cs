using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.MicrosoftAD
{
    /// <summary>
    /// AWS::DirectoryService::MicrosoftAD
    /// The AWS::DirectoryService::MicrosoftAD resource specifies a Microsoft Active Directory in AWS so that your
    /// directory users and groups can access the AWS Management Console and AWS applications using their existing
    /// credentials. For more information, see AWS Managed Microsoft AD in the AWS Directory Service Admin Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html
    /// </summary>
    public class MicrosoftADResource : ResourceBase
    {
        public class MicrosoftADProperties
        {
            /// <summary>
            /// CreateAlias
            /// Specifies an alias for a directory and assigns the alias to the directory. The alias is used to
            /// construct the access URL for the directory, such as http://&amp;lt;alias&amp;gt;. awsapps. com. By default,
            /// AWS CloudFormation does not create an alias.
            /// Important After an alias has been created, it cannot be deleted or reused, so this operation should
            /// only be used when absolutely necessary.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> CreateAlias { get; set; }

            /// <summary>
            /// Edition
            /// AWS Managed Microsoft AD is available in two editions: Standard and Enterprise. Enterprise is the
            /// default.
            /// Required: No
            /// Type: String
            /// Allowed Values: Enterprise | Standard
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
            /// The fully qualified domain name for the directory, such as corp. example. com. This name will
            /// resolve inside your VPC only. It does not need to be publicly resolvable.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^([a-zA-Z0-9]+[\\. -])+([a-zA-Z0-9])+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Password
            /// The password for the default administrative user named Admin.
            /// Required: Yes
            /// Type: String
            /// Pattern: (?=^. {8,64}$)((?=. *\d)(?=. *[A-Z])(?=. *[a-z])|(?=. *\d)(?=. *[^A-Za-z0-9\s])(?=.
            /// *[a-z])|(?=. *[^A-Za-z0-9\s])(?=. *[A-Z])(?=. *[a-z])|(?=. *\d)(?=. *[A-Z])(?=. *[^A-Za-z0-9\s]))^.
            /// *
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Password { get; set; }

            /// <summary>
            /// ShortName
            /// The NetBIOS name for your domain. A short identifier for your domain, such as CORP. If you don&#39;t
            /// specify a NetBIOS name, it will default to the first part of your directory DNS. For example, CORP
            /// for the directory DNS corp. example. com.
            /// Required: No
            /// Type: String
            /// Pattern: ^[^\\/:*?\&quot;\&amp;lt;\&amp;gt;|. ]+[^\\/:*?\&quot;&amp;lt;&amp;gt;|]*$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ShortName { get; set; }

            /// <summary>
            /// VpcSettings
            /// Specifies the VPC settings of the Microsoft AD directory server in AWS.
            /// Required: Yes
            /// Type: VpcSettings
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
