#
# Example file for working with loops
# (For Python 3.x, be sure to use the ExampleSnippets3.txt file)

def main():
  x = 0
  # define a while loop (print 0-4)
  while (x < 5):
     print x
     x = x + 1
  
  # define a for loop -> print 5-9
  for x in range(5,10):
    print x

  # use a for loop over a collection
  days = ["Mon","Tue","Wed","Thu","Fri","Sat","Sun"]
  for d in days:
    print d

# use the break and continue statements (break ->print 5,6; 
# continue -> if remainder don't print out skip rest of loop ->print 5,7,9

  for x in range(5,10):
    #if (x == 7): break
    #if (x % 2 == 0): continue
    print x
    
#using the enumerate() function to get index so will print out 0 Mon, 1 Tue, etc
  days = ["Mon","Tue","Wed","Thu","Fri","Sat","Sun"]
  for i, d in enumerate(days):
    print i, d


if __name__ == "__main__":
  main()
  
  
