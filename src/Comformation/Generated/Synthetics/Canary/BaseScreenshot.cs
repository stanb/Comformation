using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Synthetics.Canary
{
    /// <summary>
    /// AWS::Synthetics::Canary BaseScreenshot
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-basescreenshot.html
    /// </summary>
    public class BaseScreenshot
    {

        /// <summary>
        /// ScreenshotName
        /// The name of the screenshot. This is generated the first time the canary is run after the
        /// UpdateCanary operation that specified for this canary to perform visual monitoring.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScreenshotName")]
        public Union<string, IntrinsicFunction> ScreenshotName { get; set; }

        /// <summary>
        /// IgnoreCoordinates
        /// Coordinates that define the part of a screen to ignore during screenshot comparisons. To obtain the
        /// coordinates to use here, use the CloudWatch Logs console to draw the boundaries on the screen. For
        /// more information, see {LINK}
        /// Required: No
        /// Type: List of String
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IgnoreCoordinates")]
        public List<Union<string, IntrinsicFunction>> IgnoreCoordinates { get; set; }

    }
}
