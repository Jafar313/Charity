using IJCharityDotNetFramwork.Core.Extentions;
using IJCharityDotNetFramwork.Data.Models;
using System;


namespace IJCharityDotNetFramwork.Core.ViewModels
{
    public class SaleReportKolByNoeKhanevadeViewModel
    {
        private string _noeKhanevadeAdad;
        private string _vahed;
        private string _nameKala;
        private string _mantaghe;
        private string _fullnameMantaghe;


        public string TarikhAval { get; set; }

        public string TarikhAkhar { get; set; }

        public double TedadKhoroji { get; set; }

        public decimal KodKala { get; set; }

        public string NameKala
        {
            get
            {
                return _nameKala.ReplaceToYeFarsi().ReplaceToKeFarsi();
            }
            set
            {
                _nameKala = value;
            }
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

        public double GheimatForosh { get; set; }

        public double Arzesh => TedadKhoroji * GheimatForosh;

        public string NoeKhanevade
        {
            get
            {
                switch (_noeKhanevade)
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

        public string ShomareMantaghe
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
        public MyEnumTypes.NoeKhanevade _noeKhanevade { get; set; }
    }
}
