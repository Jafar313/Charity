using IJCharityDotNetFramwork.Core.Extentions;
using IJCharityDotNetFramwork.Data.Models;
using System;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;

namespace IJCharityDotNetFramwork.Core.ViewModels
{

    public class SaleReportDetailByNoeKhanevadeViewModel
    {

        private string _fullnameKhanevade;
        private string _tozihat;
        private string _noeKhanevadeAdad;
        private string _mantaghe;
        private string _vahed;

        public double? KodTafzili { get; set; }
        public double TedadKhoroji { get; set; }
        public int TarikhKhoroj { get; set; }
        public decimal KodKala { get; set; }
        public string NameKala { get; set; }
        public string TozihatFaktor
        {
            get
            {
                return _tozihat.ReplaceToYeFarsi().ReplaceToKeFarsi();
            }
            set
            {
                _tozihat = value;
            }
        }
        public string FullNameKhanevade
        {
            get
            {
                return _fullnameKhanevade.ReplaceToYeFarsi().ReplaceToKeFarsi() + " - " + TozihatFaktor;
            }
            set
            {
                _fullnameKhanevade = value;
            }
        }
        public double GheimatForosh { get; set; }
        public double Arzesh => TedadKhoroji * GheimatForosh;
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
        public string Vahed
        {
            get
            {
                return _vahed.ReplaceToYeFarsi().ReplaceToKeFarsi();
            }
            set
            {
                _vahed = value;
            }
        }
    }
}
