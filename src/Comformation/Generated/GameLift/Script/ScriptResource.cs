using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Script
{
    /// <summary>
    /// AWS::GameLift::Script
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-script.html
    /// </summary>
    public class ScriptResource : ResourceBase
    {
        public class ScriptProperties
        {
            /// <summary>
            /// Version
            /// The version that is associated with a build or script. Version strings do not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// StorageLocation
            /// The location in Amazon S3 where build or script files are stored for access by Amazon GameLift.
            /// Required: Yes
            /// Type: S3Location
            /// Update requires: No interruption
            /// </summary>
            public S3Location StorageLocation { get; set; }

            /// <summary>
            /// Name
            /// A descriptive label that is associated with a script. Script names do not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::Script";

        public ScriptProperties Properties { get; } = new ScriptProperties();

    }

    public static class ScriptAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
