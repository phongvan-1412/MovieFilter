create proc Sp_InsertDirector
@FName nvarchar(4000),
@LName nvarchar(4000),
@FulName nvarchar(4000)
as
begin
	Declare @DirectorTmp TABLE(
		dir_id int
	)
	insert into [director]([dir_fname],[dir_lname],[dir_fullname])
	OUTPUT  inserted.dir_id INTO @DirectorTmp
	values (@FName, @LName, @FulName)

	declare @Id int = (select top 1 dir_id from @DirectorTmp)
	select top 1 * from [director] where dir_id = @Id
end