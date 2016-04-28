#
# Example file for working with functions
# (For Python 3.x, be sure to use the ExampleSnippets3.txt file)

# define a function
def func1():
  print "I am a function"

# function that takes arguments
def func2(arg1, arg2):
  print arg1, " ", arg2

# function that returns a value
def cube(x):
  return x*x*x

# function with default value for an argument
def power(num, x=1):
  result = 1;
  for i in range(x):
    result = result * num  
  return result

#function with variable number of arguments
def multi_add(*args):
  result = 0;
  for x in args:
    result = result + x
  return result

########## Calling functions ################################  

func1() # Calling function
#print func1() # Calling function and then printing return value (None)
#print func1 # Print value of func1 object

func2(10,20) # Calling function
#print func2(10,20) # Calling function and then printing return value (None)

print cube(3)

