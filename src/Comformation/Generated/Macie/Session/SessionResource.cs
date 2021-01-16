using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Macie.Session
{
    /// <summary>
    /// AWS::Macie::Session
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-session.html
    /// </summary>
    public class SessionResource : ResourceBase
    {
        public class SessionProperties
        {
            /// <summary>
            /// Status
            /// The MacieStatus of the Session. Valid values include ENABLED and PAUSED.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// FindingPublishingFrequency
            /// The frequency with which Amazon Macie publishes updates to policy findings for an account. This
            /// includes publishing updates to AWS Security Hub and Amazon EventBridge (formerly called Amazon
            /// CloudWatch Events). Valid values are:
            /// FIFTEEN_MINUTES ONE_HOUR SIX_HOURS
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FindingPublishingFrequency { get; set; }

        }

        public string Type { get; } = "AWS::Macie::Session";

        public SessionProperties Properties { get; } = new SessionProperties();

    }

    public static class SessionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AwsAccountId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AwsAccountId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServiceRole = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServiceRole");
    }
}
