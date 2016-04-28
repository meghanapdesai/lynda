# 
# Example file for variables
# (For Python 3.x, be sure to use the ExampleSnippets3.txt file)

# Declare a variable and initialize it
f = 0;
print f

# re-declaring the variable works
f = "abc"
print f

# ERROR: variables of different types cannot be combined - have to convert
#print "string type " + 123
print "string type " + str(123)

# Global vs. local variables in functions
def someFunction():
  #global f #if we uncomment out code it affects the above value of f (outside of the function)
  f = "def"
  print f
  
someFunction()
print f

del f # delete the variable and assignment so below should give error
print f