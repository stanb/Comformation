using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster PlacementType
    /// The PlacementType property type specifies the Availability Zone (AZ) in which the job flow runs. PlacementType
    /// is the property type for the Placement subproperty of the Amazon EMR Cluster JobFlowInstancesConfig property
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-placementtype.html
    /// </summary>
    public class PlacementType
    {

        /// <summary>
        /// AvailabilityZone
        /// The Amazon Elastic Compute Cloud (Amazon EC2) AZ for the job flow. For more information, see
        /// http://docs. aws. amazon. com/AWSEC2/latest/UserGuide/using-regions-availability-zones. html in the
        /// Amazon EC2 User Guide for Linux Instances.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

    }
}
