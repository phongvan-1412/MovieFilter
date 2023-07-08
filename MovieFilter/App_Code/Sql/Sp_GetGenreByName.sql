create proc Sp_GetGenreByName
@Name nvarchar(4000)
as
begin
	select * from genres where gen_title like '%@Name%'
end