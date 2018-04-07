/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.0.0
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
    /// GetAddressInfoResponseUtxos
    /// </summary>
    [DataContract]
    public partial class GetAddressInfoResponseUtxos :  IEquatable<GetAddressInfoResponseUtxos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressInfoResponseUtxos" /> class.
        /// </summary>
        /// <param name="Index">Index of the UTXO at this address.</param>
        /// <param name="Txid">Txid of this UTXO.</param>
        /// <param name="Blockheight">Blockheight of the UTXO.</param>
        /// <param name="Blocktime">Blocktime of the UTXO.</param>
        /// <param name="ScriptPubKey">Object representing the scruptPubKey of the UTXO.</param>
        /// <param name="Used">Whether the UTXO has been used.</param>
        /// <param name="Value">Value of the UTXO in NEBL satoshi.</param>
        /// <param name="Tokens">Array of NTP1 tokens in this UTXO..</param>
        public GetAddressInfoResponseUtxos(decimal? Index = default(decimal?), string Txid = default(string), decimal? Blockheight = default(decimal?), decimal? Blocktime = default(decimal?), Object ScriptPubKey = default(Object), bool? Used = default(bool?), decimal? Value = default(decimal?), List<GetAddressInfoResponseTokens> Tokens = default(List<GetAddressInfoResponseTokens>))
        {
            this.Index = Index;
            this.Txid = Txid;
            this.Blockheight = Blockheight;
            this.Blocktime = Blocktime;
            this.ScriptPubKey = ScriptPubKey;
            this.Used = Used;
            this.Value = Value;
            this.Tokens = Tokens;
        }
        
        /// <summary>
        /// Index of the UTXO at this address
        /// </summary>
        /// <value>Index of the UTXO at this address</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public decimal? Index { get; set; }

        /// <summary>
        /// Txid of this UTXO
        /// </summary>
        /// <value>Txid of this UTXO</value>
        [DataMember(Name="txid", EmitDefaultValue=false)]
        public string Txid { get; set; }

        /// <summary>
        /// Blockheight of the UTXO
        /// </summary>
        /// <value>Blockheight of the UTXO</value>
        [DataMember(Name="blockheight", EmitDefaultValue=false)]
        public decimal? Blockheight { get; set; }

        /// <summary>
        /// Blocktime of the UTXO
        /// </summary>
        /// <value>Blocktime of the UTXO</value>
        [DataMember(Name="blocktime", EmitDefaultValue=false)]
        public decimal? Blocktime { get; set; }

        /// <summary>
        /// Object representing the scruptPubKey of the UTXO
        /// </summary>
        /// <value>Object representing the scruptPubKey of the UTXO</value>
        [DataMember(Name="scriptPubKey", EmitDefaultValue=false)]
        public Object ScriptPubKey { get; set; }

        /// <summary>
        /// Whether the UTXO has been used
        /// </summary>
        /// <value>Whether the UTXO has been used</value>
        [DataMember(Name="used", EmitDefaultValue=false)]
        public bool? Used { get; set; }

        /// <summary>
        /// Value of the UTXO in NEBL satoshi
        /// </summary>
        /// <value>Value of the UTXO in NEBL satoshi</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Array of NTP1 tokens in this UTXO.
        /// </summary>
        /// <value>Array of NTP1 tokens in this UTXO.</value>
        [DataMember(Name="tokens", EmitDefaultValue=false)]
        public List<GetAddressInfoResponseTokens> Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAddressInfoResponseUtxos {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Blockheight: ").Append(Blockheight).Append("\n");
            sb.Append("  Blocktime: ").Append(Blocktime).Append("\n");
            sb.Append("  ScriptPubKey: ").Append(ScriptPubKey).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(input as GetAddressInfoResponseUtxos);
        }

        /// <summary>
        /// Returns true if GetAddressInfoResponseUtxos instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAddressInfoResponseUtxos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAddressInfoResponseUtxos input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Txid == input.Txid ||
                    (this.Txid != null &&
                    this.Txid.Equals(input.Txid))
                ) && 
                (
                    this.Blockheight == input.Blockheight ||
                    (this.Blockheight != null &&
                    this.Blockheight.Equals(input.Blockheight))
                ) && 
                (
                    this.Blocktime == input.Blocktime ||
                    (this.Blocktime != null &&
                    this.Blocktime.Equals(input.Blocktime))
                ) && 
                (
                    this.ScriptPubKey == input.ScriptPubKey ||
                    (this.ScriptPubKey != null &&
                    this.ScriptPubKey.Equals(input.ScriptPubKey))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Txid != null)
                    hashCode = hashCode * 59 + this.Txid.GetHashCode();
                if (this.Blockheight != null)
                    hashCode = hashCode * 59 + this.Blockheight.GetHashCode();
                if (this.Blocktime != null)
                    hashCode = hashCode * 59 + this.Blocktime.GetHashCode();
                if (this.ScriptPubKey != null)
                    hashCode = hashCode * 59 + this.ScriptPubKey.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
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
