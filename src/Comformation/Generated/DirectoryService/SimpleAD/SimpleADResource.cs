using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.SimpleAD
{
    /// <summary>
    /// AWS::DirectoryService::SimpleAD
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html
    /// </summary>
    public class SimpleADResource : ResourceBase
    {
        public class SimpleADProperties
        {
            /// <summary>
            /// CreateAlias
            /// If set to true, specifies an alias for a directory and assigns the alias to the directory. The alias
            /// is used to construct the access URL for the directory, such as http://&amp;lt;alias&amp;gt;. awsapps. com.
            /// By default, this property is set to false.
            /// Important After an alias has been created, it cannot be deleted or reused, so this operation should
            /// only be used when absolutely necessary.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> CreateAlias { get; set; }

            /// <summary>
            /// Description
            /// A description for the directory.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 128
            /// Pattern: ^([a-zA-Z0-9_])[\\a-zA-Z0-9_@#%*+=:?. /!\s-]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnableSso
            /// Whether to enable single sign-on for a directory. If you don&#39;t specify a value, AWS CloudFormation
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
            /// Pattern: ^([a-zA-Z0-9]+[\\. -])+([a-zA-Z0-9])+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Password
            /// The password for the directory administrator. The directory creation process creates a directory
            /// administrator account with the user name Administrator and this password.
            /// If you need to change the password for the administrator account, see the ResetUserPassword API call
            /// in the AWS Directory Service API Reference.
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
            /// The NetBIOS name of the directory, such as CORP.
            /// Required: No
            /// Type: String
            /// Pattern: ^[^\\/:*?&quot;&amp;lt;&amp;gt;|. ]+[^\\/:*?&quot;&amp;lt;&amp;gt;|]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ShortName { get; set; }

            /// <summary>
            /// Size
            /// The size of the directory. For valid values, see CreateDirectory in the AWS Directory Service API
            /// Reference.
            /// Required: Yes
            /// Type: String
            /// Allowed values: Large | Small
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Size { get; set; }

            /// <summary>
            /// VpcSettings
            /// A DirectoryVpcSettings object that contains additional information for the operation.
            /// Required: Yes
            /// Type: VpcSettings
            /// Update requires: Replacement
            /// </summary>
            public VpcSettings VpcSettings { get; set; }

        }

        public string Type { get; } = "AWS::DirectoryService::SimpleAD";

        public SimpleADProperties Properties { get; } = new SimpleADProperties();

    }

    public static class SimpleADAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Alias = new ResourceAttribute<Union<string, IntrinsicFunction>>("Alias");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> DnsIpAddresses = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("DnsIpAddresses");
    }
}
