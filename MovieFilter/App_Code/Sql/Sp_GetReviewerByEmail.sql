create proc Sp_GetReviewerByEmail
@Email varchar(4000)
as
begin
	select * from reviewer where rev_email like '%' +@Email+ '%'
end
