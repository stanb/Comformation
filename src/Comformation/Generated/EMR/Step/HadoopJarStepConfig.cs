using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Step
{
    /// <summary>
    /// Amazon EMR Step HadoopJarStepConfig
    /// HadoopJarStepConfig is a property of the AWS::EMR::Step resource that specifies a JAR file and runtime
    /// settings that Amazon EMR (Amazon EMR) executes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-step-hadoopjarstepconfig.html
    /// </summary>
    public class HadoopJarStepConfig
    {

        /// <summary>
        /// Args
        /// A list of command line arguments passed to the JAR file's main function when the function is
        /// executed.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Args")]
        public Union<List<string>, IntrinsicFunction> Args { get; set; }

        /// <summary>
        /// Jar
        /// A path to the JAR file that Amazon EMR runs for the job flow step.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Jar")]
        public Union<string, IntrinsicFunction> Jar { get; set; }

        /// <summary>
        /// MainClass
        /// The name of the main class in the specified JAR file. If you don't specify a value, you must specify
        /// a main class in the JAR file's manifest file.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("MainClass")]
        public Union<string, IntrinsicFunction> MainClass { get; set; }

        /// <summary>
        /// StepProperties
        /// A list of Java properties that are set when the job flow step runs. You can use these properties to
        /// pass key-value pairs to your main function in the JAR file.
        /// Required: No
        /// Type: List of Amazon EMR Step KeyValue
        /// </summary>
        [JsonProperty("StepProperties")]
        public Union<List<KeyValue>, IntrinsicFunction> StepProperties { get; set; }

    }
}
