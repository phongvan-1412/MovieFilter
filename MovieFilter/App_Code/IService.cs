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
    int GetActorByName(string name);
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
    int GetDirectorByName(string name);
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
    int GetGenreByName(string name);
    [OperationContract]
    string InsertGenre(genre obj);
    [OperationContract]
    string UpdateGenre(genre obj);

    //Movie
    [OperationContract]
	List<movie> GetAllMovies();
    [OperationContract]
    movie GetMovieById(int id);
    [OperationContract]
    movie InsertMovie(movie obj);
    //[OperationContract]
    //string UpdateMovie(movie obj);

    //Movie_cast + Movie_direction + Movie_genres
    [OperationContract]
    string InsertMovCast(movie_cast obj);
    [OperationContract]
    string InsertMovDir(movie_direction obj);
    [OperationContract]
    string InsertMovGen(movie_genres obj);


}