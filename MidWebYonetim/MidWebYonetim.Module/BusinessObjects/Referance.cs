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

    public class Referance : BaseObject
    { 
        public Referance(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string _isim;
        [Size(500)]
        [XafDisplayName("İçerik")] //Gözükmesi istenilen isim
        public string Isim
        {
            get { return _isim; }
            set { SetPropertyValue(nameof(Isim), ref _isim, value); }
        }

        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit,
        DetailViewImageEditorMode = ImageEditorMode.PictureEdit, ListViewImageEditorCustomHeight = 30), DevExpress.Xpo.DisplayName("Fotoğraf"), ToolTip("Önerilen Ölçeklendirme : 250x250")]
        public byte[] fotograf
        {
            get { return GetPropertyValue<byte[]>(nameof(fotograf)); }
            set { SetPropertyValue<byte[]>(nameof(fotograf), value); }
        }

        private int _index;
        [XafDisplayName("Sıralama")] //Gözükmesi istenilen isim
        public int Index
        {
            get { return _index; }
            set { SetPropertyValue(nameof(Index), ref _index, value); }
        }
    }
}