using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.IO;
//using Finisar.SQLite;
namespace Equipment {
    public class DBManager {
        SQLiteConnection liteconn;
       // SqlCommand sqlCmd;
        SQLiteCommand sqlitecmd;


        ObservableCollection<Repairs> repairsObserv = new ObservableCollection<Repairs>();
        ObservableCollection<EQNameID> eqNameIDObserv = new ObservableCollection<EQNameID>();
        internal ObservableCollection<EQNameID> EqNameIDObserv {
            get  {
                return eqNameIDObserv;
            }

           private set {
                eqNameIDObserv = value;
            }
        }

        public ObservableCollection<Repairs> RepairsObserv{
            get {
                return repairsObserv;
            }

            set{
                repairsObserv = value;
            }
        }



        const string EQTable= "Equipment";

            const string ID          = "ID";
            const string INVNUMBER   = "InventoryNumber";
            const string EQNAME      = "EqName";
            const string WORKSHOP    = "Workshop";
            const string RESPONSIBLE = "Responsible";
            const string REGDATE     = "RegDate";
            const string IMAGEPATH   = "ImagePath";

        const string RepTable = "Repairs";

            const string REPID   = "RepId";
            const string IDEQ    = "ID";
            const string REPNAME = "RepName";
            const string DETAILS = "Details";
            const string REPDATE = "RepDate";
            const string PRICE   = "Price";


        //       Repairs
        //`RepID`	intidentity NOT NULL,
        //`ID`	int NOT NULL,
        //`RepName`	text,
        //`Datails`	text,
        //`RepDate`	date,
        //`Price`	text,
        //PRIMARY KEY(RepID),
        //FOREIGN KEY(`ID`) REFERENCES `Equipment`(`ID`) ON DELETE CASCADE


        string invNumber;
        string eqName;
        string workShop;
        string responsible;
        string date;
        string imagepat;

        public string InvNumber { get; set; }
        public string EqName { get; set; }
        public string WorkShop { get; set; }
        public string Responsible { get; set; }
        public System.DateTime RegDate { get; set; }
        public string Imagepath { get; set; }


        public string RepId { get; set; }
        public string IDeq { get; set; }
        public string RepName { get; set; }
        public string Details { get; set; }
        public System.DateTime RepDate { get; set; }
        public string Price { get; set; }
        public string PriceGrn { get; set; }
        public string PriceCopeck { get; set; }
        public float TotalPrice { get; set; }

        public DBManager() {
            liteconn = new SQLiteConnection("Data Source=Database1.db");
            liteconn.Open();
            SQLiteCommand cmd = liteconn.CreateCommand();
            cmd.CommandText = "PRAGMA foreign_keys = ON;";
            cmd.ExecuteNonQuery();

        }

        #region Equipment Table
       public  void  FillingMainListBox() {

            eqNameIDObserv.Clear();

            SQLiteCommand fillCmd =new SQLiteCommand();
            fillCmd.Connection = liteconn;
            fillCmd.CommandText = "SELECT "+ID+","+EQNAME+" FROM "+EQTable ;
            SQLiteDataReader reader = fillCmd.ExecuteReader();
            int i = 0;
            while (reader.Read()) {
                int a = 0;
                eqNameIDObserv.Add(new EQNameID());
              
                Int32.TryParse( reader[0].ToString(),out a);
                eqNameIDObserv[i].ID = a;
                eqNameIDObserv[i].Name = reader[1].ToString();

                i++;
            }
            reader.Close();
            
            Console.WriteLine("filling LB");
          //  return eqNameIDObserv;
            //LBEquipments.EndUpdate();
            //  manager.Refresh();
           
        }

        public void MainListBoxIndexChanged(int iditem) {
            Imagepath = "";
            Console.WriteLine("ItemSelected");
            SQLiteCommand itemSelect_Cmd = new SQLiteCommand();
            itemSelect_Cmd.Connection = liteconn;
            itemSelect_Cmd.CommandText = "SELECT *FROM "+EQTable+" WHERE ID=" + iditem + "";
            SQLiteDataReader reader = itemSelect_Cmd.ExecuteReader();

            while (reader.Read()) {
                DateTime a = new DateTime();
                

                InvNumber= reader[INVNUMBER].ToString();
                EqName = reader[EQNAME].ToString();
                WorkShop = reader[WORKSHOP].ToString();
                Responsible = reader[RESPONSIBLE].ToString();
                DateTime.TryParse(reader[REGDATE].ToString(),out a);
                RegDate = a;
               Imagepath = reader[IMAGEPATH].ToString();
            
            }
            reader.Close();
     

        }

