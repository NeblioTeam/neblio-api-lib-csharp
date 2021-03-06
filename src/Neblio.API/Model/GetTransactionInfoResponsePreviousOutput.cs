/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.3.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Neblio.API.Client.OpenAPIDateConverter;

namespace Neblio.API.Model
{
    /// <summary>
    /// GetTransactionInfoResponsePreviousOutput
    /// </summary>
    [DataContract]
    public partial class GetTransactionInfoResponsePreviousOutput :  IEquatable<GetTransactionInfoResponsePreviousOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionInfoResponsePreviousOutput" /> class.
        /// </summary>
        /// <param name="asm">asm.</param>
        /// <param name="hex">hex.</param>
        /// <param name="reqSigs">reqSigs.</param>
        /// <param name="type">type.</param>
        /// <param name="addresses">addresses.</param>
        public GetTransactionInfoResponsePreviousOutput(string asm = default(string), string hex = default(string), decimal? reqSigs = default(decimal?), string type = default(string), List<string> addresses = default(List<string>))
        {
            this.Asm = asm;
            this.Hex = hex;
            this.ReqSigs = reqSigs;
            this.Type = type;
            this.Addresses = addresses;
        }
        
        /// <summary>
        /// Gets or Sets Asm
        /// </summary>
        [DataMember(Name="asm", EmitDefaultValue=false)]
        public string Asm { get; set; }

        /// <summary>
        /// Gets or Sets Hex
        /// </summary>
        [DataMember(Name="hex", EmitDefaultValue=false)]
        public string Hex { get; set; }

        /// <summary>
        /// Gets or Sets ReqSigs
        /// </summary>
        [DataMember(Name="reqSigs", EmitDefaultValue=false)]
        public decimal? ReqSigs { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransactionInfoResponsePreviousOutput {\n");
            sb.Append("  Asm: ").Append(Asm).Append("\n");
            sb.Append("  Hex: ").Append(Hex).Append("\n");
            sb.Append("  ReqSigs: ").Append(ReqSigs).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetTransactionInfoResponsePreviousOutput);
        }

        /// <summary>
        /// Returns true if GetTransactionInfoResponsePreviousOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionInfoResponsePreviousOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionInfoResponsePreviousOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Asm == input.Asm ||
                    (this.Asm != null &&
                    this.Asm.Equals(input.Asm))
                ) && 
                (
                    this.Hex == input.Hex ||
                    (this.Hex != null &&
                    this.Hex.Equals(input.Hex))
                ) && 
                (
                    this.ReqSigs == input.ReqSigs ||
                    (this.ReqSigs != null &&
                    this.ReqSigs.Equals(input.ReqSigs))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Asm != null)
                    hashCode = hashCode * 59 + this.Asm.GetHashCode();
                if (this.Hex != null)
                    hashCode = hashCode * 59 + this.Hex.GetHashCode();
                if (this.ReqSigs != null)
                    hashCode = hashCode * 59 + this.ReqSigs.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
