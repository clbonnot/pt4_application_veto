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
    public class Product
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
        public Product()
        {

        }

        /**
         * Constructor of the class that create a product from the database.
         * 
         * @param int i the id of the product in the database
         * @param db the database
         */
        public Product(int i, DB db)
        {
            db.openConnection();
            Id = i;
            String[] arg = { id.ToString() };
            AllSuppliers = new List<Supplier>();
            OleDbDataReader reader = db.select("select * from produit where code_produit = ?", arg);
            if (reader.Read())
            {
                Name = reader.GetString(1);
                Description = reader.GetString(2);
                Quantity = reader.GetInt32(3);
               
                Price = reader.GetDecimal(4);

                try { 
                    Brand = reader.GetString(5);
                }
                catch
                {
                    Brand = "uknown";
                }
                OleDbDataReader readerSupplier = db.select("select code_fournisseur from fournisseurProduit where code_produit = ?", arg);
                while (readerSupplier.Read())
                {
                    AllSuppliers.Add(new Supplier(readerSupplier.GetInt32(0), db));
                }


            }
            db.closeConnection();
        }

        /**
         * Function that add e a sale in the database.
         * 
         */
        public void SetSale(DB db, Client c, int q)
        {
            db.openConnection();
            String[] values = { c.Id.ToString(), Id.ToString(), q.ToString() };
            db.nonSelect("insert into vente (code_personne, code_produit, quantite_vendue) values (?,?,?)", values);
            db.closeConnection();
      
        }

        /**
         * Function that add a supplier to the product, to the current instance and in the database.
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
        * Function that update the current instance in the database with the attribute of an another product
        * 
        * @param db the databse
        * @param p the another product
        */
        public void Update(DB db, Product p)
        {
            db.openConnection();
            String[] values = { p.Name, p.Description, p.Quantity.ToString(), p.Price.ToString(CultureInfo.InvariantCulture), p.Brand, Id.ToString() };
        
            db.nonSelect("update produit " +
                "set nom = ?, " +
                "descrip = ?, " +
                "quantite = ?, " +
                "prix = ?, " +
                "marque = ? " +
                "where code_produit = ?", values);
            Name = p.Name;
            Quantity = p.Quantity;
            Description = p.Description;
            Price = p.Price;
            Brand = p.Brand;
            db.closeConnection();
        }

        /**
         * Function that updates the quantity of a product in the database and to the current instance.
         * 
         * @Param db the database
         * @Param q the number to remove to the quantity
         * @Return the new quantity
         */
        public int UpdateQuantity(DB db, int q)
        {    
            if(Quantity - q < 0)
            {
                return -1;
            }
            Quantity = Quantity - q;
            db.openConnection();
            String[] values = { Quantity.ToString() , Id.ToString() };
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
            db.closeConnection();
        }

        /**
         * Function that adds the current instance in the database
         * 
         * @Param db the database
         */
        public void Flush(DB db)
        {
            db.openConnection();
            String[] v = { Name, Description, Quantity.ToString(), Price.ToString(CultureInfo.InvariantCulture), Brand };
            
            db.nonSelect("insert into produit (nom, descrip, quantite, prix, marque) values (?,?,?,?,?)", v);
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
