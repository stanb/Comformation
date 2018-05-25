using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WorkSpaces.Workspace
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html
    /// </summary>
    public class WorkspaceResource : ResourceBase
    {
        public class WorkspaceProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-bundleid
            /// </summary>
			public Union<string, IntrinsicFunction> BundleId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-directoryid
            /// </summary>
			public Union<string, IntrinsicFunction> DirectoryId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-rootvolumeencryptionenabled
            /// </summary>
			public Union<bool, IntrinsicFunction> RootVolumeEncryptionEnabled { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-username
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-uservolumeencryptionenabled
            /// </summary>
			public Union<bool, IntrinsicFunction> UserVolumeEncryptionEnabled { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-volumeencryptionkey
            /// </summary>
			public Union<string, IntrinsicFunction> VolumeEncryptionKey { get; set; }

        }
    
        public string Type { get; } = "AWS::WorkSpaces::Workspace";
        
        public WorkspaceProperties Properties { get; } = new WorkspaceProperties();
    }
}
