using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AccessPolicy
{
    /// <summary>
    /// AWS::IoTSiteWise::AccessPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html
    /// </summary>
    public class AccessPolicyResource : ResourceBase
    {
        public class AccessPolicyProperties
        {
            /// <summary>
            /// AccessPolicyIdentity
            /// The identity for this access policy. Choose an AWS SSO user, an AWS SSO group, or an IAM user.
            /// Required: Yes
            /// Type: AccessPolicyIdentity
            /// Update requires: No interruption
            /// </summary>
            public AccessPolicyIdentity AccessPolicyIdentity { get; set; }

            /// <summary>
            /// AccessPolicyPermission
            /// The permission level for this access policy. Choose either a ADMINISTRATOR or VIEWER. Note that a
            /// project ADMINISTRATOR is also known as a project owner.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AccessPolicyPermission { get; set; }

            /// <summary>
            /// AccessPolicyResource
            /// The AWS IoT SiteWise Monitor resource for this access policy. Choose either a portal or a project.
            /// Required: Yes
            /// Type: AccessPolicyResource
            /// Update requires: No interruption
            /// </summary>
            public AccessPolicyResource AccessPolicyResource { get; set; }

        }

        public string Type { get; } = "AWS::IoTSiteWise::AccessPolicy";

        public AccessPolicyProperties Properties { get; } = new AccessPolicyProperties();

    }

    public static class AccessPolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AccessPolicyId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AccessPolicyId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AccessPolicyArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AccessPolicyArn");
    }
}
