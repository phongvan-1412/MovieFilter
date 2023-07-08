create proc Sp_GetGenreByName
@GenName nvarchar(4000)
as
begin
	select * from genres where gen_title like '%' +@GenName+ '%'
end
