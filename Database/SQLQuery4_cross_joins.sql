select * from student
select * from fees

select student.addmission_no,student.first_name,student.last_name,fees.course,fees.amount_paid
from student cross join fees