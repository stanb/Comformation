using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConformancePack
{
    /// <summary>
    /// AWS::Config::ConformancePack
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html
    /// </summary>
    public class ConformancePackResource : ResourceBase
    {
        public class ConformancePackProperties
        {
            /// <summary>
            /// ConformancePackName
            /// Name of the conformance pack you want to create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConformancePackName { get; set; }

            /// <summary>
            /// DeliveryS3Bucket
            /// AWS Config stores intermediate files while processing conformance pack template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeliveryS3Bucket { get; set; }

            /// <summary>
            /// DeliveryS3KeyPrefix
            /// The prefix for the Amazon S3 bucket.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeliveryS3KeyPrefix { get; set; }

            /// <summary>
            /// TemplateBody
            /// A string containing full conformance pack template body. Structure containing the template body with
            /// a minimum length of 1 byte and a maximum length of 51,200 bytes.
            /// Note You can only use a YAML template with one resource type, that is, config rule and a remediation
            /// action.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateBody { get; set; }

            /// <summary>
            /// TemplateS3Uri
            /// Location of file containing the template body (s3://bucketname/prefix). The uri must point to the
            /// conformance pack template (max size: 300 KB) that is located in an Amazon S3 bucket.
            /// Note You must have access to read Amazon S3 bucket.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateS3Uri { get; set; }

            /// <summary>
            /// ConformancePackInputParameters
            /// A list of ConformancePackInputParameter objects.
            /// Required: No
            /// Type: List of ConformancePackInputParameter
            /// Update requires: No interruption
            /// </summary>
            public List<ConformancePackInputParameter> ConformancePackInputParameters { get; set; }

        }

        public string Type { get; } = "AWS::Config::ConformancePack";

        public ConformancePackProperties Properties { get; } = new ConformancePackProperties();

    }
}
