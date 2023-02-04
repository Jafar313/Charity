namespace IJCharityDotNetFramwork.Data.Models
{
    public class MyEnumTypes
    {
        public enum NoeKhanevade
        {
            NotSpecified = 0, General = 2, Sadat = 1, Sunnis = 3
        }
        public enum ExportToMode
        {
            Excel = 0, Pdf = 1
        }
        public enum Gender
        {
            Women = 1, Man = 0
        }
        public enum IdCardType
        {
            Amayesh = 1, Passport = 2, KartMelli = 3, Bimadrak = 4
        }
        public enum EduGrade
        {
            Bisavad = 0, Ebtedaie = 1, Dabirestan = 2, Daneshgah = 3, Hoze = 4
        }
        public enum EduStatus
        {
            DarhaleTahsil = 1, PayaneTahsilat = 2, TarkeTahsil = 3
        }
    }
}
