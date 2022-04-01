using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public class Medic
    {


        int id;
        string name;
        string description;
        int quantity;
        Decimal price;
        string brand;
        List<Supplier> allSuppliers;
        /**
         * Basic constructor of the class
         */
        public Medic()
        {

        }

        /**
         * Constructor of the class that create a drug from the database.
         * 
         * @param int i the id of the drug in the database
         * @param db the database
         */
        public Medic(int i, DB db)
        {
            db.openConnection();
            Id = i;
            String[] arg = { id.ToString() };
            AllSuppliers = new List<Supplier>();
            OleDbDataReader reader = db.select("select * from produit Inner join Medicament on Medicament.code_produit = PRODUIT.code_produit " +
                "Inner Join traitement on traitement.code_traitement=Medicament.code_traitement where code_produit = ?", arg);
            if (reader.Read())
            {
                Name = reader.GetString(1);
                Description = reader.GetString(2);
                Quantity = reader.GetInt32(3);

                Price = reader.GetDecimal(4);

                try
                {
                    Brand = reader.GetString(5);
                }
                catch
                {
                    Brand = "uknown";
                }
                OleDbDataReader readerSupplier = db.select("select code_fournisseur from fournisseurProduit" +
                    " Inner join Medicament on Medicament.code_produit = PRODUIT.code_produit " +
                    "Inner Join traitement on traitement.code_traitement=Medicament.code_traitement where code_produit = ?", arg);
                while (readerSupplier.Read())
                {
                    AllSuppliers.Add(new Supplier(readerSupplier.GetInt32(0), db));
                }


            }
            db.closeConnection();
        }

        /**
         * Function that add a supplier to the drug, to the current instance and in the database.
         * 
         * @Param db the database
         * @Param supplier the supplier to add
         */
        public void AddSupplier(DB db, Supplier supplier)
        {
            AllSuppliers.Add(supplier);
            db.openConnection();
            String[] v = { supplier.Id.ToString(), Id.ToString() };
            db.nonSelect("insert into fournisseurProduit (code_fournisseur, code_produit) values(?,?) ", v);
            db.closeConnection();
        }

        /**
         * Function that remove a supplier to the product, to the current instance and in the database.
         * 
         * @Param db the database
         * @Param supplier the supplier to remove
         */
        public void RemoveSupplier(DB db, Supplier supplier)
        {
            AllSuppliers.Remove(supplier);
            db.openConnection();
            String[] v = { supplier.Id.ToString(), Id.ToString() };
            db.nonSelect("delete from fournisseurProduit where code_fournisseur = ? and code_produit = ?", v);
            db.closeConnection();

        }

        /**
        * Function that update the current instance in the database with the attribute of an another drug
        * 
        * @param db the databse
        * @param p the another product
        */
        public void Update(DB db, Medic p)
        {
            db.openConnection();
            String[] values1 = { p.Name, p.Description, Id.ToString() };
            String[] values2 = { p.Name, p.Description, p.Quantity.ToString(), p.Price.ToString(CultureInfo.InvariantCulture), p.Brand, Id.ToString() };
            db.nonSelect("update traitement " +
                "set nom = ?, " +
                "descrip = ?, " +
                "where code_produit = ?", values1);
            db.nonSelect("update produit " +
                "set nom = ?, " +
                "descrip = ?, " +
                "quantite = ?, " +
                "prix = ?, " +
                "marque = ? " +
                "where code_produit = ?", values2);
            Name = p.Name;
            Quantity = p.Quantity;
            Description = p.Description;
            Price = p.Price;
            Brand = p.Brand;
            db.closeConnection();
        }

        /**
         * Function that updates the quantity of a drug in the database and to the current instance.
         * 
         * @Param db the database
         * @Param q the number to remove to the quantity
         * @Return the new quantity
         */
        public int UpdateQuantity(DB db, int q)
        {
            if (Quantity - q < 0)
            {
                return -1;
            }
            Quantity = Quantity - q;
            db.openConnection();
            String[] values = { Quantity.ToString(), Id.ToString() };
            db.nonSelect("update produit set quantite = ? where code_produit = ?", values);
            db.closeConnection();
            return Quantity;

        }



        /**
         * Function that deletes the current instance from the database.
         * 
         * @Param db the database
         */
        public void Delete(DB db)
        {
            db.openConnection();
            String[] v = { Id.ToString() };
            db.nonSelect("Delete from fournisseurproduit where code_produit = ?", v);
            db.nonSelect("DELETE FROM produit where code_produit = ?", v);
            db.nonSelect("DELETE FROM traitement inner Join Medicament on traitement.code_traitement=Medicament.code_traitement where code_produit = ?", v);
            db.nonSelect("DELETE FROM Medicament where code_produit = ?", v);
            db.closeConnection();
        }

        /**
         * Function that adds the current instance in the database
         * 
         * @Param db the database
         */
        public void Flush(DB db)
        {
            string idP = "";
            string idT = "";
            db.openConnection();
            String[] v1 = { Name, Description};
            String[] v2 = { Name, Description, Quantity.ToString(), Price.ToString(CultureInfo.InvariantCulture), Brand };
            db.nonSelect("insert into traitement (nom, descrip) values (?,?)", v1);
            db.nonSelect("insert into produit (nom, descrip, quantite, prix, marque) values (?,?,?,?,?)", v2);
            OleDbDataReader reader = db.select("select code_produit from produit");
            OleDbDataReader reader2 = db.select("select code_traitement from traitement");
            while (reader.Read())
            {
                idP = reader.GetString(1).Trim(' ');
            }
            while (reader2.Read())
            {
                idT = reader.GetString(2).Trim(' ');
            }
            if (!idP.Equals("") && idT.Equals(""))
            {
                String[] v3 = {idT , idP };
                db.nonSelect("insert into Medicament (code_traitement, code_produit) values (?,?)", v3);
            }
            
            db.closeConnection();
        }

        public override string ToString()
        {
            return Name + " | " + Quantity.ToString() + " en stock";
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Description { get => description; set => description = value; }
        public Decimal Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        internal List<Supplier> AllSuppliers { get => allSuppliers; set => allSuppliers = value; }
    }


}

