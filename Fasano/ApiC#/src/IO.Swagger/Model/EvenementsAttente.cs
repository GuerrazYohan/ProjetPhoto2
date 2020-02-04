/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.0
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
    /// EvenementsAttente
    /// </summary>
    [DataContract]
        public partial class EvenementsAttente :  IEquatable<EvenementsAttente>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvenementsAttente" /> class.
        /// </summary>
        /// <param name="nom">nom.</param>
        /// <param name="datedebut">datedebut.</param>
        /// <param name="datedefin">datedefin.</param>
        /// <param name="motdepasseevent">motdepasseevent.</param>
        /// <param name="idcompte">idcompte.</param>
        public EvenementsAttente(string nom = default(string), DateTime? datedebut = default(DateTime?), DateTime? datedefin = default(DateTime?), string motdepasseevent = default(string), int? idcompte = default(int?))
        {
            this.Nom = nom;
            this.Datedebut = datedebut;
            this.Datedefin = datedefin;
            this.Motdepasseevent = motdepasseevent;
            this.Idcompte = idcompte;
        }
        
        /// <summary>
        /// Gets or Sets IdevenementsAttente
        /// </summary>
        [DataMember(Name="idevenementsAttente", EmitDefaultValue=false)]
        public int? IdevenementsAttente { get; private set; }

        /// <summary>
        /// Gets or Sets Nom
        /// </summary>
        [DataMember(Name="nom", EmitDefaultValue=false)]
        public string Nom { get; set; }

        /// <summary>
        /// Gets or Sets Datedebut
        /// </summary>
        [DataMember(Name="datedebut", EmitDefaultValue=false)]
        public DateTime? Datedebut { get; set; }

        /// <summary>
        /// Gets or Sets Datedefin
        /// </summary>
        [DataMember(Name="datedefin", EmitDefaultValue=false)]
        public DateTime? Datedefin { get; set; }

        /// <summary>
        /// Gets or Sets Motdepasseevent
        /// </summary>
        [DataMember(Name="motdepasseevent", EmitDefaultValue=false)]
        public string Motdepasseevent { get; set; }

        /// <summary>
        /// Gets or Sets Idcompte
        /// </summary>
        [DataMember(Name="idcompte", EmitDefaultValue=false)]
        public int? Idcompte { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvenementsAttente {\n");
            sb.Append("  IdevenementsAttente: ").Append(IdevenementsAttente).Append("\n");
            sb.Append("  Nom: ").Append(Nom).Append("\n");
            sb.Append("  Datedebut: ").Append(Datedebut).Append("\n");
            sb.Append("  Datedefin: ").Append(Datedefin).Append("\n");
            sb.Append("  Motdepasseevent: ").Append(Motdepasseevent).Append("\n");
            sb.Append("  Idcompte: ").Append(Idcompte).Append("\n");
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
            return this.Equals(input as EvenementsAttente);
        }

        /// <summary>
        /// Returns true if EvenementsAttente instances are equal
        /// </summary>
        /// <param name="input">Instance of EvenementsAttente to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvenementsAttente input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdevenementsAttente == input.IdevenementsAttente ||
                    (this.IdevenementsAttente != null &&
                    this.IdevenementsAttente.Equals(input.IdevenementsAttente))
                ) && 
                (
                    this.Nom == input.Nom ||
                    (this.Nom != null &&
                    this.Nom.Equals(input.Nom))
                ) && 
                (
                    this.Datedebut == input.Datedebut ||
                    (this.Datedebut != null &&
                    this.Datedebut.Equals(input.Datedebut))
                ) && 
                (
                    this.Datedefin == input.Datedefin ||
                    (this.Datedefin != null &&
                    this.Datedefin.Equals(input.Datedefin))
                ) && 
                (
                    this.Motdepasseevent == input.Motdepasseevent ||
                    (this.Motdepasseevent != null &&
                    this.Motdepasseevent.Equals(input.Motdepasseevent))
                ) && 
                (
                    this.Idcompte == input.Idcompte ||
                    (this.Idcompte != null &&
                    this.Idcompte.Equals(input.Idcompte))
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
                if (this.IdevenementsAttente != null)
                    hashCode = hashCode * 59 + this.IdevenementsAttente.GetHashCode();
                if (this.Nom != null)
                    hashCode = hashCode * 59 + this.Nom.GetHashCode();
                if (this.Datedebut != null)
                    hashCode = hashCode * 59 + this.Datedebut.GetHashCode();
                if (this.Datedefin != null)
                    hashCode = hashCode * 59 + this.Datedefin.GetHashCode();
                if (this.Motdepasseevent != null)
                    hashCode = hashCode * 59 + this.Motdepasseevent.GetHashCode();
                if (this.Idcompte != null)
                    hashCode = hashCode * 59 + this.Idcompte.GetHashCode();
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
