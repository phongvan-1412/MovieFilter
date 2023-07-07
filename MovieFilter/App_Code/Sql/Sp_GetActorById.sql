create proc Sp_GetActorById
@Id int
as
begin
	select * from actor where act_id = @Id
end