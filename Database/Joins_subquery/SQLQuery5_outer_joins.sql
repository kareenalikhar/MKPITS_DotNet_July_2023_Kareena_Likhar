--left outer joins
select * from student
select * from fees

select student.addmission_no,student.first_name,student.last_name,fees.course,fees.amount_paid
from student left outer join fees on
student.addmission_no=fees.addmission_no

--right outer joins
select student.addmission_no,student.first_name,student.last_name,fees.course,fees.amount_paid
from student right outer join fees on
student.addmission_no=fees.addmission_no

--full outer joins
select student.addmission_no,student.first_name,student.last_name,fees.course,fees.amount_paid
from student full outer join fees on 
student.addmission_no=fees.addmission_no