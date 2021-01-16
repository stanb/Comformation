using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition Tmpfs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html
    /// </summary>
    public class Tmpfs
    {

        /// <summary>
        /// ContainerPath
        /// 		
        /// The absolute file path where the tmpfs volume is to be mounted.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerPath")]
        public Union<string, IntrinsicFunction> ContainerPath { get; set; }

        /// <summary>
        /// MountOptions
        /// 		
        /// The list of tmpfs volume mount options.
        /// 		
        /// Valid values: &quot;defaults&quot; | &quot;ro&quot; | &quot;rw&quot; | &quot;suid&quot; | &quot;nosuid&quot; | &quot;dev&quot; | &quot;nodev&quot; | 				&quot;exec&quot; | &quot;noexec&quot;
        /// | &quot;sync&quot; | &quot;async&quot; | &quot;dirsync&quot; | &quot;remount&quot; | &quot;mand&quot; | &quot;nomand&quot; | 				&quot;atime&quot; | &quot;noatime&quot; |
        /// &quot;diratime&quot; | &quot;nodiratime&quot; | &quot;bind&quot; | &quot;rbind&quot; | &quot;unbindable&quot; | 				&quot;runbindable&quot; | &quot;private&quot; |
        /// &quot;rprivate&quot; | &quot;shared&quot; | &quot;rshared&quot; | &quot;slave&quot; | &quot;rslave&quot; | 				&quot;relatime&quot; | &quot;norelatime&quot; |
        /// &quot;strictatime&quot; | &quot;nostrictatime&quot; | &quot;mode&quot; | &quot;uid&quot; | &quot;gid&quot; 				| &quot;nr_inodes&quot; | &quot;nr_blocks&quot; | &quot;mpol&quot;
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MountOptions")]
        public List<Union<string, IntrinsicFunction>> MountOptions { get; set; }

        /// <summary>
        /// Size
        /// 		
        /// The maximum size (in MiB) of the tmpfs volume.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

    }
}
