select
	Id,
	FullName,
	Cource
from 
	StudentDetailedView
where 
	id = @SearchId
	and Cource = @SearchCourse
