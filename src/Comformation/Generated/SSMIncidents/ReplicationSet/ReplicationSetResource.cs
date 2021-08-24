using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ReplicationSet
{
    /// <summary>
    /// AWS::SSMIncidents::ReplicationSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-replicationset.html
    /// </summary>
    public class ReplicationSetResource : ResourceBase
    {
        public class ReplicationSetProperties
        {
            /// <summary>
            /// Regions
            /// Specifies the Regions of the replication set.
            /// Required: Yes
            /// Type: List of ReplicationRegion
            /// Update requires: No interruption
            /// </summary>
            public List<ReplicationRegion> Regions { get; set; }

            /// <summary>
            /// DeletionProtected
            /// Determines if the replication set deletion protection is enabled or not. If deletion protection is
            /// enabled, you can&#39;t delete the last Region in the replication set.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeletionProtected { get; set; }

        }

        public string Type { get; } = "AWS::SSMIncidents::ReplicationSet";

        public ReplicationSetProperties Properties { get; } = new ReplicationSetProperties();

    }

    public static class ReplicationSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
