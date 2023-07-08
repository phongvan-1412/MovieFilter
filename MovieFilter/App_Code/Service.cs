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

    //Director
    public List<director> GetAllDirectors()
    {
        var lstDirectors = DbContext.Instance.Exec<List<director>>(DbStore.GetAllDirectors);
        return lstDirectors;
    }
    public director GetDirectorById(int id)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Id", id },
        };

        var lstDirectors = DbContext.Instance.Exec<List<director>>(DbStore.GetDirectorById, param);
        return lstDirectors.FirstOrDefault();
    }
    public string InsertDirector(director obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@FName", obj.dir_fname },
            { "@LName", obj.dir_lname },
            { "@FulName", obj.dir_fullname },
        };

        var result = DbContext.Instance.Exec<List<director>>(DbStore.InsertDirector, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Create Successfully";
    }
    public string UpdateDirector(director obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Id", obj.dir_id },
            { "@FName", obj.dir_fname },
            { "@LName", obj.dir_lname },
            { "@FulName", obj.dir_fullname },
        };

        var result = DbContext.Instance.Exec<List<director>>(DbStore.UpdateDirector, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Update Successfully";
    }

    //Genre
    public List<genre> GetAllGenres()
    {
        var lstGenres = DbContext.Instance.Exec<List<genre>>(DbStore.GetAllGenres);
        return lstGenres;
    }
    public genre GetGenreById(int id)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Id", id },
        };

        var lstGenres = DbContext.Instance.Exec<List<genre>>(DbStore.GetGenreById, param);
        return lstGenres.FirstOrDefault();
    }
    public string InsertGenre(genre obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Title", obj.gen_title },
        };

        var result = DbContext.Instance.Exec<List<director>>(DbStore.InsertGenre, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Create Successfully";
    }
    public string UpdateGenre(genre obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Id", obj.gen_id },
            { "@Title", obj.gen_title },
        };

        var result = DbContext.Instance.Exec<List<director>>(DbStore.UpdateGenre, param);
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
    public movie GetMovieById(int id)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Id", id },
        };

        var lstMovies = DbContext.Instance.Exec<List<movie>>(DbStore.GetMovieById, param);
        return lstMovies.FirstOrDefault();
    }
    public string InsertMovie(movie obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@Title", obj.mov_title },
            { "@Year", obj.mov_year },
            { "@Length", obj.mov_time },
            { "@Lang", obj.mov_lang },
            { "@DateRel", obj.mov_dt_rel },
            { "@Country", obj.mov_rel_country },
        };

        var result = DbContext.Instance.Exec<List<director>>(DbStore.InsertMovie, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Create Successfully";
    }

    //Movie_cast + Movie_direction + Movie_genres
    public string InsertMovCast(movie_cast obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@ActId", obj.act_id },
            { "@MovId", obj.mov_id },
            { "@Role", obj.role }
        };

        var result = DbContext.Instance.Exec<List<movie_cast>>(DbStore.InsertMovCast, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Create Successfully";
    }
    public string InsertMovDir(movie_direction obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@MovId", obj.mov_id },
            { "@DirId", obj.dir_id }
        };

        var result = DbContext.Instance.Exec<List<movie_direction>>(DbStore.InsertMovDir, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Create Successfully";
    }
    public string InsertMovGen(movie_genres obj)
    {
        var param = new Dictionary<string, dynamic>
        {
            { "@MovId", obj.mov_id },
            { "@GenId", obj.gen_id }
        };

        var result = DbContext.Instance.Exec<List<movie_genres>>(DbStore.InsertMovGen, param);
        string resultString;

        if (result == null)
        {
            resultString = "Something Wrong in server.";
            return resultString;
        }

        return resultString = "Create Successfully";
    }
}
