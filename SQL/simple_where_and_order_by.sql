/*
https://www.codewars.com/kata/sql-basics-simple-where-and-order-by/train/sql

Difficulty: 8 kyu

For this challenge you need to create a simple SELECT statement that will return all columns from the people table WHERE their age is over 50

people table schema
id
name
age
You should return all people fields where their age is over 50 and order by the age descending

NOTE: Your solution should use pure SQL. Ruby is used within the test cases to do the actual testing.

NOTE 2: Don't end your query with a semicolon.

FUNDAMENTALS, SQL, DATABASES, INFORMATION SYSTEMS, DATA, FILTERING, ALGORITHMS
*/

-- Create your SELECT statement here
SELECT *
    FROM people
    WHERE age > 50
    ORDER BY age DESC

/**************************************************/
/**************************************************/
/**************************************************/

/*
results = run_sql

describe :items do
   it "should return people with age over 50" do
     record_count = get_all_records(:people).count
     expect(results.count).to eq record_count
   end
   
   it "should return names" do
     results.each do |result|
       expect(result[:name]).to eq find_record(:people, result[:id]).name
     end
   end
   
   it "should only return people with age over 50" do
     results.each do |result|
       expect(result[:age]).to be > 50
     end
   end
   
   it "should only return people ordered by age decending" do
     last_highest = 100
     results.each do |result|
       expect(result[:age]).to be <= last_highest
       last_highest = result[:age]
     end
   end
end
*/