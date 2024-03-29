﻿using mdi_project.database;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdi_project.database;
using System.Windows.Forms;

namespace mdi_project.user
{
    public class UserDBManager
    {
        public bool insert(users userss)
        {
            try
            {
                OracleConnection conn = DBINFO.openConnect();
                string sql = "insert into Users (idx,email,addr,password,name) " +
                    "values (usersIdx.nextval,:email,:addr,:password,:name)";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":email", userss.Email);
                cmd.Parameters.Add(":addr", userss.Addr);
                cmd.Parameters.Add(":password", userss.Password);
                cmd.Parameters.Add(":name", userss.Name);
                cmd.ExecuteNonQuery();

                DBINFO.closeConnect();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void update(users userss)
        {

        }
        public void delete(users userss)
        {

        }
        public DataTable select()
        {
            try
            {
                OracleConnection con = DBINFO.openConnect();

                string sql = "select*from users";

                OracleDataAdapter adapter = new OracleDataAdapter();
                DataSet ds = new DataSet();

                OracleCommand oracleCommand = new OracleCommand(sql, con);
                adapter.SelectCommand = oracleCommand;

                adapter.Fill(ds);

                DBINFO.closeConnect();
                return ds.Tables[0];
            }catch(Exception e )
            {
                MessageBox.Show(e.StackTrace);
                MessageBox.Show(e.Message);
                return null;

            }
  
        }

    }
}
