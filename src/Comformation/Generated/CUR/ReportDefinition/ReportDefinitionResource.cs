using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CUR.ReportDefinition
{
    /// <summary>
    /// AWS::CUR::ReportDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cur-reportdefinition.html
    /// </summary>
    public class ReportDefinitionResource : ResourceBase
    {
        public class ReportDefinitionProperties
        {
            /// <summary>
            /// ReportName
            /// The name of the report that you want to create. The name must be unique, is case sensitive, and
            /// can&#39;t include spaces.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ReportName { get; set; }

            /// <summary>
            /// TimeUnit
            /// The granularity of the line items in the report.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TimeUnit { get; set; }

            /// <summary>
            /// Format
            /// The format that Amazon Web Services saves the report in.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Format { get; set; }

            /// <summary>
            /// Compression
            /// The compression format that Amazon Web Services uses for the report.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Compression { get; set; }

            /// <summary>
            /// AdditionalSchemaElements
            /// A list of strings that indicate additional content that Amazon Web Services includes in the report,
            /// such as individual resource IDs.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AdditionalSchemaElements { get; set; }

            /// <summary>
            /// S3Bucket
            /// The S3 bucket where Amazon Web Services delivers the report.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3Bucket { get; set; }

            /// <summary>
            /// S3Prefix
            /// The prefix that Amazon Web Services adds to the report name when Amazon Web Services delivers the
            /// report. Your prefix can&#39;t include spaces.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3Prefix { get; set; }

            /// <summary>
            /// S3Region
            /// The Region of the S3 bucket that Amazon Web Services delivers the report into.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3Region { get; set; }

            /// <summary>
            /// AdditionalArtifacts
            /// A list of manifests that you want Amazon Web Services to create for this report.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AdditionalArtifacts { get; set; }

            /// <summary>
            /// RefreshClosedReports
            /// Whether you want Amazon Web Services to update your reports after they have been finalized if Amazon
            /// Web Services detects charges related to previous months. These charges can include refunds, credits,
            /// or support fees.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> RefreshClosedReports { get; set; }

            /// <summary>
            /// ReportVersioning
            /// Whether you want Amazon Web Services to overwrite the previous version of each report or to deliver
            /// the report in addition to the previous versions.
            /// Required: Yes
            /// Type: String
            /// Allowed values: CREATE_NEW_REPORT | OVERWRITE_REPORT
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ReportVersioning { get; set; }

            /// <summary>
            /// BillingViewArn
            /// The Amazon Resource Name (ARN) of the billing view. You can get this value by using the billing view
            /// service public APIs.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BillingViewArn { get; set; }

        }

        public string Type { get; } = "AWS::CUR::ReportDefinition";

        public ReportDefinitionProperties Properties { get; } = new ReportDefinitionProperties();

    }
}
