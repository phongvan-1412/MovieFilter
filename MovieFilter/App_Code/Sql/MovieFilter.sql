create table genres(
    gen_id int identity(1,1) primary key,
    gen_title nvarchar(4000) default ''
)

create table director (
    dir_id int identity(1,1) primary key,
    dir_fname nvarchar(4000) default '',
    dir_lname nvarchar(4000) default '',
    dir_fullname nvarchar(4000) default ''
)

create table reviewer (
    rev_id int identity(1,1) primary key,
    rev_name nvarchar(4000) default '',
    history ntext default ''
)

create table movie (
    mov_id int identity(1,1) primary key,
    mov_title nvarchar(4000) default '',
    mov_year varchar(10) default '',
    mov_time varchar(4000) default '',
    mov_lang nvarchar(4000) default '',
    mov_dt_rel varchar(4000) default '',
    mov_rel_country nvarchar(4000) default ''
)

create table actor (
    act_id int identity(1,1) primary key,
    act_fname nvarchar(500) default '',
    act_lname nvarchar(500) default '',
    act_fullname nvarchar(1000) default '',
    act_gender int references genres(gen_id)
)

create table movie_genres (
    movie_genres_id int identity(1,1) primary key,
    mov_id int references movie(mov_id),
    gen_id int references genres(gen_id)
)

create table movie_direction (
    movie_director_id int identity(1,1) primary key,
    dir_id int references director(dir_id),
    mov_id int references movie(mov_id)
)

create table rating (
    rate_id int identity(1,1) primary key,
    mov_id int references movie(mov_id),
    rev_id int references reviewer(rev_id),
    rev_stars int default 0,
    num_o_rating int default 0
)

create table movie_cast (
    movie_cast_id int identity(1,1) primary key,
    act_id int references actor(act_id),
    mov_id int references movie(mov_id),
    role nvarchar(4000) default ''
)