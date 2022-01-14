using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static Common.Enums;

namespace Common
{
    public class Metadata
    {
        public string metadataId { get; set; }
        public Author author { get; set; }
        public AVAILABILITY_STATUS availabilityStatus { get; set; }
        public CLASS_CODE classCode { get; set; }
        public string confidentialityCode { get; set; }
        public string creationTime { get; set; }
        public string formatCode { get; set; }
        public HEALTHCARE_FACAILITY_TYPE_CODE healthcareFacilityType { get; set; }
        public string hash { get; set; }
        public string languageCode { get; set; }
        public string patientId { get; set; }
        public int size { get; set; }
        public string title { get; set; }
        public string schemaId { get; set; }
        public string repositoryUniqueId { get; set; }
        public string uri { get; set; }
        public TypeCode typeCode { get; set; }
        public string comments { get; set; }
        public List<string> referenceIdList { get; set; }
        public string lastUpdated { get; set; }

        public Metadata() { }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
