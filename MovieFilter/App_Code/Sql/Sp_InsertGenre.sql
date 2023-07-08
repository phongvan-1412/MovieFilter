create proc Sp_InsertGenre
@Title nvarchar(4000)
as 
begin 
    declare @GenreTmp Table(
        gen_id int
    )

    insert into [genres]([gen_title])
    output inserted.gen_id into @GenreTmp
    values(@Title)

    declare @Id int = (select top 1 gen_id from @GenreTmp)
    select top 1 * from [genres] where gen_id = @Id
end 