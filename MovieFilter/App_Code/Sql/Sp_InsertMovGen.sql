create proc Sp_InsertMovGen
@MovId int,
@GenId int
as
begin
	insert into [movie_genres]([mov_id], [gen_id])
	values (@MovId, @GenId)
    
	select top 1 * from [movie_genres] where mov_id = @MovId
end