using Common;
using Hl7.Fhir.Model;
using System;
using System.Text;
using System.Security.Cryptography;
using static Common.Enums;

namespace ADL_MetaGenerator
{
    public class Utility
    {
        public static Author GetAuthor(string institutionName, string institutionIdentifier, string authorName, string authorIdentifier)
        {
            Author author = new Author();
            author.institution = GetInstitution(institutionName, institutionIdentifier);
            author.person = GetPerson(authorName, authorIdentifier);
            return author;
        }
        private static Institution GetInstitution(string institutionName, string institutionIdentifier)
        {
            Institution institution = new Institution();
            institution.identifier = ADL_FHIRGenerator.Utility.IdentifierManager.GetGuid(institutionIdentifier);
            institution.name = institutionName;
            return institution;
        }
        private static Common.Person GetPerson(string authorName, string authorIdentifier)
        {
            Common.Person person = new Common.Person();
            if (0 >= authorIdentifier.Length)
                authorIdentifier = authorName;
            person.identifier = ADL_FHIRGenerator.Utility.IdentifierManager.GetGuid(authorIdentifier);
            person.name = authorName;
            person.type = TYPE_CODE.DATA_CONSUMER;
            return person;
        }
        public static string GetConfidentialityCode(string identifier)
        {
            //@Todo
            string confidentialityCode = TEST_GetConfidentialityCode();
            return EncodeToBase64(confidentialityCode);
        }
        private static string EncodeToBase64(string str)
        {
            byte[] bytes = StringToBytes(str);
            return Convert.ToBase64String(bytes);
        }
        private static byte[] StringToBytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }
        private static string TEST_GetConfidentialityCode()
        {
            Target target = new Target();
            target.no = false;
            target.all = false;
            target.family = true;
            target.medicalInstitution = true;
            target.publicInstitution = false;
            target.researchInstitution = true;
            target.insuranceCompany = false;
            target.privateCompany = false;
            return target.ToString();
        }
        public static string GetHash(string data)
        {
            SHA256Managed sha256Managed = new SHA256Managed();
            byte[] bytes = StringToBytes(data);
            byte[] encryptedBytes = sha256Managed.ComputeHash(bytes);
            return Convert.ToBase64String(encryptedBytes);
        }
        public static int GetSize(string data)
        {
            byte[] bytes = StringToBytes(data);
            return bytes.Length;
        }
        public static Common.TypeCode GetTypeCode(CodeableConcept code)
        {
            Common.TypeCode typeCode = new Common.TypeCode();
            typeCode.code = code.Coding[0].Code;
            typeCode.system = code.Coding[0].System;
            return typeCode;
        }
        public static string GetMetdataId(string patientId, string authorIdentifier, string creationTime)
        {
            StringBuilder stringBuilder = new StringBuilder();

            return String.Format("{0}|{1}|{2}", patientId, authorIdentifier, creationTime);
        }
        public static string GetDateTime(DateTime dateTime)
        {
            // return new FhirDateTime(new DateTimeOffset(dateTime)).ToString();
            return new FhirDateTime(dateTime).ToString();
        }
    }
}