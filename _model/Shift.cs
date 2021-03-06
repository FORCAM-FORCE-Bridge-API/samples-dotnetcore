using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Shift
    {
        /// <summary>
        /// Gets or Sets AssociatedDay
        /// </summary>
        [DataMember(Name = "associatedDay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "associatedDay")]
        public DateTime? AssociatedDay { get; set; }

        /// <summary>
        /// Shift time period
        /// </summary>
        /// <value>Shift time period</value>
        [DataMember(Name = "timePeriod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePeriod")]
        public TimePeriodDefinition TimePeriod { get; set; }

        /// <summary>
        /// Gets or Sets Breaks
        /// </summary>
        [DataMember(Name = "breaks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breaks")]
        public List<ShiftBreak> Breaks { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shift {\n");
            sb.Append("  AssociatedDay: ").Append(AssociatedDay).Append("\n");
            sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
            sb.Append("  Breaks: ").Append(Breaks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
