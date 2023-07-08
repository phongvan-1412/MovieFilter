create proc Sp_GetReviewerById
@Id int 
as 
begin 
    select * from [reviewer] where rev_id = @Id
end