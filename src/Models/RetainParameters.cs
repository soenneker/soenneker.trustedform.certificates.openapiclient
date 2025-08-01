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
    ///     Though both `retain` parameters are optional, we strongly recommend    using them. Doing so will record additional    metadata on your stored certificate which is often of use down the road.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RetainParameters : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Any text that may help you identify the lead associated with the certificate such as a unique leadidentifier or URL pointing to the lead in another system. This value will be displayed in your copy of thecertificate for your future reference</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reference { get; set; }
#nullable restore
#else
        public string Reference { get; set; }
#endif
        /// <summary>When retaining a certificate, you can optionally pass the vendor name. This is intended for tracking the nameof the company that provided the lead associated with the certificate. TrustedForm will record this value on thecertificate stored in your account. Other accounts cannot see this value. When you use TrustedForm reporting,you can easily filter or group by vendor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Vendor { get; set; }
#nullable restore
#else
        public string Vendor { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.RetainParameters"/> and sets the default values.
        /// </summary>
        public RetainParameters()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.RetainParameters"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.RetainParameters CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.RetainParameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "reference", n => { Reference = n.GetStringValue(); } },
                { "vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("reference", Reference);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