       public void DeleteEquipment(int idDelete) {
            SQLiteCommand delCMD = new SQLiteCommand();
            delCMD.Connection = liteconn;
            delCMD.CommandText = "DELETE FROM "+EQTable+" WHERE "+ID+"="+idDelete+"";
            delCMD.ExecuteNonQuery();
           // this.FillingMainListBox();
            Console.WriteLine("Equipment has been deleted");


        }

        public void EditEquipmentTable() {

           
          InsertValues("Equipment", new string[] { INVNUMBER, EQNAME, WORKSHOP, RESPONSIBLE, REGDATE, IMAGEPATH },
                                    new string[] { InvNumber, EqName, WorkShop, Responsible, RegDate.ToString(), Imagepath });
                    
 }

        void InsertValues(string tableName, string[] fields, string[] values) {
            string cmdString = "";
            string fieldsstr = "";
            string valuesstr = "";
            var cmd = new SQLiteCommand();
            cmd.Connection = liteconn;
            for (int i = 0; i < fields.Length; ++i) {

                if (i >= fields.Length - 1) {
                    fieldsstr += fields[i];
                    valuesstr += values[i];
                }
                else {
                    fieldsstr += fields[i] + ",";
                    valuesstr += values[i] + "\",\"";
                }

            }
            cmdString = "INSERT INTO " + tableName + "(" + fieldsstr + ")" + "VALUES" + "(\"" + valuesstr + "\")";
            Console.WriteLine(fieldsstr);
            Console.WriteLine(valuesstr);
            Console.WriteLine(cmdString);
            cmd.CommandText = cmdString;
            cmd.ExecuteNonQuery();
            liteconn.Close();

        }

       


      public  void UpdateEquipmentTable(int id) {
           
            SQLiteCommand saveCmd = new SQLiteCommand();
            saveCmd.Connection = liteconn;
            saveCmd.CommandText = "UPDATE EQUIPMENT SET InventoryNumber='" + InvNumber
                                + "',EqName='" + EqName
                                + "',WorkShop='" + WorkShop
                                + "',Responsible='" + Responsible + "',RegDate='" + RegDate
                                + "',ImagePath='" + Imagepath + "' WHERE ID=" + id;
            saveCmd.ExecuteNonQuery();
            

        }
        public void FillMainEditForm(int iditem) {
            Imagepath = "";
            SQLiteCommand itemSelect_Cmd = new SQLiteCommand();
            itemSelect_Cmd.Connection = liteconn;


            // Main_lbl_ID.Text = iditem.ToString();

            itemSelect_Cmd.CommandText = "SELECT *FROM " + EQTable + " WHERE ID=" + iditem + "";

            //= itemSelect_Cmd.ExecuteScalar().ToString();
            SQLiteDataReader reader = itemSelect_Cmd.ExecuteReader();

            while (reader.Read()) {
                DateTime a = new DateTime();

                EqName = reader[EQNAME].ToString();
                InvNumber = reader[INVNUMBER].ToString();
                WorkShop = reader[WORKSHOP].ToString();
                Responsible = reader[RESPONSIBLE].ToString();
                DateTime.TryParse(reader[REGDATE].ToString(), out a);
                RegDate = a;
                Imagepath = reader[IMAGEPATH].ToString();
                //  Console.WriteLine(reader[1].ToString());

            }
            reader.Close();
         

        }
        #endregion

        public void FillingRepairsLB(int eqID) {
            float price = 0;
            TotalPrice = 0;
            repairsObserv.Clear();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = liteconn;
            cmd.CommandText = "SELECT*FROM " + RepTable + " WHERE " + IDEQ + "=" + eqID + "";
            SQLiteDataReader reader = cmd.ExecuteReader();
            int i = 0;
          //  Console.WriteLine(reader.Read());
            while (reader.Read()) {
                int a = 0;
                repairsObserv.Add(new Repairs());
                repairsObserv[i].RepName = reader[2].ToString();
                Int32.TryParse(reader[0].ToString(), out a);
                repairsObserv[i].RepID = a;
                float.TryParse(reader["Price"].ToString(), out price);
               TotalPrice += price;
               i++;
            }
            reader.Close();
      

        }

