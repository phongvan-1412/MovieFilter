create proc Sp_GetDirectorByName
@Name nvarchar(4000)
as
begin
	select * from director where dir_fullname like '%@Name%'
end