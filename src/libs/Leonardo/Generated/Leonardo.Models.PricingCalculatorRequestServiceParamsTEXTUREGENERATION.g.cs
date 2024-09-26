
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for TEXTURE_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsTEXTUREGENERATION
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}