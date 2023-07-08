create proc Sp_GetGenreById
@Id int 
as 
begin 
    select * from [genres] where gen_id = @Id
end