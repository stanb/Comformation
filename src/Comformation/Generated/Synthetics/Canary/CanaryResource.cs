using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Synthetics.Canary
{
    /// <summary>
    /// AWS::Synthetics::Canary
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html
    /// </summary>
    public class CanaryResource : ResourceBase
    {
        public class CanaryProperties
        {
            /// <summary>
            /// Name
            /// The name for this canary. Be sure to give it a descriptive name that distinguishes it from other
            /// canaries in your account.
            /// Do not include secrets or proprietary information in your canary names. The canary name makes up
            /// part of the canary ARN, and the ARN is included in outbound calls over the internet. For more
            /// information, see Security Considerations for Synthetics Canaries.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 21
            /// Pattern: ^[0-9a-z_\-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Code
            /// Use this structure to input your script code for the canary. This structure contains the Lambda
            /// handler with the location where the canary should start running the script. If the script is stored
            /// in an S3 bucket, the bucket name, key, and version are also included. If the script is passed into
            /// the canary directly, the script code is contained in the value of Script.
            /// Required: Yes
            /// Type: Code
            /// Update requires: No interruption
            /// </summary>
            public Code Code { get; set; }

            /// <summary>
            /// ArtifactS3Location
            /// The location in Amazon S3 where Synthetics stores artifacts from the runs of this canary. Artifacts
            /// include the log file, screenshots, and HAR files. Specify the full location path, including s3:// at
            /// the beginning of the path.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ArtifactS3Location { get; set; }

            /// <summary>
            /// Schedule
            /// A structure that contains information about how often the canary is to run, and when these runs are
            /// to stop.
            /// Required: Yes
            /// Type: Schedule
            /// Update requires: No interruption
            /// </summary>
            public Schedule Schedule { get; set; }

            /// <summary>
            /// ExecutionRoleArn
            /// The ARN of the IAM role to be used to run the canary. This role must already exist, and must include
            /// lambda. amazonaws. com as a principal in the trust policy. The role must also have the following
            /// permissions:
            /// s3:PutObject s3:GetBucketLocation s3:ListAllMyBuckets cloudwatch:PutMetricData logs:CreateLogGroup
            /// logs:CreateLogStream logs:PutLogEvents
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: arn:(aws[a-zA-Z-]*)?:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// RuntimeVersion
            /// Specifies the runtime version to use for the canary. For more information about runtime versions,
            /// see Canary Runtime Versions.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuntimeVersion { get; set; }

            /// <summary>
            /// SuccessRetentionPeriod
            /// The number of days to retain data about successful runs of this canary. If you omit this field, the
            /// default of 31 days is used. The valid range is 1 to 455 days.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> SuccessRetentionPeriod { get; set; }

            /// <summary>
            /// FailureRetentionPeriod
            /// The number of days to retain data about failed runs of this canary. If you omit this field, the
            /// default of 31 days is used. The valid range is 1 to 455 days.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> FailureRetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// The list of key-value pairs that are associated with the canary.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VPCConfig
            /// If this canary is to test an endpoint in a VPC, this structure contains information about the subnet
            /// and security groups of the VPC endpoint. For more information, see Running a Canary in a VPC.
            /// Required: No
            /// Type: VPCConfig
            /// Update requires: No interruption
            /// </summary>
            public VPCConfig VPCConfig { get; set; }

            /// <summary>
            /// RunConfig
            /// A structure that contains input information for a canary run. If you omit this structure, the
            /// frequency of the canary is used as canary&#39;s timeout value, up to a maximum of 900 seconds.
            /// Required: No
            /// Type: RunConfig
            /// Update requires: No interruption
            /// </summary>
            public RunConfig RunConfig { get; set; }

            /// <summary>
            /// StartCanaryAfterCreation
            /// Specify TRUE to have the canary start making runs immediately after it is created.
            /// A canary that you create using CloudFormation can&#39;t be used to monitor the CloudFormation stack that
            /// creates the canary or to roll back that stack if there is a failure.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> StartCanaryAfterCreation { get; set; }

        }

        public string Type { get; } = "AWS::Synthetics::Canary";

        public CanaryProperties Properties { get; } = new CanaryProperties();

    }

    public static class CanaryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
    }
}
