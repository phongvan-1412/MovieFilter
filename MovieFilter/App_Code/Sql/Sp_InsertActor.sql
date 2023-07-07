create proc Sp_InsertActor
@FName nvarchar(500),
@Gender int,
@LName nvarchar(500),
@FulName nvarchar(1000)
as
begin
	Declare @ActorTmp TABLE(
		act_id int
	)
	insert into [actor]([act_fname],[act_gender],[act_lname],[act_fullname])
	OUTPUT  inserted.act_id INTO @ActorTmp
	values (@FName, @Gender, @LName, @FulName)

	declare @Id int = (select top 1 act_id from @ActorTmp)
	select top 1 * from [actor] where act_id = @Id
end