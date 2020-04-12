using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Data.OleDb;

namespace project
{
    interface bbank
    {
        void Select(string query, string tablename);
        void Insert(string query);
        void Delete(string query);
        void Update(string query);
        string cnfrm_username_password(string name, string password);
    
    }

    abstract class bank : bbank
    {
        public OleDbConnection conn = new OleDbConnection();
        public OleDbDataAdapter dadapt = new OleDbDataAdapter();
        public DataSet dset = new DataSet();
        public abstract void Select(string query, string tablename);
        public abstract void Insert(string query);
        public abstract void Delete(string query);
        public abstract void Update(string query);
        public abstract string cnfrm_username_password(string name, string password);
        public static string username;
        public static string password;
    }

    class Parent : bank
    {

     public Parent()
        {
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Database.mdb";
            conn.Open();
        }

        public override void Select(string query, string tablename)
        {
            dadapt = new OleDbDataAdapter(query, conn);
            dadapt.Fill(dset, tablename);
        }

        public override void Insert(string query)
        {
            OleDbCommand comd = new OleDbCommand(query, conn);
            comd.ExecuteNonQuery();
        }

        public override void Delete(string query)
        {
            OleDbCommand comd = new OleDbCommand(query, conn);
            comd.ExecuteNonQuery();
        }

        public override  void Update(string query)
        {
            OleDbCommand comd = new OleDbCommand(query, conn);
            comd.ExecuteNonQuery();
        }


        public override string cnfrm_username_password(string name, string password)
        {
            foreach (DataRow row in dset.Tables["Login"].Rows)
            {
                string n = row["User"].ToString();
                string p = row["Password"].ToString();
                if (name == n && p == password)
                {
                    bank.username = n;
                    bank.password = p;
                    return "match";
                    
                }
         
            }
            return "notmatch";
        }
    }
}
