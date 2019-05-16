using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.DirectoryConfig
{
    /// <summary>
    /// AWS::AppStream::DirectoryConfig
    /// The AWS::AppStream::DirectoryConfig resource specifies the configuration information required to join Amazon
    /// AppStream 2. 0 fleets and image builders to Microsoft Active Directory domains.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html
    /// </summary>
    public class DirectoryConfigResource : ResourceBase
    {
        public class DirectoryConfigProperties
        {
            /// <summary>
            /// OrganizationalUnitDistinguishedNames
            /// The distinguished names of the organizational units for computer accounts.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> OrganizationalUnitDistinguishedNames { get; set; }

            /// <summary>
            /// ServiceAccountCredentials
            /// The credentials for the service account used by the streaming instance to connect to the directory.
            /// Do not use this parameter directly. Use ServiceAccountCredentials as an input parameter with noEcho
            /// as shown in the Parameters. For best practices information, see Do Not Embed Credentials in Your
            /// Templates.
            /// Required: Yes
            /// Type: ServiceAccountCredentials
            /// Update requires: No interruption
            /// </summary>
			public ServiceAccountCredentials ServiceAccountCredentials { get; set; }

            /// <summary>
            /// DirectoryName
            /// The fully qualified name of the directory (for example, corp. example. com).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DirectoryName { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::DirectoryConfig";

        public DirectoryConfigProperties Properties { get; } = new DirectoryConfigProperties();

    }
}
