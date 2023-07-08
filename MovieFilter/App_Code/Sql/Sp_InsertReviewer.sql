create proc Sp_InsertReviewer
@Name nvarchar(4000),
@History ntext,
@Email varchar(4000),
@Pass varchar(4000)
as 
begin 
    declare @ReviewerTmp Table(
        rev_id int
    )

    insert into [reviewer]([rev_name], [history], [rev_email], [rev_password])
    output inserted.rev_id into @ReviewerTmp
    values(@Name, @History, @Email, @Pass)

    declare @Id int = (select top 1 rev_id from @ReviewerTmp)
    select top 1 * from [reviewer] where rev_id = @Id
end 