--Aaron Shaneen
--CS2550 M/W 1130
--SQL Assignment #4

--1
SELECT ROUND(AVG(cost), 2) AS Average_Cost
FROM Course;

--2
SELECT COUNT(*) AS January_Registrations
FROM Student
WHERE TO_CHAR(registration_date, 'MM/YY') = '01/07';

--3
SELECT AVG(numeric_grade) AS Average, MAX(numeric_grade) AS Highest,
  MIN(numeric_grade) AS Lowest
FROM Grade
WHERE section_id = 151
  AND grade_type_code = 'FI';

--4
SELECT city, state, COUNT(*) AS Zipcodes
FROM Zipcode
GROUP BY city, state
HAVING COUNT(*) > 3
ORDER BY state, city;

--5
SELECT section_id, COUNT(*) AS Enrolled
FROM Enrollment
WHERE TO_CHAR(enroll_date, 'MM/DD/YYYY') = '02/21/2007'
GROUP BY section_id
ORDER BY Enrolled DESC;

--6
SELECT student_id, section_id, TO_CHAR(AVG(numeric_grade), '9999.9999') AS Average_Grade
FROM Grade
WHERE section_id = 86
GROUP BY student_id, section_id
ORDER BY student_id;

--7
SELECT student_id, COUNT(*) AS Sections
FROM Enrollment
WHERE student_id = 250
GROUP BY student_id;

--8
SELECT section_id, MIN(numeric_grade) AS Low_Score
FROM Grade
WHERE grade_type_code = 'QZ'
GROUP BY section_id
HAVING MIN(numeric_grade) >= 80
ORDER BY section_id;

--9
SELECT employer, COUNT(*) AS Employees
FROM Student
GROUP BY employer
HAVING COUNT(*) > 5
ORDER BY Employees;

--10
SELECT section_id, COUNT(*) AS Participation_Grades,
  MIN(numeric_grade) AS Lowest_Grade
FROM Grade
WHERE grade_type_code = 'PA'
GROUP BY section_id
HAVING COUNT(*) > 15
ORDER BY section_id;