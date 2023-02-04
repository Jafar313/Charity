namespace IJCharityDotNetFramwork.Core.ViewModels
{
    public class ListManateghViewModel
    {
        public string ShomareMantaghe { get; set; }
        public decimal? ShomareMantagheDecimal { get; set; }
        public string NameModirMantaghe { get; set; }
        public string FullNameMantaghe
        {
            get
            {
                return ShomareMantaghe + " - " + NameModirMantaghe;
            }
        }
    }
}
