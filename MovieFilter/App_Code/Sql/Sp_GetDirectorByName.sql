create proc Sp_GetDirectorByName
@DirName nvarchar(4000)
as
begin
	select * from director where dir_fullname like '%' +@DirName+ '%'
end
