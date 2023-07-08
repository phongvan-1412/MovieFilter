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

    //Director
    [OperationContract]
    List<director> GetAllDirectors();
    [OperationContract]
    director GetDirectorById(int id);
    [OperationContract]
    string InsertDirector(director obj);
    [OperationContract]
    string UpdateDirector(director obj);

    //Genre
    [OperationContract]
    List<genre> GetAllGenres();
    [OperationContract]
    genre GetGenreById(int id);
    [OperationContract]
    string InsertGenre(genre obj);
    [OperationContract]
    string UpdateGenre(genre obj);

    //Movie
    [OperationContract]
	List<movie> GetAllMovies();
    
}