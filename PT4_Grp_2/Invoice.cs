using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public class Invoice
    {
        Client client;
        Staff staff;
        string date;
        class Sale
        {
            Product product;
            int quantity;
            decimal price;

            public Sale()
            {

            }
            public Product Product { get => product; set => product = value; }
            public int Quantity { get => quantity; set => quantity = value; }
            public decimal Price { get => price; set => price = value; }
        }
        List<Sale> sales;
        int id;


        /**
         * Basic constructor
         */
        public Invoice()
        {
            Sales = new List<Sale>();
        }

        /**
        * Constructor of an invoice which create it in the database without other attribute than id and sales.
        * 
        * @Param id the id of the staff
        * @db the database
        * * @param b paramater to recognize this constructor
        */
        public Invoice(int id, DB db, bool b)
        {
            db.openConnection();
            Sales = new List<Sale>();

            Id = id;

            String[] arg = { id.ToString() };
            OleDbDataReader readerSales = db.select("select * from vente where code_facture = ?", arg);
            db.openConnection();
            while (readerSales.Read())
            {
                this.AddSale(new Product(readerSales.GetInt32(1), db), readerSales.GetInt32(2), readerSales.GetDecimal(3));
            }
            db.closeConnection();

        }
        /**
         * Constructor of an invoice which create it in the database
         * 
         * @Param id the id of the staff
         * @db the database
         */
        public Invoice(int id, DB db)
        {
            db.openConnection();
            Sales = new List<Sale>();
            String[] arg = { id.ToString() };
            OleDbDataReader reader = db.select("select * from facture where code_facture = ?", arg);
            Id = id;
            if (reader.Read())
            {
                Staff = new Staff(reader.GetInt32(1), db);
                try
                {
                    Client = new Client(reader.GetInt32(2), db);
                }
                catch
                {
                    Client = null;
                }
                db.openConnection();
                OleDbDataReader readerSales = db.select("select * from vente where code_facture = ?", arg);
               
                while (readerSales.Read())
                {
                    this.AddSale(new Product(readerSales.GetInt32(1), db), readerSales.GetInt32(2), readerSales.GetDecimal(3));
                }
              
                Date = reader.GetString(3);
                db.closeConnection();
            }

            
            db.closeConnection();
        }

        /**
         * Function that add a sale in the current instance (not in the database !)
         * 
         * @Param p the product sell
         * @Param q the quantity 
         * @Param pri the price per unity
         */
        public void AddSale(Product p, int q, decimal pri)
        {
            Sale s = new Sale();
            s.Product = p;
            s.Quantity = q;
            s.Price = pri;
            Sales.Add(s);
        }
        /**
         * Function that adds the current instance in the database.
         * 
         * @Param db the database
         */
        public void Flush(DB db)
        {
            db.openConnection();
            string cmd;
            string[] args; 
            if (this.Client != null)
            {
                cmd = "insert into facture (code_personnel, code_personne, date_facture) values (?,?,?)";
                args = new string[]{ Staff.IdStaff.ToString(), Client.Id.ToString(), Date };
            }
            else
            {
                cmd = "insert into facture (code_personnel, date_facture) values (?,?)";
                args = new string[] { Staff.IdStaff.ToString(), Date };
            }

            int idInv = db.insert(cmd, args);

            string[] args2;
            foreach (Sale s in Sales)
            {
                args2 = new string[] { idInv.ToString(), s.Product.Id.ToString(), s.Quantity.ToString(), s.Price.ToString(CultureInfo.InvariantCulture) };
                db.nonSelect("insert into vente (code_facture, code_produit, quantite, prix_unitaire) values (?,?,?,?)", args2);
            }
            db.closeConnection();
        }

        /**
         * Function that generate a pdf based on the current instance.
         */
        public void generatePdf(DB db)
        {
            string outputFile = "facture.pdf";
            Document document = new Document();
            Stream output = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None);
            PdfWriter.GetInstance(document, output);
            document.Open();
            document.Add(new Paragraph("Facture du " + DateTime.Now.ToString("dd/MM/yyyy") + " à " + DateTime.Now.ToString("HH:mm"), FontFactory.GetFont(FontFactory.COURIER, 20)));
            Paragraph p = new Paragraph("--------------------------------");
            p.Alignment = Element.ALIGN_CENTER;
            document.Add(p);
            document.Add(new Paragraph("\n\n      Vendeu.r.se : Mr/Mme " + Staff.Lastname.ToUpper() + " " + Staff.Firstname  + "\n", FontFactory.GetFont(FontFactory.COURIER, 12)));
            if (Client != null)
            {
                document.Add(new Paragraph("      Client.e : Mr/Mme " + Client.Lastname.ToUpper() + " " + Client.Firstname, FontFactory.GetFont(FontFactory.COURIER, 12))) ;
            }
            document.Add(p);
            decimal total = 0;
            foreach (Sale s in Sales)
            {
                Product prod = s.Product;
                decimal priceMultiplied = prod.Price * s.Quantity;
                document.Add(new Paragraph(prod.Name + "      x" + s.Quantity + "                   (" + s.Price + "€/u)", FontFactory.GetFont(FontFactory.COURIER, 10)));
                Paragraph price = new Paragraph(priceMultiplied.ToString() + "€", FontFactory.GetFont(FontFactory.COURIER_OBLIQUE, 10));
                price.Alignment = Element.ALIGN_RIGHT;
                document.Add(price);
                prod.UpdateQuantity(db, s.Quantity);
                total += priceMultiplied;
            
            }
            document.Add(p);
            Paragraph tva = new Paragraph("TVA : 20%", FontFactory.GetFont(FontFactory.COURIER, 12));
            Paragraph t = new Paragraph("Prix total :", FontFactory.GetFont(FontFactory.COURIER, 12));
            
            Paragraph tprice = new Paragraph(total.ToString() + " euros TTC", FontFactory.GetFont(FontFactory.COURIER, 12));
            tva.Alignment = Element.ALIGN_RIGHT;
            t.Alignment = Element.ALIGN_RIGHT;
            tprice.Alignment = Element.ALIGN_RIGHT;
            document.Add(tva);
            document.Add(t);
            document.Add(tprice);
            document.Close();

           
        }

        public override string ToString()
        {
            String s = this.Date;
            if (Client == null)
            {
                return s + " | Aucun client renseigné";
            }
            return s + " | " + this.Client.Lastname + " | " + this.Client.Firstname;
        }
        /**
         * Delete the current instance in the database
         * 
         * @Param db the database
         */
        public void Delete(DB db)
        {
            db.openConnection();
            String[] arg = { Id.ToString() };
            db.nonSelect("delete from vente where code_facture = ?", arg);
            db.nonSelect("delete from facture where code_facture = ?", arg);
            db.closeConnection();
        }

        public Client Client { get => client; set => client = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public string Date { get => date; set => date = value; }
        
        public int Id { get => id; set => id = value; }
        private List<Sale> Sales { get => sales; set => sales = value; }
    }
}
