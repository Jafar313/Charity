using IJCharityDotNetFramwork.Data.Models;
using System;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;

namespace IJCharityDotNetFramwork.Core.ViewModels
{
    public class ListGhayebinViewModel
    {
        private string _noeKhanevadeAdad;
        private string _mantaghe;

        public int? ShomareParvande { get; set; }
        public NoeKhanevade _enumNoeKhanevade { get; set; }
        public string NoeKhanevade
        {
            get
            {
                switch (_enumNoeKhanevade)
                {
                    case MyEnumTypes.NoeKhanevade.Sadat:
                        _noeKhanevadeAdad = "سـادات";
                        break;
                    case MyEnumTypes.NoeKhanevade.General:
                        _noeKhanevadeAdad = "عـام";
                        break;
                    case MyEnumTypes.NoeKhanevade.Sunnis:
                        _noeKhanevadeAdad = "ویـژه";
                        break;
                    case MyEnumTypes.NoeKhanevade.NotSpecified:
                        _noeKhanevadeAdad = "بدون تفکیک";
                        break;
                }
                return _noeKhanevadeAdad;
            }
        }
        public string Mantaghe
        {
            get
            {
                if (String.IsNullOrEmpty(_mantaghe))
                {
                    return "همه مناطق";
                }
                return _mantaghe;
            }
            set { _mantaghe = value; }
        }
        public string FullNameKhanevade { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
