create proc Sp_GetMovieById
@Id int 
as 
begin 
    select * from movie where mov_id = @Id
end