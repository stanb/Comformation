using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTFleetHub.Application
{
    /// <summary>
    /// AWS::IoTFleetHub::Application
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotfleethub-application.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of the web application.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[ -~]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// ApplicationDescription
            /// An optional description of the web application.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: ^[ -~]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationDescription { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of the role that the web application assumes when it interacts with AWS IoT Core.
            /// Note The name of the role must be in the form FleetHub_random_string.
            /// Pattern: ^arn:[!-~]+$
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// A set of key/value pairs that you can use to manage the web application resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTFleetHub::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }

    public static class ApplicationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApplicationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApplicationId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApplicationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApplicationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApplicationUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApplicationUrl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApplicationState = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApplicationState");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> ApplicationCreationDate = new ResourceAttribute<Union<int, IntrinsicFunction>>("ApplicationCreationDate");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> ApplicationLastUpdateDate = new ResourceAttribute<Union<int, IntrinsicFunction>>("ApplicationLastUpdateDate");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SsoClientId = new ResourceAttribute<Union<string, IntrinsicFunction>>("SsoClientId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ErrorMessage = new ResourceAttribute<Union<string, IntrinsicFunction>>("ErrorMessage");
    }
}
