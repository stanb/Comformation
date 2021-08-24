using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Document
{
    /// <summary>
    /// AWS::SSM::Document DocumentRequires
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-document-documentrequires.html
    /// </summary>
    public class DocumentRequires
    {

        /// <summary>
        /// Name
        /// The name of the required SSM document. The name can be an Amazon Resource Name (ARN).
        /// Required: No
        /// Type: String
        /// Pattern: ^[a-zA-Z0-9_\-. :/]{3,128}$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Version
        /// The document version required by the current document.
        /// Required: No
        /// Type: String
        /// Pattern: ([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
