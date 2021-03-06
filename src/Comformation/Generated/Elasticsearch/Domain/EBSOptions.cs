using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain EBSOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-ebsoptions.html
    /// </summary>
    public class EBSOptions
    {

        /// <summary>
        /// EBSEnabled
        /// Specifies whether Amazon EBS volumes are attached to data nodes in the Amazon ES domain.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EBSEnabled")]
        public Union<bool, IntrinsicFunction> EBSEnabled { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) that the volume supports. This property applies only
        /// to the Provisioned IOPS (SSD) EBS volume type.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// VolumeSize
        /// The size (in GiB) of the EBS volume for each data node. The minimum and maximum size of an EBS
        /// volume depends on the EBS volume type and the instance type to which it is attached. For more
        /// information, see Configuring EBS-based Storage in the Amazon Elasticsearch Service Developer Guide.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The EBS volume type to use with the Amazon ES domain, such as standard, gp2, or io1. For more
        /// information about each type, see Amazon EBS Volume Types in the Amazon EC2 User Guide for Linux
        /// Instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
