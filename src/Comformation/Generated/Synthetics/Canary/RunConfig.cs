using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Synthetics.Canary
{
    /// <summary>
    /// AWS::Synthetics::Canary RunConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-runconfig.html
    /// </summary>
    public class RunConfig
    {

        /// <summary>
        /// TimeoutInSeconds
        /// How long the canary is allowed to run before it must stop. You can&#39;t set this time to be longer than
        /// the frequency of the runs of this canary.
        /// If you omit this field, the frequency of the canary is used as this value, up to a maximum of 900
        /// seconds.
        /// Required: No
        /// Type: Integer
        /// Minimum: 3
        /// Maximum: 840
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutInSeconds")]
        public Union<int, IntrinsicFunction> TimeoutInSeconds { get; set; }

        /// <summary>
        /// MemoryInMB
        /// The maximum amount of memory that the canary can use while running. This value must be a multiple of
        /// 64. The range is 960 to 3008.
        /// Required: No
        /// Type: Integer
        /// Minimum: 960
        /// Maximum: 3008
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MemoryInMB")]
        public Union<int, IntrinsicFunction> MemoryInMB { get; set; }

        /// <summary>
        /// ActiveTracing
        /// Specifies whether this canary is to use active AWS X-Ray tracing when it runs. Active tracing
        /// enables this canary run to be displayed in the ServiceLens and X-Ray service maps even if the canary
        /// does not hit an endpoint that has X-Ray tracing enabled. Using X-Ray tracing incurs charges. For
        /// more information, see Canaries and X-Ray tracing.
        /// You can enable active tracing only for canaries that use version syn-nodejs-2. 0 or later for their
        /// canary runtime.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActiveTracing")]
        public Union<bool, IntrinsicFunction> ActiveTracing { get; set; }

        /// <summary>
        /// EnvironmentVariables
        /// Specifies the keys and values to use for any environment variables used in the canary script. Use
        /// the following format:
        /// { &quot;key1&quot; : &quot;value1&quot;, &quot;key2&quot; : &quot;value2&quot;, . . . }
        /// Keys must start with a letter and be at least two characters. The total size of your environment
        /// variables cannot exceed 4 KB. You can&#39;t specify any Lambda reserved environment variables as the
        /// keys for your environment variables. For more information about reserved keys, see Runtime
        /// environment variables.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnvironmentVariables")]
        public Dictionary<string, Union<string, IntrinsicFunction>> EnvironmentVariables { get; set; }

    }
}
