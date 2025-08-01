// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.TrustedForm.Certificates.OpenApiClient.Models
{
    /// <summary>
    /// The data points requested, if available.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WebInsightsResult_properties : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of seconds since the last user interaction with the certificate.</summary>
        public int? AgeSeconds { get; set; }
        /// <summary>An object containing properties that provide information about the consumer’s location at the time the certificate was created based on their IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_approx_ip_geo? ApproxIpGeo { get; set; }
#nullable restore
#else
        public global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_approx_ip_geo ApproxIpGeo { get; set; }
#endif
        /// <summary>A determination of whether the events documented were likely produced by a non-human entity based on ActiveProspect’s proprietary algorithms. This data point is currently undergoing alpha testing. It may contain flaws and may be discontinued.</summary>
        public bool? BotDetected { get; set; }
        /// <summary>An object containing properties that provide information about the consumer’s browser.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_browser? Browser { get; set; }
#nullable restore
#else
        public global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_browser Browser { get; set; }
#endif
        /// <summary>The UTC ISO8601 formatted date and time when TrustedForm Certify was loaded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The domain displayed to the consumer during the page visit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; set; }
#nullable restore
#else
        public string Domain { get; set; }
#endif
        /// <summary>The UTC ISO8601 formatted date and time when the certificate will expire.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpiresAt { get; set; }
#nullable restore
#else
        public string ExpiresAt { get; set; }
#endif
        /// <summary>The average number of keystrokes per minute based on the consumer&apos;s rate of form input.</summary>
        public double? FormInputKpm { get; set; }
        /// <summary>The detected input method(s) the consumer used to fill out the form.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_form_input_method?>? FormInputMethod { get; set; }
#nullable restore
#else
        public List<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_form_input_method?> FormInputMethod { get; set; }
#endif
        /// <summary>The approximate number of words per minute calculated by using the form_input_kpm and assuming five characters represent a word.</summary>
        public double? FormInputWpm { get; set; }
        /// <summary>The consumer&apos;s public IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ip { get; set; }
#nullable restore
#else
        public string Ip { get; set; }
#endif
        /// <summary>A boolean indicating that the form was displayed within an iframe.</summary>
        public bool? IsFramed { get; set; }
        /// <summary>A boolean indicating if the certificate is masked and does not show source information nor a session replay.</summary>
        public bool? IsMasked { get; set; }
        /// <summary>Count of how many content elements (e.g. img, div) are marked sensitive and hidden from the session replay.</summary>
        public double? NumSensitiveContentElements { get; set; }
        /// <summary>Count of how many form elements (e.g. input, textarea) are marked sensitive and hidden from the session replay.</summary>
        public double? NumSensitiveFormElements { get; set; }
        /// <summary>An object containing properties that provide information about the consumer&apos;s operating system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_os? Os { get; set; }
#nullable restore
#else
        public global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_os Os { get; set; }
#endif
        /// <summary>The URL of the page hosting TrustedForm Certify.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PageUrl { get; set; }
#nullable restore
#else
        public string PageUrl { get; set; }
#endif
        /// <summary>The parent URL of the page hosting TrustedForm Certify, if framed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentPageUrl { get; set; }
#nullable restore
#else
        public string ParentPageUrl { get; set; }
#endif
        /// <summary>The time in seconds between when TrustedForm Certify was loaded and when the most recent cert event was received.</summary>
        public double? SecondsOnPage { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties"/> and sets the default values.
        /// </summary>
        public WebInsightsResult_properties()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "age_seconds", n => { AgeSeconds = n.GetIntValue(); } },
                { "approx_ip_geo", n => { ApproxIpGeo = n.GetObjectValue<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_approx_ip_geo>(global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_approx_ip_geo.CreateFromDiscriminatorValue); } },
                { "bot_detected", n => { BotDetected = n.GetBoolValue(); } },
                { "browser", n => { Browser = n.GetObjectValue<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_browser>(global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_browser.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "domain", n => { Domain = n.GetStringValue(); } },
                { "expires_at", n => { ExpiresAt = n.GetStringValue(); } },
                { "form_input_kpm", n => { FormInputKpm = n.GetDoubleValue(); } },
                { "form_input_method", n => { FormInputMethod = n.GetCollectionOfEnumValues<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_form_input_method>()?.AsList(); } },
                { "form_input_wpm", n => { FormInputWpm = n.GetDoubleValue(); } },
                { "ip", n => { Ip = n.GetStringValue(); } },
                { "is_framed", n => { IsFramed = n.GetBoolValue(); } },
                { "is_masked", n => { IsMasked = n.GetBoolValue(); } },
                { "num_sensitive_content_elements", n => { NumSensitiveContentElements = n.GetDoubleValue(); } },
                { "num_sensitive_form_elements", n => { NumSensitiveFormElements = n.GetDoubleValue(); } },
                { "os", n => { Os = n.GetObjectValue<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_os>(global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_os.CreateFromDiscriminatorValue); } },
                { "page_url", n => { PageUrl = n.GetStringValue(); } },
                { "parent_page_url", n => { ParentPageUrl = n.GetStringValue(); } },
                { "seconds_on_page", n => { SecondsOnPage = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("age_seconds", AgeSeconds);
            writer.WriteObjectValue<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_approx_ip_geo>("approx_ip_geo", ApproxIpGeo);
            writer.WriteBoolValue("bot_detected", BotDetected);
            writer.WriteObjectValue<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_browser>("browser", Browser);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("expires_at", ExpiresAt);
            writer.WriteDoubleValue("form_input_kpm", FormInputKpm);
            writer.WriteCollectionOfEnumValues<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_form_input_method>("form_input_method", FormInputMethod);
            writer.WriteDoubleValue("form_input_wpm", FormInputWpm);
            writer.WriteStringValue("ip", Ip);
            writer.WriteBoolValue("is_framed", IsFramed);
            writer.WriteBoolValue("is_masked", IsMasked);
            writer.WriteDoubleValue("num_sensitive_content_elements", NumSensitiveContentElements);
            writer.WriteDoubleValue("num_sensitive_form_elements", NumSensitiveFormElements);
            writer.WriteObjectValue<global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.WebInsightsResult_properties_os>("os", Os);
            writer.WriteStringValue("page_url", PageUrl);
            writer.WriteStringValue("parent_page_url", ParentPageUrl);
            writer.WriteDoubleValue("seconds_on_page", SecondsOnPage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
