using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WorkSpaces.Workspace
{
    /// <summary>
    /// AWS::WorkSpaces::Workspace
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html
    /// </summary>
    public class WorkspaceResource : ResourceBase
    {
        public class WorkspaceProperties
        {
            /// <summary>
            /// BundleId
            /// The identifier of the bundle for the WorkSpace.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^wsb-[0-9a-z]{8,63}$
            /// Update requires: Updates are not supported.
            /// </summary>
            public Union<string, IntrinsicFunction> BundleId { get; set; }

            /// <summary>
            /// DirectoryId
            /// The identifier of the AWS Directory Service directory for the WorkSpace.
            /// Required: Yes
            /// Type: String
            /// Minimum: 10
            /// Maximum: 65
            /// Pattern: ^d-[0-9a-f]{8,63}$
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> DirectoryId { get; set; }

            /// <summary>
            /// RootVolumeEncryptionEnabled
            /// Indicates whether the data stored on the root volume is encrypted.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Updates are not supported.
            /// </summary>
            public Union<bool, IntrinsicFunction> RootVolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the WorkSpace.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// UserName
            /// The user name of the user for the WorkSpace. This user name must exist in the AWS Directory Service
            /// directory for the WorkSpace.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            /// UserVolumeEncryptionEnabled
            /// Indicates whether the data stored on the user volume is encrypted.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Updates are not supported.
            /// </summary>
            public Union<bool, IntrinsicFunction> UserVolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// VolumeEncryptionKey
            /// The symmetric AWS KMS key used to encrypt data stored on your WorkSpace. Amazon WorkSpaces does not
            /// support asymmetric KMS keys.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
            public Union<string, IntrinsicFunction> VolumeEncryptionKey { get; set; }

            /// <summary>
            /// WorkspaceProperties
            /// The WorkSpace properties.
            /// Required: No
            /// Type: WorkspaceProperties
            /// Update requires: No interruption
            /// </summary>
            [Newtonsoft.Json.JsonProperty("WorkspaceProperties")]
            public Comformation.WorkSpaces.Workspace.WorkspaceProperties WorkspaceProperties_ { get; set; }

        }

        public string Type { get; } = "AWS::WorkSpaces::Workspace";

        public WorkspaceProperties Properties { get; } = new WorkspaceProperties();

    }
}
