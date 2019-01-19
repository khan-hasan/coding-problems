/*
https://www.codewars.com/kata/collect-tuition-sql-for-beginners-number-4/train/sql

Difficulty: 8 kyu

You are working for a local school, and you are responsible for collecting tuition from students. You have a list of all students, some of them have already paid tution and some haven't. Write a select statement to get a list of all students who haven't paid their tuition yet. The list should include all the data available about these students.

students table schema

name (string)
age (integer)
semester (integer)
mentor (string)
tuition_received (Boolean)
NOTE: Your solution should use pure SQL. Ruby is used within the test cases to do the actual testing.

FUNDAMENTALS, SQL, DATABASES, INFORMATION SYSTEMS, DATA

/**************************************************/
/**************************************************/
/**************************************************/

SELECT *
    FROM STUDENTS
    WHERE tuition_received = FALSE;

/*
# Run SQL
results = run_sql

# Tests
describe :students do
  it "should return 6 students" do
    expect(results.count).to eq 6
  end
end
*/