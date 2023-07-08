create proc Sp_UpdateDirector
@Id int,
@FName nvarchar(4000),
@LName nvarchar(4000),
@FulName nvarchar(4000)
as 
begin
    Update [director] set dir_fname = @FName, dir_lname = @LName, dir_fullname = @FulName
    where dir_id = @Id

    Select * from [director] where dir_id = @Id
end
