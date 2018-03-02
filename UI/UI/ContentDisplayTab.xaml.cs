using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for ContentDisplayTab.xaml
    /// </summary>
    public partial class ContentDisplayTab : UserControl
    {
        public ContentDisplayTab()
        {
            InitializeComponent();
        }

        public Handler thisHandler;

        public ContentDisplayTab(string categorie)
        {
            InitializeComponent();

            switch (categorie)
            {
                case "Profesori":
                    thisHandler = new Profesori();
                    break;
                case "Studenti":
                    thisHandler = new Studenti();
                    break;
                case "Catalog":
                    thisHandler = new Catalog();
                    break;
                case "Grupe":
                    thisHandler = new Grupe();
                    break;
                case "Materii":
                    thisHandler = new Materii();
                    break;
                case "Specializari":
                    thisHandler = new Specializari();
                    break;
            }
        }
    }

    public abstract class Handler
    {
        public virtual string TableName
        {
            get { return ""; }
        }

        public virtual int Id
        {
            get
            {
                return 0;
            }
        }
        public virtual void Sterge() { string.Format("DELETE FROM {0} WHERE ID = {1}", TableName, Id); }
        public abstract void Adaugare();
        public abstract void Modifica();
        // de detaliat functiile pentru adaugare si modificare in handlerele de mai jos
        // de modificat tabele sa aiba toate ID ca primary key (identificator)
        // de modificat interfata pentru acest user control (text boxes, labels, buttons)
    }

    public class Profesori: Handler
    {
        public override string TableName { get { return "Profesori"; } }
        public override void Modifica()
        {
            //de facut modificarea specifica pentru profesori
        }
        public override void Adaugare()
        {
            //de facut modificarea specifica pentru profesori
        }
    }

    public class Studenti : Handler
    {
        public override string TableName => "Studenti";
        public override void Modifica()
        {
            //de facut modificarea specifica pentru elevi
        }
        public override void Adaugare()
        {
            //de facut modificarea specifica pentru profesori
        }
    }

    public class Catalog : Handler
    {
        public override string TableName => "Catalog";
        public override void Modifica()
        {
            //de facut modificarea specifica pentru catalog
        }
        public override void Adaugare()
        {
            //de facut modificarea specifica pentru catalog
        }
    }

    public class Grupe : Handler
    {
        public override string TableName => "Grupe";
        public override void Modifica()
        {
            //de facut modificarea specifica pentru catalog
        }
        public override void Adaugare()
        {
            //de facut modificarea specifica pentru catalog
        }
    }

    public class Materii : Handler
    {
        public override string TableName => "Materii";
        public override void Modifica()
        {
            //de facut modificarea specifica pentru catalog
        }
        public override void Adaugare()
        {
            //de facut modificarea specifica pentru catalog
        }
    }

    public class Specializari : Handler
    {
        public override string TableName => "Specializari";
        public override void Modifica()
        {
            //de facut modificarea specifica pentru catalog
        }
        public override void Adaugare()
        {
            //de facut modificarea specifica pentru catalog
        }
    }
}
