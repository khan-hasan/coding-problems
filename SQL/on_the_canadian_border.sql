/*
https://www.codewars.com/kata/on-the-canadian-border-sql-for-beginners-number-2

Difficulty: 8 kyu

You are a border guard sitting on the Canadian border. You were given a list of travelers who have arrived at your gate today. You know that American, Mexican, and Canadian citizens don't need visas, so they can just continue their trips. You don't need to check their passports for visas! You only need to check the passports of citizens of all other countries!

Select names, and countries of origin of all the travelers, excluding anyone from Canada, Mexico, or The US.

travelers table schema

name
country
NOTE: The United States is written as 'USA' in the table.

NOTE: Your solution should use pure SQL. Ruby is used within the test cases to do the actual testing.

This kata is part of a collection of SQL challenges for beginners. You can take the rest of the challenges here!
FUNDAMENTALS, SQL, DATABASES, INFORMATION SYSTEMS, DATA
*/

SELECT *
    FROM travelers
    WHERE country NOT IN ('USA', 'Mexico', 'Canada')

/**************************************************/
/**************************************************/
/**************************************************/

/*
# Run SQL
results = run_sql

# Tests
describe :travelers do
  it "should return 6 travelers" do
    expect(results.count).to eq 6
  end
end
*/