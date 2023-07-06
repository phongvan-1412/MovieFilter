using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

/// <summary>
/// Summary description for DbContext
/// </summary>
public class DbContext
{
    private static DbContext instance;
    public string connString = ConfigurationManager.AppSettings.Get("ConnectionString");
    private string _storeFormat = "{0} {1}";

    public static DbContext Instance
    {
        get
        {
            instance = instance ?? new DbContext();
            return instance;
        }
    }

    public T Exec<T>(string storeName)
    {
        using (SqlConnection con = new SqlConnection(connString))
        {
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = storeName;
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset);
                cmd.Connection.Close();
                var res = JsonConvert.SerializeObject(dataset.Tables[0]);
                return JsonConvert.DeserializeObject<T>(res);
            }
        }
    }

    public T Exec<T>(string storeName, Dictionary<string, dynamic> parameters)
    {
        using (SqlConnection con = new SqlConnection(connString))
        {
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = storeName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                foreach (var item in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                da.SelectCommand = cmd;
                try
                {
                    DataSet dataset = new DataSet();
                    da.Fill(dataset);
                    cmd.Connection.Close();
                    var res = JsonConvert.SerializeObject(dataset.Tables[0]);
                    return JsonConvert.DeserializeObject<T>(res);
                }
                catch (Exception ex)
                {
                    cmd.Connection.Close();
                    return JsonConvert.DeserializeObject<T>("null");
                    throw ex;
                }
            }
        }
    }
    public DbContext()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}