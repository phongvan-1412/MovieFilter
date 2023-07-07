using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


[ServiceContract]
public interface IService
{
    //Actor
    [OperationContract]
    List<actor> GetAllActors();
    [OperationContract]
    actor GetActorById(int id);
    [OperationContract]
    string InsertActor(actor obj);
    [OperationContract]
    string UpdateActor(actor obj);

    //Movie
    [OperationContract]
	List<movie> GetAllMovies();
    
}