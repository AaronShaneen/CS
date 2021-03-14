--Aaron Shaneen
--CS2550 M/W 1130
--SQL Assignment #1

--1
SELECT last_name, first_name
  FROM instructor
  ORDER BY last_name;

--2
SELECT DISTINCT location
  FROM section
  ORDER BY location;

--3
SELECT first_name, last_name
  FROM instructor
  WHERE last_name LIKE 'W%'
  ORDER BY first_name, last_name;

--4
SELECT phone, first_name || ' ' || last_name, employer
  FROM student
  WHERE last_name = 'Miller'
  ORDER BY phone;

--5
SELECT course_no, description
  FROM course
  WHERE prerequisite = 20
  ORDER BY course_no;

--6
SELECT course_no, description, cost
  FROM course
  WHERE course_no BETWEEN 200 AND 299
  AND cost < 1100
  ORDER BY course_no;

--7
SELECT course_no, section_id
  FROM section
  WHERE course_no BETWEEN 100 AND 199
  AND location IN ('L211', 'L214')
  ORDER BY course_no, section_id;

--8
SELECT course_no, section_id
  FROM section
  WHERE capacity IN (10, 12)
  ORDER BY course_no, section_id;

--9
SELECT student_id, numeric_grade
  FROM grade
  WHERE grade_type_code = 'FI'
  AND section_id = 147
  ORDER BY student_id, numeric_grade;

--10
SELECT course_no, description
  FROM course
  WHERE course_no BETWEEN 200 AND 299
  AND prerequisite IS NOT NULL
  ORDER BY description;