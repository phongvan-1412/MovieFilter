create proc Sp_GetActorByName
@Name nvarchar(1000)
as
begin
	select * from actor where act_fullname like '%@Name%'
end