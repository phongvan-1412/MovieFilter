create proc Sp_InsertMovie
@Title nvarchar(4000),
@Year varchar(10),
@Length varchar(4000),
@Lang nvarchar(4000),
@DateRel varchar(4000),
@Country nvarchar(4000)
as
begin
	Declare @MovieTmp TABLE(
		mov_id int
	)
	insert into [movie]([mov_title],[mov_year],[mov_time],[mov_lang],[mov_dt_rel],[mov_rel_country])
	OUTPUT inserted.mov_id INTO @MovieTmp
	values (@Title, @Year, @Length, @Lang, @DateRel, @Country)

    declare @Id int = (select top 1 mov_id from @MovieTmp)
	select top 1 * from [movie] where mov_id = @Id
end