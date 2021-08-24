using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html
    /// </summary>
    public class SecurityProfileResource : ResourceBase
    {
        public class SecurityProfileProperties
        {
            /// <summary>
            /// SecurityProfileName
            /// The name you gave to the security profile.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SecurityProfileName { get; set; }

            /// <summary>
            /// SecurityProfileDescription
            /// A description of the security profile.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SecurityProfileDescription { get; set; }

            /// <summary>
            /// Behaviors
            /// Specifies the behaviors that, when violated by a device (thing), cause an alert.
            /// Required: No
            /// Type: List of Behavior
            /// Update requires: No interruption
            /// </summary>
            public List<Behavior> Behaviors { get; set; }

            /// <summary>
            /// AlertTargets
            /// Specifies the destinations to which alerts are sent. (Alerts are always sent to the console. )
            /// Alerts are generated when a device (thing) violates a behavior.
            /// Required: No
            /// Type: Map of AlertTarget
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, AlertTarget> AlertTargets { get; set; }

            /// <summary>
            /// AdditionalMetricsToRetainV2
            /// A list of metrics whose data is retained (stored). By default, data is retained for any metric used
            /// in the profile&#39;s behaviors, but it&#39;s also retained for any metric specified here. Can be used with
            /// custom metrics; can&#39;t be used with dimensions.
            /// Required: No
            /// Type: List of MetricToRetain
            /// Update requires: No interruption
            /// </summary>
            public List<MetricToRetain> AdditionalMetricsToRetainV2 { get; set; }

            /// <summary>
            /// Tags
            /// Metadata that can be used to manage the security profile.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TargetArns
            /// The ARN of the target (thing group) to which the security profile is attached.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> TargetArns { get; set; }

        }

        public string Type { get; } = "AWS::IoT::SecurityProfile";

        public SecurityProfileProperties Properties { get; } = new SecurityProfileProperties();

    }

    public static class SecurityProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SecurityProfileArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SecurityProfileArn");
    }
}
