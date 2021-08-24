using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinitionVersion Execution
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-execution.html
    /// </summary>
    public class Execution
    {

        /// <summary>
        /// IsolationMode
        /// The containerization that the Lambda function runs in. Valid values are GreengrassContainer or
        /// NoContainer. Typically, this is GreengrassContainer. 	For more information, 	see Containerization in
        /// the AWS IoT Greengrass Version 1 Developer Guide.
        /// When set on the DefaultConfig property of a function definition version, this setting is used as the
        /// default containerization for all Lambda functions in the function definition version. When set on
        /// the Environment property of a function, this setting applies to the individual function and
        /// overrides the default. Omit this value to run the function with the default containerization.
        /// 				
        /// Note We recommend that you run in a Greengrass container unless your business case requires that you
        /// run without containerization.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IsolationMode")]
        public Union<string, IntrinsicFunction> IsolationMode { get; set; }

        /// <summary>
        /// RunAs
        /// The user and group permissions used to run the Lambda function. Typically, this is the ggc_user and
        /// ggc_group. 	For more information, 	see Run as in the AWS IoT Greengrass Version 1 Developer Guide.
        /// When set on the DefaultConfig property of a function definition version, this setting is used as the
        /// default access identity for all Lambda functions in the function definition version. When set on the
        /// Environment property of a function, this setting applies to the individual function and overrides
        /// the default. You can override the user, group, or both. Omit this value to run the function with the
        /// default permissions.
        /// Important Running as the root user increases risks to your data and device. Do not run as root
        /// (UID/GID=0) unless your business case requires it. For more information and requirements, see
        /// Running a Lambda Function as Root.
        /// 		
        /// Required: No
        /// Type: RunAs
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RunAs")]
        public RunAs RunAs { get; set; }

    }
}
