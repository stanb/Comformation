using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.ReportGroup
{
    /// <summary>
    /// AWS::CodeBuild::ReportGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html
    /// </summary>
    public class ReportGroupResource : ResourceBase
    {
        public class ReportGroupProperties
        {
            /// <summary>
            /// Type
            /// The type of the ReportGroup. This can be one of the following values:
            /// CODE_COVERAGE The report group contains code coverage reports. TEST The report group contains test
            /// reports.
            /// Required: Yes
            /// Type: String
            /// Allowed values: CODE_COVERAGE | TEST
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// ExportConfig
            /// Information about the destination where the raw data of this ReportGroup is exported.
            /// Required: Yes
            /// Type: ReportExportConfig
            /// Update requires: No interruption
            /// </summary>
            public ReportExportConfig ExportConfig { get; set; }

            /// <summary>
            /// DeleteReports
            /// When deleting a report group, specifies if reports within the report group should be deleted.
            /// true Deletes any reports that belong to the report group before deleting the report group. false You
            /// must delete any reports in the report group. This is the default value. If you delete a report group
            /// that contains one or more reports, an exception is thrown.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeleteReports { get; set; }

            /// <summary>
            /// Tags
            /// A list of tag key and value pairs associated with this report group.
            /// These tags are available for use by AWS services that support AWS CodeBuild report group tags.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the ReportGroup.
            /// Required: No
            /// Type: String
            /// Minimum: 2
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::CodeBuild::ReportGroup";

        public ReportGroupProperties Properties { get; } = new ReportGroupProperties();

    }

    public static class ReportGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
