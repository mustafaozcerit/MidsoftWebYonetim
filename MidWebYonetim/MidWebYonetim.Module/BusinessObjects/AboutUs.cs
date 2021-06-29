using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MidWebYonetim.Module.BusinessObjects
{
    [DefaultClassOptions]

    public class AboutUs : BaseObject
    { 
        public AboutUs(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        private string _baslik;
        [Size(500)]
        [Required()] //Boş geçilemez demek
        [ModelDefault("RowCount", "0")] //Düzenleme işlemi
        [Index(1)] //Index sıralaması
        [XafDisplayName("Başlık")] //Gözükmesi istenilen isim
        public string Baslik
        {
            get { return _baslik; }
            set { SetPropertyValue(nameof(Baslik), ref _baslik, value); }
        }
        private string _icerik;
        [Size(500)]
        [Required()] //Boş geçilemez demek
        [ModelDefault("RowCount", "1")] //Düzenleme işlemi
        [Index(1)] //Index sıralaması
        [XafDisplayName("İçerik 1")] //Gözükmesi istenilen isim
        public string Icerik
        {
            get { return _icerik; }
            set { SetPropertyValue(nameof(Icerik), ref _icerik, value); }
        }

        private string _icerik2;
        [Size(500)]
        [ModelDefault("RowCount", "2")] //Düzenleme işlemi
        [Index(1)] //Index sıralaması
        [XafDisplayName("İçerik 2")] //Gözükmesi istenilen isim
        public string Icerik2
        {
            get { return _icerik2; }
            set { SetPropertyValue(nameof(Icerik2), ref _icerik2, value); }
        }
        private string _icerik3;
        [Size(500)]
        [ModelDefault("RowCount", "3")] //Düzenleme işlemi
        [Index(1)] //Index sıralaması
        [XafDisplayName("İçerik 3")] //Gözükmesi istenilen isim
        public string Icerik3
        {
            get { return _icerik3; }
            set { SetPropertyValue(nameof(Icerik3), ref _icerik3, value); }
        }
        private int _index;
        [Size(500)]
        [ModelDefault("RowCount", "4")] //Düzenleme işlemi
        [Index(1)] //Index sıralaması
        [XafDisplayName("Sıralama")] //Gözükmesi istenilen isim
        public int Index
        {
            get { return _index; }
            set { SetPropertyValue(nameof(Index), ref _index, value); }
        }


    }
}