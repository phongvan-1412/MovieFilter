using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


public class Service : IService
{
    //Actor
    public List<actor> GetAllActors()
    {
        var lstActors = DbContext.Instance.Exec<List<actor>>(DbStore.GetAllActors);
        return lstActors;
    }
    public actor GetActorById(int id)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Id", id },
        };

        var lstActors = DbContext.Instance.Exec<List<actor>>(DbStore.GetActorById, param);
        return lstActors.FirstOrDefault();
    }
    public string InsertActor(actor obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@FName", obj.act_fname },
            { "@Gender", obj.act_gender },
            { "@LName", obj.act_lname },
            { "@FulName", obj.act_fullname },
        };

        var result = DbContext.Instance.Exec<List<actor>>(DbStore.InsertActor, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Create Successfully";
    }

    public string UpdateActor(actor obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Id", obj.act_id },
            { "@FName", obj.act_fname },
            { "@LName", obj.act_lname },
            { "@Gender", obj.act_gender },
            { "@FulName", obj.act_fullname },
        };

        var result = DbContext.Instance.Exec<List<actor>>(DbStore.UpdateActor, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Update Successfully";
    }

    //Movie
    public List<movie> GetAllMovies()
    {
        var lstMovies = DbContext.Instance.Exec<List<movie>>(DbStore.GetAllMovies);
        return lstMovies;
    }

}
