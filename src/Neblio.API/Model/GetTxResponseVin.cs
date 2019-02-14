/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.1
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
    /// GetTxResponseVin
    /// </summary>
    [DataContract]
    public partial class GetTxResponseVin :  IEquatable<GetTxResponseVin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTxResponseVin" /> class.
        /// </summary>
        /// <param name="sequence">sequence.</param>
        /// <param name="scriptSig">scriptSig.</param>
        /// <param name="valueSat">Value of input in NEBL satoshi.</param>
        /// <param name="txid">TXID of the input.</param>
        /// <param name="value">Value of input in NEBL.</param>
        /// <param name="n">input index.</param>
        /// <param name="vout">output index.</param>
        public GetTxResponseVin(decimal? sequence = default(decimal?), GetTransactionInfoResponseScriptSig scriptSig = default(GetTransactionInfoResponseScriptSig), decimal? valueSat = default(decimal?), string txid = default(string), decimal? value = default(decimal?), decimal? n = default(decimal?), decimal? vout = default(decimal?))
        {
            this.Sequence = sequence;
            this.ScriptSig = scriptSig;
            this.ValueSat = valueSat;
            this.Txid = txid;
            this.Value = value;
            this.N = n;
            this.Vout = vout;
        }
        
        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public decimal? Sequence { get; set; }

        /// <summary>
        /// Gets or Sets ScriptSig
        /// </summary>
        [DataMember(Name="scriptSig", EmitDefaultValue=false)]
        public GetTransactionInfoResponseScriptSig ScriptSig { get; set; }

        /// <summary>
        /// Value of input in NEBL satoshi
        /// </summary>
        /// <value>Value of input in NEBL satoshi</value>
        [DataMember(Name="valueSat", EmitDefaultValue=false)]
        public decimal? ValueSat { get; set; }

        /// <summary>
        /// TXID of the input
        /// </summary>
        /// <value>TXID of the input</value>
        [DataMember(Name="txid", EmitDefaultValue=false)]
        public string Txid { get; set; }

        /// <summary>
        /// Value of input in NEBL
        /// </summary>
        /// <value>Value of input in NEBL</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// input index
        /// </summary>
        /// <value>input index</value>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public decimal? N { get; set; }

        /// <summary>
        /// output index
        /// </summary>
        /// <value>output index</value>
        [DataMember(Name="vout", EmitDefaultValue=false)]
        public decimal? Vout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTxResponseVin {\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  ScriptSig: ").Append(ScriptSig).Append("\n");
            sb.Append("  ValueSat: ").Append(ValueSat).Append("\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Vout: ").Append(Vout).Append("\n");
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
            return this.Equals(input as GetTxResponseVin);
        }

        /// <summary>
        /// Returns true if GetTxResponseVin instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTxResponseVin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTxResponseVin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.ScriptSig == input.ScriptSig ||
                    (this.ScriptSig != null &&
                    this.ScriptSig.Equals(input.ScriptSig))
                ) && 
                (
                    this.ValueSat == input.ValueSat ||
                    (this.ValueSat != null &&
                    this.ValueSat.Equals(input.ValueSat))
                ) && 
                (
                    this.Txid == input.Txid ||
                    (this.Txid != null &&
                    this.Txid.Equals(input.Txid))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.Vout == input.Vout ||
                    (this.Vout != null &&
                    this.Vout.Equals(input.Vout))
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
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.ScriptSig != null)
                    hashCode = hashCode * 59 + this.ScriptSig.GetHashCode();
                if (this.ValueSat != null)
                    hashCode = hashCode * 59 + this.ValueSat.GetHashCode();
                if (this.Txid != null)
                    hashCode = hashCode * 59 + this.Txid.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.Vout != null)
                    hashCode = hashCode * 59 + this.Vout.GetHashCode();
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
