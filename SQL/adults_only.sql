/*
https://www.codewars.com/kata/adults-only-sql-for-beginners-number-1/train/sql

Difficulty: 8 kyu

In your application, there is a section for adults only. You need to get a list of names and ages of users from the users table, who are 18 years old or older.

users table schema
- name
- age

NOTE: Your solution should use pure SQL. Ruby is used within the test cases to do the actual testing.

FUNDAMENTALS, SQL, DATABASES, INFORMATION SYSTEMS, DATA
*/

SELECT *
FROM users
WHERE age >= 18;

/**************************************************/
/**************************************************/
/**************************************************/

/*
results = run_sql

describe :users do
  it "should return 4 users" do
    expect(results.count).to eq 4
  end
end
*/