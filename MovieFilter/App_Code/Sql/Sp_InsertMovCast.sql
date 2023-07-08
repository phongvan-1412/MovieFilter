create proc Sp_InsertMovCast
@ActId int,
@MovId int,
@Role nvarchar(4000)
as
begin
	insert into [movie_cast]([act_id],[mov_id],[role])
	values (@ActId, @MovId, @Role)
    
	select top 1 * from [movie_cast] where mov_id = @MovId
end