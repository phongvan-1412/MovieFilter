create proc Sp_InsertMovDir
@MovId int,
@DirId int
as
begin
	insert into [movie_direction]([mov_id], [dir_id])
	values (@MovId, @DirId)
    
	select top 1 * from [movie_direction] where mov_id = @MovId
end