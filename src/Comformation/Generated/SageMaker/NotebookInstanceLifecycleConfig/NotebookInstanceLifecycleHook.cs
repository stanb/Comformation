using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.NotebookInstanceLifecycleConfig
{
    /// <summary>
    /// Amazon SageMaker NotebookInstanceLifecycleConfig NotebookInstanceLifecycleHook
    /// The NotebookInstanceLifecycleHook property type specifies the notebook instance lifecycle configuration
    /// script.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-notebookinstancelifecycleconfig-notebookinstancelifecyclehook.html
    /// </summary>
    public class NotebookInstanceLifecycleHook
    {

        /// <summary>
        /// Content
        /// A base64-encoded string that contains a shell script for a notebook instance lifecycle
        /// configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Content")]
        public Union<string, IntrinsicFunction> Content { get; set; }

    }
}
