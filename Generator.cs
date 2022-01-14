using System;
using System.Collections.Generic;
using Common;
using Hl7.Fhir.Model;
using ADL_FHIRGenerator;
using static Common.Enums;

namespace ADL_MetaGenerator
{
    public class Generator
    {
        public static readonly string institutionName = "Kyungpook National University Center of Self-Organizaing Software";
        public static readonly string institutionIdentifier = "KNU CSOS";
        public static readonly string authorName = "CSOS Tester";
        public static readonly string title = "KNU CSOS Activities of Daily Living(ADL) 1st Test Result";
        public static readonly string formatCode = "FHIR";
        public static readonly string languageCode = "ko";
        public static readonly string schemaId = "https://fhir.simplifier.net/KNU.MyHealthHub/StructureDefinition/MyObservation";
        public static List<Metadata> GetMetadataList()
        {
            List<Metadata> metadataList = new();
            List<Observation> observationList = ADL.GetAdlObservationList();
            for(int i = 0; i < observationList.Count; i++)
            {
                Observation observation = observationList[i];
                string observationJson = ADL.ToString(observation);
                Metadata metadata = new Metadata();
                metadata.author = Utility.GetAuthor(institutionIdentifier, institutionName, authorName, "");
                metadata.availabilityStatus = AVAILABILITY_STATUS.AVAILABLE;
                metadata.classCode = CLASS_CODE.PHYSICAL;
                metadata.confidentialityCode = Utility.GetConfidentialityCode(observation.Subject.Identifier.Value);
                metadata.creationTime = Utility.GetDateTime(DateTime.Now);
                metadata.formatCode = formatCode;
                metadata.healthcareFacilityType = HEALTHCARE_FACAILITY_TYPE_CODE.RESEARCH_INSTITUTION;
                metadata.hash = Utility.GetHash(observationJson);
                metadata.languageCode = languageCode;
                metadata.patientId = observation.Subject.Identifier.Value;
                metadata.size = Utility.GetSize(observationJson);
                metadata.title = title;
                metadata.schemaId = schemaId;
                metadata.typeCode = Utility.GetTypeCode(observation.Code);
                metadata.metadataId = Utility.GetMetdataId(metadata.patientId, metadata.author.person.identifier, metadata.creationTime.ToString());
                metadataList.Add(metadata);
            }
            return metadataList;
        }
        
    }
}