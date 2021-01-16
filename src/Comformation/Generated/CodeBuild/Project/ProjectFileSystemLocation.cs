using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project ProjectFileSystemLocation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectfilesystemlocation.html
    /// </summary>
    public class ProjectFileSystemLocation
    {

        /// <summary>
        /// MountPoint
        /// The location in the container where you mount the file system.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MountPoint")]
        public Union<string, IntrinsicFunction> MountPoint { get; set; }

        /// <summary>
        /// Type
        /// The type of the file system. The one supported type is EFS.
        /// Required: Yes
        /// Type: String
        /// Allowed values: EFS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Identifier
        /// The name used to access a file system created by Amazon EFS. CodeBuild creates an environment
        /// variable by appending the identifier in all capital letters to CODEBUILD_. For example, if you
        /// specify my_efs for identifier, a new environment variable is create named CODEBUILD_MY_EFS.
        /// The identifier is used to mount your file system.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Identifier")]
        public Union<string, IntrinsicFunction> Identifier { get; set; }

        /// <summary>
        /// MountOptions
        /// The mount options for a file system created by AWS EFS. The default mount options used by CodeBuild
        /// are nfsvers=4. 1,rsize=1048576,wsize=1048576,hard,timeo=600,retrans=2. For more information, see
        /// Recommended NFS Mount Options.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MountOptions")]
        public Union<string, IntrinsicFunction> MountOptions { get; set; }

        /// <summary>
        /// Location
        /// A string that specifies the location of the file system created by Amazon EFS. Its format is
        /// efs-dns-name:/directory-path. You can find the DNS name of file system when you view it in the AWS
        /// EFS console. The directory path is a path to a directory in the file system that CodeBuild mounts.
        /// For example, if the DNS name of a file system is fs-abcd1234. efs. us-west-2. amazonaws. com, and
        /// its mount directory is my-efs-mount-directory, then the location is fs-abcd1234. efs. us-west-2.
        /// amazonaws. com:/my-efs-mount-directory.
        /// The directory path in the format efs-dns-name:/directory-path is optional. If you do not specify a
        /// directory path, the location is only the DNS name and CodeBuild mounts the entire file system.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
