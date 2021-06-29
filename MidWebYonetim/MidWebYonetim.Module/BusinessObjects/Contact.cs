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
    public class Contact : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Contact(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string _konum;
        [Size(500)]
        [XafDisplayName("Konum")] //Gözükmesi istenilen isim
        public string Konum
        {
            get { return _konum; }
            set { SetPropertyValue(nameof(Konum), ref _konum, value); }
        }
        private string _mail;
        [Size(500)]
        [XafDisplayName("E-Mail")] //Gözükmesi istenilen isim
        public string Mail
        {
            get { return _mail; }
            set { SetPropertyValue(nameof(Mail), ref _mail, value); }
        }
        private string _phone;
        [Size(500)]
        [XafDisplayName("Telefon Numarası")] //Gözükmesi istenilen isim
        public string Phone
        {
            get { return _phone; }
            set { SetPropertyValue(nameof(Phone), ref _phone, value); }
        }

    }
}