        public void FillingRepForm(int repID) {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection =liteconn;
            cmd.CommandText ="SELECT*FROM "+RepTable+" WHERE "+ REPID+"="+ repID + "";
            SQLiteDataReader reader = cmd.ExecuteReader();
            //TBDetails.Text = cmd.ExecuteScalar().ToString();
            while (reader.Read()) {
                DateTime a = new DateTime();
                Details = reader[DETAILS].ToString();
                Price = reader[PRICE].ToString();
               
                try {
                    DateTime.TryParse(reader[REPDATE].ToString(), out a);
                }
                catch(System.Exception e) {
                    Console.WriteLine(e);
                }
                RepDate = a;


            }
            reader.Close();

        }

       public void DeleteRepair(int repID) {
            SQLiteCommand delCMD = new SQLiteCommand();
            delCMD.Connection = liteconn;
            delCMD.CommandText = "DELETE FROM "+RepTable+" WHERE "+ REPID+"="+ repID + "";
            delCMD.ExecuteNonQuery();
            
          }

       public void AddRepair(int id) {
       
            SQLiteCommand sendCMD = new SQLiteCommand();
            sendCMD.Connection = liteconn;
            sendCMD.CommandText = "INSERT INTO " + RepTable + "(" + IDEQ + "," + REPNAME + "," + DETAILS + "," + REPDATE + "," + PRICE + ")" + " VALUES(" + id
                                                                + ",'" + RepName
                                                                + "','" + Details
                                                                + "','" + RepDate.ToShortDateString()
                                                                + "','" + Price
                                                                + "')";// RepID ID  RepName Details  Price DATE
            sendCMD.ExecuteNonQuery();
        }

        public void FillingEditRepairsForm(int repId) {
            SQLiteCommand fillCMD = new SQLiteCommand();
            fillCMD.Connection = liteconn;
            fillCMD.CommandText = "SELECT*FROM "+RepTable+" WHERE RepID=" + repId + "";//RepName Details  Price DATE
            SQLiteDataReader reader = fillCMD.ExecuteReader();

            while (reader.Read()) {
                DateTime a = new DateTime();
                RepName = reader[REPNAME].ToString();
                Details = reader[DETAILS].ToString();
                PriceGrn = SeparatePriceGrn(reader[PRICE].ToString());
                PriceCopeck = SeparatePriceCop(reader[PRICE].ToString());
                DateTime.TryParse(reader[REPDATE].ToString(),out a);
                RepDate = a;
            }
            reader.Close();


        }

        static string SeparatePriceGrn(string price) {
            string[] aprice = price.Split(',');
            Console.WriteLine(aprice[0]);
            return aprice[0];
        }
        static string SeparatePriceCop(string price) {
            string[] aprice = price.Split(',');
            //Console.WriteLine(aprice[1]);
            if (aprice.Length > 1) {
                return aprice[1];
            }
            else {
                return "";
            }

        }

       public void ApplyEditRepChanges(int repId) {
            
            string price = PriceGrn + "," + PriceCopeck;
       
            // System.DateTime.
            //  Console.WriteLine(RegDate);
            SQLiteCommand saveCmd = new SQLiteCommand();
            saveCmd.Connection = liteconn;
            saveCmd.CommandText = "UPDATE " +RepTable
                                + " SET "+REPNAME+"='"  + RepName
                                + "',"+DETAILS+"='"    + Details
                                + "',"+REPDATE+"='"    + RepDate
                                + "',"+PRICE+"='"      + price
                                + "' WHERE "+REPID+"=" + repId + "";
            saveCmd.ExecuteNonQuery();

        
        }

        public void CalculateTotalPrice() {
            TotalPrice = 0;
            float price = 0;
            SQLiteCommand getTtlPriceCMD = new SQLiteCommand();
            getTtlPriceCMD.Connection = liteconn;
            getTtlPriceCMD.CommandText = "SELECT "+PRICE+" FROM "+RepTable;
            SQLiteDataReader reader = getTtlPriceCMD.ExecuteReader();
            while (reader.Read()) {
                float.TryParse(reader[PRICE].ToString(),out price);
                TotalPrice += price;

            }
            reader.Close();


        }


    }
}
