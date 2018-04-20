/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.1.1
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
    /// SendTokenResponse
    /// </summary>
    [DataContract]
    public partial class SendTokenResponse :  IEquatable<SendTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTokenResponse" /> class.
        /// </summary>
        /// <param name="TxHex">Unsigned, raw transaction hex of the transaction to send the token.</param>
        /// <param name="Ntp1OutputIndexes">Array of indexes transfering NTP1 tokens.</param>
        /// <param name="MultisigOutputs">Array of indexes of multisig outputs.</param>
        public SendTokenResponse(string TxHex = default(string), List<decimal?> Ntp1OutputIndexes = default(List<decimal?>), List<decimal?> MultisigOutputs = default(List<decimal?>))
        {
            this.TxHex = TxHex;
            this.Ntp1OutputIndexes = Ntp1OutputIndexes;
            this.MultisigOutputs = MultisigOutputs;
        }
        
        /// <summary>
        /// Unsigned, raw transaction hex of the transaction to send the token
        /// </summary>
        /// <value>Unsigned, raw transaction hex of the transaction to send the token</value>
        [DataMember(Name="txHex", EmitDefaultValue=false)]
        public string TxHex { get; set; }

        /// <summary>
        /// Array of indexes transfering NTP1 tokens
        /// </summary>
        /// <value>Array of indexes transfering NTP1 tokens</value>
        [DataMember(Name="ntp1OutputIndexes", EmitDefaultValue=false)]
        public List<decimal?> Ntp1OutputIndexes { get; set; }

        /// <summary>
        /// Array of indexes of multisig outputs
        /// </summary>
        /// <value>Array of indexes of multisig outputs</value>
        [DataMember(Name="multisigOutputs", EmitDefaultValue=false)]
        public List<decimal?> MultisigOutputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendTokenResponse {\n");
            sb.Append("  TxHex: ").Append(TxHex).Append("\n");
            sb.Append("  Ntp1OutputIndexes: ").Append(Ntp1OutputIndexes).Append("\n");
            sb.Append("  MultisigOutputs: ").Append(MultisigOutputs).Append("\n");
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
            return this.Equals(input as SendTokenResponse);
        }

        /// <summary>
        /// Returns true if SendTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SendTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendTokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TxHex == input.TxHex ||
                    (this.TxHex != null &&
                    this.TxHex.Equals(input.TxHex))
                ) && 
                (
                    this.Ntp1OutputIndexes == input.Ntp1OutputIndexes ||
                    this.Ntp1OutputIndexes != null &&
                    this.Ntp1OutputIndexes.SequenceEqual(input.Ntp1OutputIndexes)
                ) && 
                (
                    this.MultisigOutputs == input.MultisigOutputs ||
                    this.MultisigOutputs != null &&
                    this.MultisigOutputs.SequenceEqual(input.MultisigOutputs)
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
                if (this.TxHex != null)
                    hashCode = hashCode * 59 + this.TxHex.GetHashCode();
                if (this.Ntp1OutputIndexes != null)
                    hashCode = hashCode * 59 + this.Ntp1OutputIndexes.GetHashCode();
                if (this.MultisigOutputs != null)
                    hashCode = hashCode * 59 + this.MultisigOutputs.GetHashCode();
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
