create proc Sp_UpdateGenre
@Id int,
@Title nvarchar(4000)
as 
begin 
    update [genres] set gen_title = @Title where gen_id = @Id
    select * from [genres] where gen_id = @Id
end