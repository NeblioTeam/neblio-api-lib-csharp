/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// GetTransactionInfoResponseVin
    /// </summary>
    [DataContract]
    public partial class GetTransactionInfoResponseVin :  IEquatable<GetTransactionInfoResponseVin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionInfoResponseVin" /> class.
        /// </summary>
        /// <param name="Txid">TXID of the input.</param>
        /// <param name="Vout">output index.</param>
        /// <param name="ScriptSig">ScriptSig.</param>
        /// <param name="Sequence">Sequence.</param>
        /// <param name="PreviousOutput">PreviousOutput.</param>
        /// <param name="Tokens">Tokens.</param>
        /// <param name="Value">Value of input in NEBL satoshi.</param>
        public GetTransactionInfoResponseVin(string Txid = default(string), decimal? Vout = default(decimal?), GetTransactionInfoResponseScriptSig ScriptSig = default(GetTransactionInfoResponseScriptSig), decimal? Sequence = default(decimal?), GetTransactionInfoResponsePreviousOutput PreviousOutput = default(GetTransactionInfoResponsePreviousOutput), List<GetTransactionInfoResponseTokens> Tokens = default(List<GetTransactionInfoResponseTokens>), decimal? Value = default(decimal?))
        {
            this.Txid = Txid;
            this.Vout = Vout;
            this.ScriptSig = ScriptSig;
            this.Sequence = Sequence;
            this.PreviousOutput = PreviousOutput;
            this.Tokens = Tokens;
            this.Value = Value;
        }
        
        /// <summary>
        /// TXID of the input
        /// </summary>
        /// <value>TXID of the input</value>
        [DataMember(Name="txid", EmitDefaultValue=false)]
        public string Txid { get; set; }

        /// <summary>
        /// output index
        /// </summary>
        /// <value>output index</value>
        [DataMember(Name="vout", EmitDefaultValue=false)]
        public decimal? Vout { get; set; }

        /// <summary>
        /// Gets or Sets ScriptSig
        /// </summary>
        [DataMember(Name="scriptSig", EmitDefaultValue=false)]
        public GetTransactionInfoResponseScriptSig ScriptSig { get; set; }

        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public decimal? Sequence { get; set; }

        /// <summary>
        /// Gets or Sets PreviousOutput
        /// </summary>
        [DataMember(Name="previousOutput", EmitDefaultValue=false)]
        public GetTransactionInfoResponsePreviousOutput PreviousOutput { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name="tokens", EmitDefaultValue=false)]
        public List<GetTransactionInfoResponseTokens> Tokens { get; set; }

        /// <summary>
        /// Value of input in NEBL satoshi
        /// </summary>
        /// <value>Value of input in NEBL satoshi</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransactionInfoResponseVin {\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Vout: ").Append(Vout).Append("\n");
            sb.Append("  ScriptSig: ").Append(ScriptSig).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  PreviousOutput: ").Append(PreviousOutput).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as GetTransactionInfoResponseVin);
        }

        /// <summary>
        /// Returns true if GetTransactionInfoResponseVin instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionInfoResponseVin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionInfoResponseVin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Txid == input.Txid ||
                    (this.Txid != null &&
                    this.Txid.Equals(input.Txid))
                ) && 
                (
                    this.Vout == input.Vout ||
                    (this.Vout != null &&
                    this.Vout.Equals(input.Vout))
                ) && 
                (
                    this.ScriptSig == input.ScriptSig ||
                    (this.ScriptSig != null &&
                    this.ScriptSig.Equals(input.ScriptSig))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.PreviousOutput == input.PreviousOutput ||
                    (this.PreviousOutput != null &&
                    this.PreviousOutput.Equals(input.PreviousOutput))
                ) && 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Txid != null)
                    hashCode = hashCode * 59 + this.Txid.GetHashCode();
                if (this.Vout != null)
                    hashCode = hashCode * 59 + this.Vout.GetHashCode();
                if (this.ScriptSig != null)
                    hashCode = hashCode * 59 + this.ScriptSig.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.PreviousOutput != null)
                    hashCode = hashCode * 59 + this.PreviousOutput.GetHashCode();
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
