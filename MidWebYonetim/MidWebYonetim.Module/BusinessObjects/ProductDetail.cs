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
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class ProductDetail : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public ProductDetail(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        private Products _products;
        [Association("Product-ProductDetails")]
        public Products Products
        {
            get { return _products; }
            set { SetPropertyValue(nameof(Products), ref _products, value); }
        }

        private string _productsName;
        public string ProductsName
        {
            get { return _productsName; }
            set { SetPropertyValue(nameof(ProductsName), ref _productsName, value); }
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
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit,
        DetailViewImageEditorMode = ImageEditorMode.PictureEdit, ListViewImageEditorCustomHeight = 30), DevExpress.Xpo.DisplayName("Fotoğraf"), ToolTip("Önerilen Ölçeklendirme : 250x250")]
        public byte[] fotograf
        {
            get { return GetPropertyValue<byte[]>(nameof(fotograf)); }
            set { SetPropertyValue<byte[]>(nameof(fotograf), value); }
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
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit,
        DetailViewImageEditorMode = ImageEditorMode.PictureEdit, ListViewImageEditorCustomHeight = 30), DevExpress.Xpo.DisplayName("Fotoğraf"), ToolTip("Önerilen Ölçeklendirme : 250x250")]
        public byte[] fotograf1
        {
            get { return GetPropertyValue<byte[]>(nameof(fotograf1)); }
            set { SetPropertyValue<byte[]>(nameof(fotograf1), value); }
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
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit,
        DetailViewImageEditorMode = ImageEditorMode.PictureEdit, ListViewImageEditorCustomHeight = 30), DevExpress.Xpo.DisplayName("Fotoğraf"), ToolTip("Önerilen Ölçeklendirme : 250x250")]
        public byte[] fotograf2
        {
            get { return GetPropertyValue<byte[]>(nameof(fotograf2)); }
            set { SetPropertyValue<byte[]>(nameof(fotograf2), value); }
        }
    }
}