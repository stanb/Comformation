using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition KernelCapabilities
    /// The KernelCapabilities property specifies the Linux capabilities for the container that are added to or
    /// dropped from the default configuration that is provided by Docker. For more information on the default
    /// capabilities and the non-default available capabilities, see Runtime privilege and Linux capabilities in the
    /// Docker run reference. For more detailed information on these Linux capabilities, see the capabilities(7) Linux
    /// manual page.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-kernelcapabilities.html
    /// </summary>
    public class KernelCapabilities
    {

        /// <summary>
        /// Add
        /// The Linux capabilities for the container that have been added to the default configuration provided
        /// by Docker. This parameter maps to CapAdd in the Create a container section of the Docker Remote API
        /// and the --cap-add option to docker run.
        /// Note If you are using tasks that use the Fargate launch type, the add parameter is not supported.
        /// Valid values: &quot;ALL&quot; | &quot;AUDIT_CONTROL&quot; | &quot;AUDIT_WRITE&quot; | &quot;BLOCK_SUSPEND&quot; | &quot;CHOWN&quot; | &quot;DAC_OVERRIDE&quot; |
        /// &quot;DAC_READ_SEARCH&quot; | &quot;FOWNER&quot; | &quot;FSETID&quot; | &quot;IPC_LOCK&quot; | &quot;IPC_OWNER&quot; | &quot;KILL&quot; | &quot;LEASE&quot; |
        /// &quot;LINUX_IMMUTABLE&quot; | &quot;MAC_ADMIN&quot; | &quot;MAC_OVERRIDE&quot; | &quot;MKNOD&quot; | &quot;NET_ADMIN&quot; | &quot;NET_BIND_SERVICE&quot; |
        /// &quot;NET_BROADCAST&quot; | &quot;NET_RAW&quot; | &quot;SETFCAP&quot; | &quot;SETGID&quot; | &quot;SETPCAP&quot; | &quot;SETUID&quot; | &quot;SYS_ADMIN&quot; | &quot;SYS_BOOT&quot;
        /// | &quot;SYS_CHROOT&quot; | &quot;SYS_MODULE&quot; | &quot;SYS_NICE&quot; | &quot;SYS_PACCT&quot; | &quot;SYS_PTRACE&quot; | &quot;SYS_RAWIO&quot; |
        /// &quot;SYS_RESOURCE&quot; | &quot;SYS_TIME&quot; | &quot;SYS_TTY_CONFIG&quot; | &quot;SYSLOG&quot; | &quot;WAKE_ALARM&quot;
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Add")]
        public List<Union<string, IntrinsicFunction>> Add { get; set; }

        /// <summary>
        /// Drop
        /// The Linux capabilities for the container that have been removed from the default configuration
        /// provided by Docker. This parameter maps to CapDrop in the Create a container section of the Docker
        /// Remote API and the --cap-drop option to docker run.
        /// Valid values: &quot;ALL&quot; | &quot;AUDIT_CONTROL&quot; | &quot;AUDIT_WRITE&quot; | &quot;BLOCK_SUSPEND&quot; | &quot;CHOWN&quot; | &quot;DAC_OVERRIDE&quot; |
        /// &quot;DAC_READ_SEARCH&quot; | &quot;FOWNER&quot; | &quot;FSETID&quot; | &quot;IPC_LOCK&quot; | &quot;IPC_OWNER&quot; | &quot;KILL&quot; | &quot;LEASE&quot; |
        /// &quot;LINUX_IMMUTABLE&quot; | &quot;MAC_ADMIN&quot; | &quot;MAC_OVERRIDE&quot; | &quot;MKNOD&quot; | &quot;NET_ADMIN&quot; | &quot;NET_BIND_SERVICE&quot; |
        /// &quot;NET_BROADCAST&quot; | &quot;NET_RAW&quot; | &quot;SETFCAP&quot; | &quot;SETGID&quot; | &quot;SETPCAP&quot; | &quot;SETUID&quot; | &quot;SYS_ADMIN&quot; | &quot;SYS_BOOT&quot;
        /// | &quot;SYS_CHROOT&quot; | &quot;SYS_MODULE&quot; | &quot;SYS_NICE&quot; | &quot;SYS_PACCT&quot; | &quot;SYS_PTRACE&quot; | &quot;SYS_RAWIO&quot; |
        /// &quot;SYS_RESOURCE&quot; | &quot;SYS_TIME&quot; | &quot;SYS_TTY_CONFIG&quot; | &quot;SYSLOG&quot; | &quot;WAKE_ALARM&quot;
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Drop")]
        public List<Union<string, IntrinsicFunction>> Drop { get; set; }

    }
}
