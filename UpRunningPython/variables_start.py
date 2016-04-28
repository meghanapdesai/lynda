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
  #global f
  f = "def"
  print f
  
somefunction()
print f

