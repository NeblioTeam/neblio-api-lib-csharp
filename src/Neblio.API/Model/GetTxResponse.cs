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
    /// GetTxResponse
    /// </summary>
    [DataContract]
    public partial class GetTxResponse :  IEquatable<GetTxResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTxResponse" /> class.
        /// </summary>
        /// <param name="txid">TXID of transaction.</param>
        /// <param name="version">Transaction version.</param>
        /// <param name="locktime">Transaction locktime.</param>
        /// <param name="vin">Array of transaction inputs.</param>
        /// <param name="vout">Array of transaction outputs.</param>
        /// <param name="blocktime">Block time of this transaction.</param>
        /// <param name="blockheight">Block height of this transaction.</param>
        /// <param name="totalsent">Total NEBL sent in this transaction in satoshis.</param>
        /// <param name="fee">Total NEBL used as fee for this transcation in satoshis.</param>
        /// <param name="blockhash">Hash of the block this transaction is in.</param>
        /// <param name="time">Transaction time.</param>
        /// <param name="confirmations">Number of transaction confirmations.</param>
        /// <param name="valueOut">Total NEBL output in this transaction.</param>
        /// <param name="valueIn">Total NEBL input in this transaction.</param>
        /// <param name="fees">Total NEBL used in fees for this transaction.</param>
        /// <param name="size">Transcation size in bytes.</param>
        public GetTxResponse(string txid = default(string), decimal? version = default(decimal?), decimal? locktime = default(decimal?), List<GetTxResponseVin> vin = default(List<GetTxResponseVin>), List<GetTxResponseVout> vout = default(List<GetTxResponseVout>), decimal? blocktime = default(decimal?), decimal? blockheight = default(decimal?), decimal? totalsent = default(decimal?), decimal? fee = default(decimal?), string blockhash = default(string), decimal? time = default(decimal?), decimal? confirmations = default(decimal?), decimal? valueOut = default(decimal?), decimal? valueIn = default(decimal?), decimal? fees = default(decimal?), decimal? size = default(decimal?))
        {
            this.Txid = txid;
            this.Version = version;
            this.Locktime = locktime;
            this.Vin = vin;
            this.Vout = vout;
            this.Blocktime = blocktime;
            this.Blockheight = blockheight;
            this.Totalsent = totalsent;
            this.Fee = fee;
            this.Blockhash = blockhash;
            this.Time = time;
            this.Confirmations = confirmations;
            this.ValueOut = valueOut;
            this.ValueIn = valueIn;
            this.Fees = fees;
            this.Size = size;
        }
        
        /// <summary>
        /// TXID of transaction
        /// </summary>
        /// <value>TXID of transaction</value>
        [DataMember(Name="txid", EmitDefaultValue=false)]
        public string Txid { get; set; }

        /// <summary>
        /// Transaction version
        /// </summary>
        /// <value>Transaction version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public decimal? Version { get; set; }

        /// <summary>
        /// Transaction locktime
        /// </summary>
        /// <value>Transaction locktime</value>
        [DataMember(Name="locktime", EmitDefaultValue=false)]
        public decimal? Locktime { get; set; }

        /// <summary>
        /// Array of transaction inputs
        /// </summary>
        /// <value>Array of transaction inputs</value>
        [DataMember(Name="vin", EmitDefaultValue=false)]
        public List<GetTxResponseVin> Vin { get; set; }

        /// <summary>
        /// Array of transaction outputs
        /// </summary>
        /// <value>Array of transaction outputs</value>
        [DataMember(Name="vout", EmitDefaultValue=false)]
        public List<GetTxResponseVout> Vout { get; set; }

        /// <summary>
        /// Block time of this transaction
        /// </summary>
        /// <value>Block time of this transaction</value>
        [DataMember(Name="blocktime", EmitDefaultValue=false)]
        public decimal? Blocktime { get; set; }

        /// <summary>
        /// Block height of this transaction
        /// </summary>
        /// <value>Block height of this transaction</value>
        [DataMember(Name="blockheight", EmitDefaultValue=false)]
        public decimal? Blockheight { get; set; }

        /// <summary>
        /// Total NEBL sent in this transaction in satoshis
        /// </summary>
        /// <value>Total NEBL sent in this transaction in satoshis</value>
        [DataMember(Name="totalsent", EmitDefaultValue=false)]
        public decimal? Totalsent { get; set; }

        /// <summary>
        /// Total NEBL used as fee for this transcation in satoshis
        /// </summary>
        /// <value>Total NEBL used as fee for this transcation in satoshis</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public decimal? Fee { get; set; }

        /// <summary>
        /// Hash of the block this transaction is in
        /// </summary>
        /// <value>Hash of the block this transaction is in</value>
        [DataMember(Name="blockhash", EmitDefaultValue=false)]
        public string Blockhash { get; set; }

        /// <summary>
        /// Transaction time
        /// </summary>
        /// <value>Transaction time</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public decimal? Time { get; set; }

        /// <summary>
        /// Number of transaction confirmations
        /// </summary>
        /// <value>Number of transaction confirmations</value>
        [DataMember(Name="confirmations", EmitDefaultValue=false)]
        public decimal? Confirmations { get; set; }

        /// <summary>
        /// Total NEBL output in this transaction
        /// </summary>
        /// <value>Total NEBL output in this transaction</value>
        [DataMember(Name="valueOut", EmitDefaultValue=false)]
        public decimal? ValueOut { get; set; }

        /// <summary>
        /// Total NEBL input in this transaction
        /// </summary>
        /// <value>Total NEBL input in this transaction</value>
        [DataMember(Name="valueIn", EmitDefaultValue=false)]
        public decimal? ValueIn { get; set; }

        /// <summary>
        /// Total NEBL used in fees for this transaction
        /// </summary>
        /// <value>Total NEBL used in fees for this transaction</value>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public decimal? Fees { get; set; }

        /// <summary>
        /// Transcation size in bytes
        /// </summary>
        /// <value>Transcation size in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTxResponse {\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Locktime: ").Append(Locktime).Append("\n");
            sb.Append("  Vin: ").Append(Vin).Append("\n");
            sb.Append("  Vout: ").Append(Vout).Append("\n");
            sb.Append("  Blocktime: ").Append(Blocktime).Append("\n");
            sb.Append("  Blockheight: ").Append(Blockheight).Append("\n");
            sb.Append("  Totalsent: ").Append(Totalsent).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Blockhash: ").Append(Blockhash).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Confirmations: ").Append(Confirmations).Append("\n");
            sb.Append("  ValueOut: ").Append(ValueOut).Append("\n");
            sb.Append("  ValueIn: ").Append(ValueIn).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as GetTxResponse);
        }

        /// <summary>
        /// Returns true if GetTxResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTxResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTxResponse input)
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
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Locktime == input.Locktime ||
                    (this.Locktime != null &&
                    this.Locktime.Equals(input.Locktime))
                ) && 
                (
                    this.Vin == input.Vin ||
                    this.Vin != null &&
                    this.Vin.SequenceEqual(input.Vin)
                ) && 
                (
                    this.Vout == input.Vout ||
                    this.Vout != null &&
                    this.Vout.SequenceEqual(input.Vout)
                ) && 
                (
                    this.Blocktime == input.Blocktime ||
                    (this.Blocktime != null &&
                    this.Blocktime.Equals(input.Blocktime))
                ) && 
                (
                    this.Blockheight == input.Blockheight ||
                    (this.Blockheight != null &&
                    this.Blockheight.Equals(input.Blockheight))
                ) && 
                (
                    this.Totalsent == input.Totalsent ||
                    (this.Totalsent != null &&
                    this.Totalsent.Equals(input.Totalsent))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Blockhash == input.Blockhash ||
                    (this.Blockhash != null &&
                    this.Blockhash.Equals(input.Blockhash))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Confirmations == input.Confirmations ||
                    (this.Confirmations != null &&
                    this.Confirmations.Equals(input.Confirmations))
                ) && 
                (
                    this.ValueOut == input.ValueOut ||
                    (this.ValueOut != null &&
                    this.ValueOut.Equals(input.ValueOut))
                ) && 
                (
                    this.ValueIn == input.ValueIn ||
                    (this.ValueIn != null &&
                    this.ValueIn.Equals(input.ValueIn))
                ) && 
                (
                    this.Fees == input.Fees ||
                    (this.Fees != null &&
                    this.Fees.Equals(input.Fees))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Locktime != null)
                    hashCode = hashCode * 59 + this.Locktime.GetHashCode();
                if (this.Vin != null)
                    hashCode = hashCode * 59 + this.Vin.GetHashCode();
                if (this.Vout != null)
                    hashCode = hashCode * 59 + this.Vout.GetHashCode();
                if (this.Blocktime != null)
                    hashCode = hashCode * 59 + this.Blocktime.GetHashCode();
                if (this.Blockheight != null)
                    hashCode = hashCode * 59 + this.Blockheight.GetHashCode();
                if (this.Totalsent != null)
                    hashCode = hashCode * 59 + this.Totalsent.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.Blockhash != null)
                    hashCode = hashCode * 59 + this.Blockhash.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Confirmations != null)
                    hashCode = hashCode * 59 + this.Confirmations.GetHashCode();
                if (this.ValueOut != null)
                    hashCode = hashCode * 59 + this.ValueOut.GetHashCode();
                if (this.ValueIn != null)
                    hashCode = hashCode * 59 + this.ValueIn.GetHashCode();
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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
