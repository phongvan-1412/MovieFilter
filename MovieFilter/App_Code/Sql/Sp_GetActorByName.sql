create proc Sp_GetActorByName
@ActName nvarchar(1000)
as
begin
	select * from actor where act_fullname like '%'+@ActName+'%'
end