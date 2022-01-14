namespace Common
{
    public static class Enums
    {
        public enum AVAILABILITY_STATUS
        {
            AVAILABLE,
            UNAVAILABLE,
            DEPRECATED
        }
        public enum CLASS_CODE
        {
            DEFAULT,
            PHYSICAL,
            MENTAL,
            GENOMIC,
            MEDICATION,
            PGHD,
            UNKNOWN
        }
        public enum HEALTHCARE_FACAILITY_TYPE_CODE
        {
            MEDICAL_INSTITUTION,
            PUBLIC_INSTITUTION,
            RESEARCH_INSTITUTION,
            INSURANCE_COMPANY,
            PRIVATE_COMANY,
            PGHD,
            UNKNOWN
        }
        public enum TYPE_CODE
        {
            DATA_SUBJECT,
            DATA_CONSUMER,
            ADMIN,
            UNKNOWN
        }
    }
}
