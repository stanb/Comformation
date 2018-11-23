using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WorkSpaces.Workspace
{
    /// <summary>
    /// AWS::WorkSpaces::Workspace
    /// The AWS::WorkSpaces::Workspace resource creates an Amazon WorkSpaces workspace, which is a cloud-based desktop
    /// experience for end users. Before creating a Workspace in CloudFormation, you must register a Directory Service
    /// directory with Workspaces. This process is documented at Register a Directory with Amazon WorkSpaces. For more
    /// information, see the Amazon WorkSpaces Administration Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html
    /// </summary>
    public class WorkspaceResource : ResourceBase
    {
        public class WorkspaceProperties
        {
            /// <summary>
            /// BundleId
            /// The identifier of the bundle from which you want to create the workspace. A bundle specifies the
            /// details of the workspace, such as the installed applications and the size of CPU, memory, and
            /// storage. Use the DescribeWorkspaceBundles action to list the bundles that AWS offers.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported. . To update this property, you must also update another
            /// property that triggers a replacement, such as the UserName property.
            /// </summary>
			public Union<string, IntrinsicFunction> BundleId { get; set; }

            /// <summary>
            /// DirectoryId
            /// The identifier of the AWS Directory Service directory in which you want to create the workspace. The
            /// directory must already be registered with Amazon WorkSpaces. Use the DescribeWorkspaceDirectories
            /// action to list the directories that are available.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DirectoryId { get; set; }

            /// <summary>
            /// RootVolumeEncryptionEnabled
            /// Indicates whether Amazon WorkSpaces encrypts data stored on the root volume (C: drive).
            /// Required: No
            /// Type: Boolean
            /// Update requires: Updates are not supported. . To update this property, you must also update another
            /// property that triggers a replacement, such as the UserName property.
            /// </summary>
			public Union<bool, IntrinsicFunction> RootVolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// Tags
            /// The tags (key-value pairs) for the WorkSpace.
            /// Required: No
            /// Type: List of Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// UserName
            /// The name of the user to which the workspace is assigned. This user name must exist in the specified
            /// AWS Directory Service directory.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// UserVolumeEncryptionEnabled
            /// Indicates whether Amazon WorkSpaces encrypts data stored on the user volume (D: drive).
            /// Required: No
            /// Type: Boolean
            /// Update requires: Updates are not supported. . To update this property, you must also update another
            /// property that triggers a replacement, such as the UserName property.
            /// </summary>
			public Union<bool, IntrinsicFunction> UserVolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// VolumeEncryptionKey
            /// The AWS Key Management Service (AWS KMS) key ID that Amazon WorkSpaces uses to encrypt data stored
            /// on your workspace.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported. . To update this property, you must also update another
            /// property that triggers a replacement, such as the UserName property.
            /// </summary>
			public Union<string, IntrinsicFunction> VolumeEncryptionKey { get; set; }

            /// <summary>
            /// WorkspaceProperties
            /// The WorkSpace properties.
            /// Required: No
            /// Type: Amazon WorkSpaces Workspace WorkspaceProperties
            /// Update requires: No interruption
            /// </summary>
			[Newtonsoft.Json.JsonProperty("WorkspaceProperties")]
			public Comformation.WorkSpaces.Workspace.WorkspaceProperties WorkspaceProperties_ { get; set; }

        }

        public string Type { get; } = "AWS::WorkSpaces::Workspace";

        public WorkspaceProperties Properties { get; } = new WorkspaceProperties();

    }
}
