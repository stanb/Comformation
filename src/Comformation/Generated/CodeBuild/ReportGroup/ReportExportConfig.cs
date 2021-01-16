using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.ReportGroup
{
    /// <summary>
    /// AWS::CodeBuild::ReportGroup ReportExportConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-reportexportconfig.html
    /// </summary>
    public class ReportExportConfig
    {

        /// <summary>
        /// S3Destination
        /// A S3ReportExportConfig object that contains information about the S3 bucket where the run of a
        /// report is exported.
        /// Required: No
        /// Type: S3ReportExportConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Destination")]
        public S3ReportExportConfig S3Destination { get; set; }

        /// <summary>
        /// ExportConfigType
        /// The export configuration type. Valid values are:
        /// S3: The report results are exported to an S3 bucket. NO_EXPORT: The report results are not exported.
        /// Required: Yes
        /// Type: String
        /// Allowed values: NO_EXPORT | S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExportConfigType")]
        public Union<string, IntrinsicFunction> ExportConfigType { get; set; }

    }
}
