# Alternative Programming Language Project - Round 2

Alternative Language Project - Round 2
Purpose: To practice and demonstrate proficiency in using either Java and/or Python.

Skills Used: Programming with a new language 

Knowledge Goals: All programming concepts and structures with known languages

  

## Summary 
This assignment is identical to the Alternative Language Project except now you will write it in either Java or Python. You are welcome to not use OOP at all this time, if you want. Writing this in Java and using OOP will give you excellent practice for the final exam. It will be assessed as follows:

Full completion in one language nets you +50 on your Alternative Language Project to a maximum of 100 or drop one quiz score. You will specify this in the text entry box when you submit this. You may do it in Java and Python both but this will net no further reward, points wise.

In this assignment, you are going to be given the opportunity to explore a new programming language. You will be given a project idea. The programming languages you may complete this project in are below. Be careful and ensure you can set up the environment in order to work with the language of your choice. You will choose either Java Python.

***The rest of this document is the same as the original Alternative Language Project.***


**Please note, you now have a Git usage in command line requirement with each project. Please see "Some other items of importance" below for more on this.** 

For this project, you will read in a CSV file that has statistics for 1000 cell phones. You will then create a class called Cell and assign the column as class attributes. Create getter and setter methods. The objects will be stored in 3 different data structures. You can use the data structures native to the language. You are also free to pick what these data structures are but one of them must be a HashMap or something similar. 

 

## Data Ingestion and Cleaning
You must perform transformations on the data as it comes in or after it is been ingested. This a process called data cleaning and these are the steps:

1. Replace all missing or "-" values with null or something similar that can be ignored during calculations.
2. Transform data in appropriate columns according to instructions. For example in the body_weight column, a typical value is '190 g (6.70 oz)'' and needs to be converted to '190'.
3. Convert data types in appropriate columns
 

Note: Be aware: a null value can look very different in different languages. Research how your language represents null values and use what makes most sense.


 

## Methods
Within each class, you will create a series of methods that will perform operations on the new objects. There must be at least 7 methods/functions in your Cell class, not including getter and setter methods or the methods you use for transformation. Be creative and think critically, its your choice on what these are. Some ideas: 

  - ToString method that will convert your objects details to a string for printing.
    
  - Calculate statistics on columns, for numeric, descriptive stats such as mean, median, standard deviation, etc. For categorical columns, perhaps Mode or count of unique values.
    
  - Listing of unique values for each column.
    
  - Ability to add an object and input data for each object's variable.
    
  - Ability to delete an object. 
 

## Testing
If your programming language has the ability to do unit testing, implement unit tests for your methods. If not, write a series of testing outputs to verify your methods work properly. On top of a unit test for each methods, there are three tests you are required to have:

  - Ensure the file being read is not empty.
    
  - Ensure each column's final transformation matches what is stated above as its final form (ex: test if display_size is now a float)
    
  - Ensure all missing or "-" data is replaced with a null value.
  

## Report
Please include a README.md file with your repo that will serve as a survey of your explored programming language. Within it discuss several things in a few paragraphs:

  - Why did you pick this programming language?
    
  - How your programming language chosen handles: object-oriented programming, file ingestion, conditional statements, assignment statements, loops, subprograms (functions/methods), unit testing and exception handling. If one or more of these are not supported by your programming language, indicate it as so.
    
  - List out 3 libraries you used from your programming language (if applicable) and explain what they are, why you chose them and what you used them for.

  - Answer the following questions:

      - What company (oem) has the highest average weight of the phone body?
        
      - Was there any phones that were announced in one year and released in another? What are they? Give me the oem and models.
    
      - How many phones have only one feature sensor?
        
      - What year had the most phones launched in the 2000s? 
  

## Some other items of importance 

  - Part of your grade will come from evidence of using Git in the command line to manage your project. This aligns with the highly-rated goal from our industry partners and best practices to ensure students are comfortable navigating command line and using git. You are required to check in and push 3 screenshots of your command line while you are using Git to perform actions with your repo. One must show adding files to the local repo (staging), another must show a commit and the last must show a push to remote (Github).
    
  - Use javadoc comments on your functions to explain what they do. You do not have to do this in the class implementations where there is an interface, you can use @inheritDoc. 

  - Be sure your code is clean, legible and easy to read. 

  - Feel free to go above and beyond!  Add new methods and functionality, test in different ways in addition to what you are required to do, be creative! The top grades go to those who go above and beyond. Strive for excellence. 

  - Including the runtime as a comment on algorithms with loops in them will be seen as going above and beyond as well. 
  

## Format Requirements 
  - Please ensure you follow the structure as listed above. Use the appropriate environment to create your code and run it. Provide reasonable amounts of comments, explaining your code.
    
  - You are not required to use Gradle for this project.
    
  - Your submissions will be by providing a link to your repo. 

  - For your README.md report, be as professional as possible. I am not putting direct limitations on its length.    
