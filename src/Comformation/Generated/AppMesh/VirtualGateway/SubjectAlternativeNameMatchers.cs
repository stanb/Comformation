using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway SubjectAlternativeNameMatchers
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-subjectalternativenamematchers.html
    /// </summary>
    public class SubjectAlternativeNameMatchers
    {

        /// <summary>
        /// Exact
        /// The values sent must match the specified values exactly.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exact")]
        public List<Union<string, IntrinsicFunction>> Exact { get; set; }

    }
}
