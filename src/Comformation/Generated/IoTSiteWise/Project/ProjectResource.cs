using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Project
{
    /// <summary>
    /// AWS::IoTSiteWise::Project
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-project.html
    /// </summary>
    public class ProjectResource : ResourceBase
    {
        public class ProjectProperties
        {
            /// <summary>
            /// PortalId
            /// The ID of the portal in which to create the project.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PortalId { get; set; }

            /// <summary>
            /// ProjectName
            /// A friendly name for the project.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectName { get; set; }

            /// <summary>
            /// ProjectDescription
            /// A description for the project.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectDescription { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs that contain metadata for the project. For more information, see Tagging
            /// your AWS IoT SiteWise resources in the AWS IoT SiteWise User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTSiteWise::Project";

        public ProjectProperties Properties { get; } = new ProjectProperties();

    }

    public static class ProjectAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProjectId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProjectId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProjectArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProjectArn");
    }
}
