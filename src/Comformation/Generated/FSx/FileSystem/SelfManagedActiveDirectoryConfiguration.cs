using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FSx.FileSystem
{
    /// <summary>
    /// AWS::FSx::FileSystem SelfManagedActiveDirectoryConfiguration
    /// The configuration that Amazon FSx uses to join the Windows File Server instance to your self-managed
    /// (including on-premises) Microsoft Active Directory (AD) directory.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html
    /// </summary>
    public class SelfManagedActiveDirectoryConfiguration
    {

        /// <summary>
        /// FileSystemAdministratorsGroup
        /// (Optional) The name of the domain group whose members are granted administrative privileges for the
        /// file system. Administrative privileges include taking ownership of files and folders, and setting
        /// audit controls (audit ACLs) on files and folders. The group that you specify must already exist in
        /// your domain. If you don&#39;t provide one, your AD domain&#39;s Domain Admins group is used.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FileSystemAdministratorsGroup")]
        public Union<string, IntrinsicFunction> FileSystemAdministratorsGroup { get; set; }

        /// <summary>
        /// UserName
        /// The user name for the service account on your self-managed AD domain that Amazon FSx will use to
        /// join to your AD domain. This account must have the permission to join computers to the domain in the
        /// organizational unit provided in OrganizationalUnitDistinguishedName, or in the default location of
        /// your AD domain.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserName")]
        public Union<string, IntrinsicFunction> UserName { get; set; }

        /// <summary>
        /// DomainName
        /// The fully qualified domain name of the self-managed AD directory, such as corp. example. com.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// OrganizationalUnitDistinguishedName
        /// (Optional) The fully qualified distinguished name of the organizational unit within your
        /// self-managed AD directory that the Windows File Server instance will join. Amazon FSx only accepts
        /// OU as the direct parent of the file system. An example is OU=FSx,DC=yourdomain,DC=corp,DC=com. To
        /// learn more, see RFC 2253. If none is provided, the FSx file system is created in the default
        /// location of your self-managed AD directory.
        /// Important Only Organizational Unit (OU) objects can be the direct parent of the file system that
        /// you&#39;re creating.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2000
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OrganizationalUnitDistinguishedName")]
        public Union<string, IntrinsicFunction> OrganizationalUnitDistinguishedName { get; set; }

        /// <summary>
        /// DnsIps
        /// A list of up to two IP addresses of DNS servers or domain controllers in the self-managed AD
        /// directory. The IP addresses need to be either in the same VPC CIDR range as the one in which your
        /// Amazon FSx file system is being created, or in the private IP version 4 (IPv4) address ranges, as
        /// specified in RFC 1918:
        /// 10. 0. 0. 0 - 10. 255. 255. 255 (10/8 prefix) 172. 16. 0. 0 - 172. 31. 255. 255 (172. 16/12 prefix)
        /// 192. 168. 0. 0 - 192. 168. 255. 255 (192. 168/16 prefix)
        /// Required: No
        /// Type: List of String
        /// Maximum: 2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DnsIps")]
        public List<Union<string, IntrinsicFunction>> DnsIps { get; set; }

        /// <summary>
        /// Password
        /// The password for the service account on your self-managed AD domain that Amazon FSx will use to join
        /// to your AD domain. We strongly suggest that you follow best practices and do not embed passwords in
        /// your CFN templates.
        /// The recommended approach is to use AWS Secrets Manager to store your passwords. You can retrieve
        /// them for use in your templates using the secretsmanager dynamic reference. There are additional
        /// costs associated with using AWS Secrets Manager. To learn more, see Secrets Manager Secrets in the
        /// AWS CloudFormation User Guide.
        /// Alternatively, you can use the NoEcho property to obfuscate the password parameter value. For more
        /// information, see Do Not Embed Credentials in Your Templates in the AWS CloudFormation User Guide.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

    }
}