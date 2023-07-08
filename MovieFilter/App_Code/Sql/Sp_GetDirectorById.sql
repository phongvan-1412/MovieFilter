create proc Sp_GetDirectorById
@Id int
as
begin
	select * from director where dir_id = @Id
end