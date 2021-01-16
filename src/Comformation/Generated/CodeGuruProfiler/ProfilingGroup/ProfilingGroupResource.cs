using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeGuruProfiler.ProfilingGroup
{
    /// <summary>
    /// AWS::CodeGuruProfiler::ProfilingGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html
    /// </summary>
    public class ProfilingGroupResource : ResourceBase
    {
        public class ProfilingGroupProperties
        {
            /// <summary>
            /// ProfilingGroupName
            /// The name of the profiling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProfilingGroupName { get; set; }

            /// <summary>
            /// ComputePlatform
            /// The compute platform of the profiling group. Use AWSLambda if your application runs on AWS Lambda.
            /// Use Default if your application runs on a compute platform that is not AWS Lambda, such an Amazon
            /// EC2 instance, an on-premises server, or a different platform. If not specified, Default is used.
            /// This property is immutable.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ComputePlatform { get; set; }

            /// <summary>
            /// AgentPermissions
            /// The agent permissions attached to this profiling group. This action group grants ConfigureAgent and
            /// PostAgentProfile permissions to perform actions required by the profiling agent. The Json consists
            /// of key Principals.
            /// Principals: A list of string ARNs for the roles and users you want to grant access to the profiling
            /// group. Wildcards are not supported in the ARNs. You are allowed to provide up to 50 ARNs. An empty
            /// list is not permitted. This is a required key.
            /// For more information, see Resource-based policies in CodeGuru Profiler in the Amazon CodeGuru
            /// Profiler user guide, ConfigureAgent, and PostAgentProfile.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AgentPermissions { get; set; }

            /// <summary>
            /// AnomalyDetectionNotificationConfiguration
            /// Adds anomaly notifications for a profiling group.
            /// Required: No
            /// Type: List of Channel
            /// Update requires: No interruption
            /// </summary>
            public List<Channel> AnomalyDetectionNotificationConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags to add to the created profiling group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CodeGuruProfiler::ProfilingGroup";

        public ProfilingGroupProperties Properties { get; } = new ProfilingGroupProperties();

    }

    public static class ProfilingGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
