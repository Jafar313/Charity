using IJCharityDotNetFramwork.Data.Models;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;

namespace IJCharityDotNetFramwork.Core.ViewModels
{
    public class SaleTitleReports
    {
        string _fullnameMantaghe;
        string _noeKhanevadeAdad;

        public string TarikhAval { get; set; }
        public string TarikhAkhar { get; set; }
        public string FullNameMantaghe
        {
            get
            {
                if (!MantagheCheckState)
                {
                    _fullnameMantaghe = "همه مناطق";
                }
                return _fullnameMantaghe;
            }
            set { _fullnameMantaghe = value; }
        }
        public bool MantagheCheckState { get; set; }
        public NoeKhanevade _enumNoeKhanevade { get; set; }
        public string NoeKhanevade
        {
            get
            {

                switch (_enumNoeKhanevade)
                {
                    case MyEnumTypes.NoeKhanevade.General:
                        {
                            _noeKhanevadeAdad = "عـام";
                        }
                        break;
                    case MyEnumTypes.NoeKhanevade.Sadat:
                        {
                            _noeKhanevadeAdad = "سـادات";
                        }
                        break;
                    case MyEnumTypes.NoeKhanevade.Sunnis:
                        {
                            _noeKhanevadeAdad = "ویـژه";
                        }
                        break;
                    case MyEnumTypes.NoeKhanevade.NotSpecified:
                        {
                            _noeKhanevadeAdad = "بدون تفکیک";
                        }
                        break;

                }

                return _noeKhanevadeAdad;
            }

        }
    }
}
