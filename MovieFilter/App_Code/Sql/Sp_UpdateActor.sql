create proc Sp_UpdateActor
@Id int,
@FName nvarchar(500),
@LName nvarchar(500),
@Gender int,
@FulName nvarchar(1000)
as 
begin
	Update [actor]
	set [act_fname] = @FName, [act_lname] = @LName, [act_gender] = @Gender, [act_fullname] = @FulName
	where act_id = @Id

	select * from [actor] where act_id = @Id
end