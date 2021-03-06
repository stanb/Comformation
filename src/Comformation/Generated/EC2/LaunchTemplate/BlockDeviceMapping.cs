using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate BlockDeviceMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-blockdevicemapping.html
    /// </summary>
    public class BlockDeviceMapping
    {

        /// <summary>
        /// Ebs
        /// Parameters used to automatically set up EBS volumes when the instance is launched.
        /// Required: No
        /// Type: Ebs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ebs")]
        public Ebs Ebs { get; set; }

        /// <summary>
        /// NoDevice
        /// To omit the device from the block device mapping, specify an empty string.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<string, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// VirtualName
        /// The virtual device name (ephemeralN). Instance store volumes are numbered starting from 0. An
        /// instance type with 2 available instance store volumes can specify mappings for ephemeral0 and
        /// ephemeral1. The number of available instance store volumes depends on the instance type. After you
        /// connect to the instance, you must mount the volume.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

        /// <summary>
        /// DeviceName
        /// The device name (for example, /dev/sdh or xvdh).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

    }
}
