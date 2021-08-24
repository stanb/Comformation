using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway SubjectAlternativeNames
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-subjectalternativenames.html
    /// </summary>
    public class SubjectAlternativeNames
    {

        /// <summary>
        /// Match
        /// An object that represents the criteria for determining a SANs match.
        /// Required: Yes
        /// Type: SubjectAlternativeNameMatchers
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public SubjectAlternativeNameMatchers Match { get; set; }

    }
}
