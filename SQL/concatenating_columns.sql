/*
https://www.codewars.com/kata/sql-concatenating-columns/train/sql

Difficulty: 7 kyu

Given the table below:

names table schema

id
prefix
first
last
suffix
Your task is to use a select statement to return a single column table containing the full title of the person (concatenate all columns together except id), as follows:

output table schema

title
Don't forget to add spaces.

FUNDAMENTALS, STRINGS, SQL, DATABASES, INFORMATION SYSTEMS, DATA
*/

SELECT CONCAT(n.prefix, ' ', n.first, ' ', n.last, ' ', n.suffix) AS title
    FROM names AS n

/**************************************************/
/**************************************************/
/**************************************************/

/*
results = run_sql

describe :query do
  describe "should contain keywords" do
    it "should contain SELECT" do
      expect($sql.upcase).to include("SELECT")
    end

    it "should contain FROM" do
      expect($sql.upcase).to include("FROM")
    end
  end

  describe :columns do
    it "should return 1 column" do
      expect(results.first.keys.count).to eq 1
    end
    
    it "should return a title column" do
      expect(results.first.keys).to include(:title)
    end
  end
end
*/