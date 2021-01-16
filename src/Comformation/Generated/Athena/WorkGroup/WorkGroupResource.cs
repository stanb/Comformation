using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.WorkGroup
{
    /// <summary>
    /// AWS::Athena::WorkGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-workgroup.html
    /// </summary>
    public class WorkGroupResource : ResourceBase
    {
        public class WorkGroupProperties
        {
            /// <summary>
            /// Name
            /// The workgroup name.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-zA-Z0-9. _-]{1,128}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The workgroup description.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// WorkGroupConfiguration
            /// The configuration of the workgroup, which includes the location in Amazon S3 where query results are
            /// stored, the encryption option, if any, used for query results, whether Amazon CloudWatch Metrics are
            /// enabled for the workgroup, and the limit for the amount of bytes scanned (cutoff) per query, if it
            /// is specified. The EnforceWorkGroupConfiguration option determines whether workgroup settings
            /// override client-side query settings.
            /// Required: No
            /// Type: WorkGroupConfiguration
            /// Update requires: No interruption
            /// </summary>
            public WorkGroupConfiguration WorkGroupConfiguration { get; set; }

            /// <summary>
            /// WorkGroupConfigurationUpdates
            /// The configuration information that will be updated for this workgroup, which includes the location
            /// in Amazon S3 where query results are stored, the encryption option, if any, used for query results,
            /// whether the Amazon CloudWatch Metrics are enabled for the workgroup, whether the workgroup settings
            /// override the client-side settings, and the data usage limit for the amount of bytes scanned per
            /// query, if it is specified.
            /// Required: No
            /// Type: WorkGroupConfigurationUpdates
            /// Update requires: No interruption
            /// </summary>
            public WorkGroupConfigurationUpdates WorkGroupConfigurationUpdates { get; set; }

            /// <summary>
            /// State
            /// The state of the workgroup: ENABLED or DISABLED.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// RecursiveDeleteOption
            /// The option to delete the workgroup and its contents even if the workgroup contains any named queries
            /// or query executions.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> RecursiveDeleteOption { get; set; }

        }

        public string Type { get; } = "AWS::Athena::WorkGroup";

        public WorkGroupProperties Properties { get; } = new WorkGroupProperties();

    }

    public static class WorkGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
