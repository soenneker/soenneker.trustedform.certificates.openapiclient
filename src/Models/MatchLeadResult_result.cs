// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.TrustedForm.Certificates.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MatchLeadResult_result : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>    A `boolean` indicating if the specified `email` was found on the    certificate. A `null` value indicates that no emails were    provided.</summary>
        public bool? EmailMatch { get; set; }
        /// <summary>    A `boolean` indicating if the specified `phone` was found on the    certificate. A `null` value indicates that a phone number was    not provided.</summary>
        public bool? PhoneMatch { get; set; }
        /// <summary>    A `boolean` indicating if any matches were found during the lead    matching operation. A `null` value indicates that lead matching    was not performed.</summary>
        public bool? Success { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.MatchLeadResult_result"/> and sets the default values.
        /// </summary>
        public MatchLeadResult_result()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.MatchLeadResult_result"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.MatchLeadResult_result CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.TrustedForm.Certificates.OpenApiClient.Models.MatchLeadResult_result();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "email_match", n => { EmailMatch = n.GetBoolValue(); } },
                { "phone_match", n => { PhoneMatch = n.GetBoolValue(); } },
                { "success", n => { Success = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("email_match", EmailMatch);
            writer.WriteBoolValue("phone_match", PhoneMatch);
            writer.WriteBoolValue("success", Success);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
